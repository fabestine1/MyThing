using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garagemanagement
{
    class StringEater
    {
        private string CompleteText;
        public string buffer;
        private int endIndex;
        private int length;
        private int startIndex;

        private int isEating;


        public StringEater()
        {
            CompleteText = "";
            buffer = "";
        }
        public void String(string eatable_string)
        {
            CompleteText = eatable_string;
	        reset();
        }
        public string String()
        {
	        return CompleteText;
        }
        public bool finished()
        {
	        return endIndex == length;
        }
        public int endindex()
        {
            return endIndex;
        }
        public void eat(int endindex)
        {
            eat(startIndex, endindex);
        }
        public void eat(int startindex, int endindex)
        {
	        if (startindex < 0)return;

            buffer = CompleteText.Substring(startindex, endindex + 1 - startindex);
            String(CompleteText.Substring(endindex + 1 - startindex));
        }
        public void eat(int startindex, int endindex, int skip)
        {
	        if (startindex < 0)return;

            buffer = CompleteText.Substring(startindex, endindex + 1 - startindex);
            String(CompleteText.Substring(endindex + 1 - skip - startindex));
        }
        //delegate int(*condition_func)(int currentindex, char character, string *buffer)

        public void eatUntil(Func<int,char, string, int> condition_func)
        {
		        if (isEating == 0)
		        {
			        isEating = 1;
			        endIndex = startIndex;
			        buffer = "";
			        while (isEating!=0 && endIndex<length)
			        {
                        char chr = CompleteText[endIndex];
				        isEating = condition_func(endIndex, chr, buffer);
				
				        if (isEating < -198)
				        {
					        int skip = (isEating + 198);
					        endIndex += skip;
					        isEating = 0;

					        eat(startIndex, endIndex, skip);
					        return;
				        }
				        else if (isEating < -98)
				        {
					        endIndex += (isEating + 98);
					        isEating = 0;

					        eat(endIndex);
					        return;
				        }
				        else if (isEating == 0)
				        {
					        eat(endIndex);
					        return;
				        }
				        else if (isEating > 98)
				        {
					        endIndex += (isEating - 98);
					        isEating = 0;

					        eat(endIndex);
					        return;
				        }
				        else
				        {
					        endIndex += isEating;
				        }
			        }
			        eat(endIndex);
                }
		    }
            public void reset(int index)
            {
	            startIndex = index;
	            length = (CompleteText.Length-1);
	            isEating = 0;
            }
            public void reset()
            {
	            startIndex = 0;
	            length = (CompleteText.Length-1);
	            isEating = 0;
            }
    }
}