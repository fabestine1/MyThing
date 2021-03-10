using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace project_5._1
{
    class TextFileHelper
    {
        public string FileName { get; set; }

        public TextFileHelper(string fileName)
        {
            FileName = fileName;
        }
        public TextFileHelper()
        {
            FileName = null;
        }
        public void SaveToFile(List<string> lines)
        {
            FileStream fs;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);
                foreach (string line in lines)
                {
                    sw.WriteLine(line);
                }
            }
            catch(IOException)
            {
            }
            finally
            {
                if (sw != null) sw.Close();
            }
        }
        public List<string> LoadFromFile()
        {
            FileStream fs;
            StreamReader sr = null;
            List<string> fileContent = new List<string>();
            try
            {
                fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                while(line != null)
                {
                    fileContent.Add(line);
                    line = sr.ReadLine();
                }
                return fileContent;
            }
            catch (IOException)
            {
            }
            finally
            {
                if (sr != null) sr.Close();
            }
            return fileContent;
        }
    }
}
