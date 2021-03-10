using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garagemanagement
{
    public class ComData
    {
        public List<dynamic> paramList;

        public ComData()
        {
            Reset();
        }
        public void Reset()
        {
            paramList = new List<dynamic>();
        }

        public void Set(int index, dynamic val)
        {
            if (val == null)
            {
                return;
            }

            if (index < 0)
            {
                return;
            }
            dynamic returned;
            try
            {
                returned = paramList.ElementAt(index);
            }
            catch
            {
                returned = null;
            }

            if (returned != null)
            {
                paramList.RemoveAt(index);
            }
            paramList.Insert(index, val);
        }
        public void Get(int index, ref string val)
        {
            dynamic dynamic = "";
            Getx(index, ref dynamic);
            val = dynamic.ToString();
        }
        public void Get(int index, ref int val)
        {
            dynamic dynamic = 1;
            Getx(index, ref dynamic);
            val = dynamic;
        }
        public void Get(int index, ref uint val)
        {
            dynamic dynamic = 1;
            Getx(index, ref dynamic);
            val = dynamic;
        }
        public void Get(int index, ref long val)
        {
            dynamic dynamic = 1;
            Getx(index, ref dynamic);
            val = dynamic;
        }
        public void Get(int index, ref ulong val)
        {
            dynamic dynamic = 1;
            Getx(index, ref dynamic);
            val = dynamic;
        }
        public void Get(int index, ref float val)
        {
            dynamic dynamic = 1.0f;
            Getx(index, ref dynamic);
            val = dynamic;
        }
        public void Get(int index, ref double val)
        {
            dynamic dynamic = 1.00;
            Getx(index, ref dynamic);
            val = dynamic;
        }
        public void Get(int index, ref bool val)
        {
            dynamic dynamic = false;
            Getx(index, ref dynamic);
            val = dynamic;
        }
        public void Getx(int index, ref dynamic val)
        {
            if (index < 0) return;

            dynamic returned;
            try
            {
                returned = paramList.ElementAt(index);

                if (returned == null) return;

                if (returned.GetType() == val.GetType())
                {
                    val = returned;
                }
            }
            catch
            { }
        }
        public int GetType(int index)
        {
            if (index < 0)
            {
                return 0;
            }

            dynamic returned;
            try
            {
                returned = paramList.ElementAt(index);
                if (returned == null)
                {
                    return 0;
                }
            }
            catch
            {
                return -1;
            }
            string typename = returned.GetType().ToString();

            switch (typename)
            {
                case "System.String":
                    {
                        return 1;
                    }
                case "System.Int32":
                    {
                        return 2;
                    }
                case "System.UInt32":
                    {
                        return 3;
                    }
                case "System.Single"://float
                    {
                        return 4;
                    }
                case "System.Int64"://long
                    {
                        return 5;
                    }
                case "System.UInt64"://unsigned long
                    {
                        return 6;
                    }
                case "System.Double":
                    {
                        return 7;
                    }
                /*long double. LOL*/
                case "System.SByte":
                case "System.Char":
                    {
                        return 9;
                    }
                case "System.Byte":
                    {
                        return 10;
                    }
                case "System.Bool":
                    {
                        return 11;
                    }
                case "Garagemanagement.ComData":
                    {
                        return 12;
                    }
                default:
                    {
                        return 0;
                    }
            }
        }
        public override string ToString()
        {
            //TODO
            return "";
        }
    }
}