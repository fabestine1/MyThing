using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garagemanagement
{
    public class DataInterpretor
    {
        int data_open;
        private String priv_buffer;
        private ComData comdata;

        private bool escaped;
        private bool escaped_quote;
        private bool in_string;

        public char CommandSeparator { get { return ','; } }

        public bool usableInput { get; private set; }

        public DataInterpretor()
        {
            comdata = new ComData();
        }

        public void addChar(char chr)
        {
            DealWithChr(chr);
        }
        public void addString(string str)
        {
            int length = str.Length;

            for (int i = 0; i < length; i++)
            {
                DealWithChr(str[i]);
            }
        }
        public ComData getComData()
        {
            usableInput = false;
            //instantiate new comdata object and refer to that new object
            ComData data = comdata;
            comdata = new ComData();
            //end old object
            return data;
        }

        public void DealWithChr(char chr)
        {
            switch (chr)
            {
                case '{':
                    {
                        data_open++;
                        break;
                    }
                case '}':
                    {
                        data_open--;
                        if (data_open == 0)
                        {
                            dealWithInput(priv_buffer);
                            priv_buffer = "";
                        }
                        else if (data_open < 0)
                        {
                            throw new ApplicationException("Incoming data was not properly closed..");
                        }
                        break;
                    }
                default:
                    {
                        priv_buffer += chr;
                        break;
                    }
            }
        }

        public void dealWithInput(string str)
        {
            //Data between main brackets have been entered "{<buffer>}"

            StringEater eater = new StringEater();//initialise string eater object

            comdata.Reset();

            //set string to string eater
            eater.String(str);

            int index = 0;

            //iterate only till all parameter indexes have been filled
            while ((eater.String().Length != 0))//conditions: index < MAX_PARAM or 
            {
                eater.eatUntil(BracketEater_conditions);
                in_string = false;

                //when there is content in the buffer
                eater.buffer.Trim();

                if (eater.buffer.Length > 0)
                {
                    //cleanup trailing and leading whitespaces

                    //if parameter was a string, then remove quotes
                    if (eater.buffer[0] == '"' && eater.buffer[eater.buffer.Length - 1] == '"')
                    {
                        eater.buffer = eater.buffer.Substring(1, eater.buffer.Length - 2);

                        comdata.Set(index, eater.buffer);
                    }
                    else
                    {
                        switch (eater.buffer[0])
                        {
                            case 'i':
                                {
                                    int number;
                                    Int32.TryParse(eater.buffer, out number);

                                    comdata.Set(index, number);
                                    break;
                                }
                            case 'd':
                                {
                                    double number;
                                    double.TryParse(eater.buffer, out number);

                                    comdata.Set(index, number);
                                    break;
                                }
                            case 'f':
                                {
                                    float number;
                                    float.TryParse(eater.buffer, out number);

                                    comdata.Set(index, number);
                                    break;
                                }
                            case 'c':
                                {
                                    if (eater.buffer.Length > 1)
                                    {
                                        comdata.Set(index, eater.buffer[1]);
                                    }
                                    break;
                                }
                            default://automatic
                                {
                                    double number;
                                    double.TryParse(eater.buffer, out number);

                                    comdata.Set(index, number);

                                    //is a rounded number?
                                    if (number != 0 || eater.buffer == "0")
                                    {
                                        if (Math.Round(number) == number)
                                        {//int
                                            if (number > 4294967295)
                                            {
                                                comdata.Set(index, number);//array fits only in double
                                            }
                                            else
                                                if (number > 2147483647)
                                                {

                                                    comdata.Set(index, (ulong)number);
                                                }
                                                else
                                                    if (number > 65535)
                                                    {
                                                        comdata.Set(index, (long)number);
                                                    }
                                                    else
                                                        if (number > 32767)
                                                        {
                                                            comdata.Set(index, (uint)number);
                                                        }
                                                        else
                                                            if (number < -4294967295)
                                                            {
                                                                comdata.Set(index, number);//array fits only in double
                                                            }
                                                            else
                                                                if (number < -32767)
                                                                {
                                                                    comdata.Set(index, (long)number);
                                                                }
                                                                else
                                                                {
                                                                    comdata.Set(index, (int)number);
                                                                }
                                        }
                                        else
                                        {//just a double
                                            comdata.Set(index, number);
                                        }
                                    }
                                    else
                                    {
                                        comdata.Set(index, eater.buffer);
                                    }
                                    break;
                                }
                        }
                    }
                }

                //and count up parameter index
                index++;
            }
            //ELSE the buffer is empty, meaning no content between separator, like ',,,' (3x nothing)
            //do nothing

            usableInput = true;
        }

        public int BracketEater_conditions(int currentindex, char character, string buffer)
        {
            //dynamic variable cannot be used in switch
            if (CommandSeparator == character)
            {
                if (!in_string)
                {
                    escaped = false;
                    return -199;
                }
            }
            else
                switch (character)
                {
                    case '\\':
                        {
                            if (in_string)
                            {
                                escaped_quote = !escaped_quote;
                            }
                            else
                            {
                                escaped = !escaped;
                            }
                            break;
                        }
                    case '"':
                        {
                            if (in_string)
                            {
                                if (!escaped_quote)
                                {
                                    in_string = false;
                                    escaped_quote = false;
                                }
                            }
                            else
                            {
                                if (!escaped)
                                {
                                    in_string = true;
                                }
                            }
                            break;
                        }
                    default:
                        {
                            escaped = false;
                            break;
                        }
                }
            return 1;//next character
        }
    }
}