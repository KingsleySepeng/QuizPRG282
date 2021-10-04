using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WPFActivity
{
    class DataHandler
    {
        static FileInfo fi = new FileInfo(@"Untitled.txt");
        string path = @"C:\Users\Mecer\source\repos\WPFActivity\bin\Debug\untitled.txt";

        public string readStream()
        {

            FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);


            StreamReader sr = new StreamReader(fs);


            string fileContent = sr.ReadToEnd();


            sr.Close();
            fs.Close();

            return fileContent;

        }

        public string readFile()
        {
            string s;
            string ss = " ";

            // Opening the file for reading

            StreamReader sr = File.OpenText(path);
           

            return ss;
        }
    }

}

