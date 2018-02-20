using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace SystemFileReader
{
    public class Read
    {

        private object Locker = new object();
        string text = "";
        string readPath = @"C:\\Work";
        string writePath = @"C:\\Copy\\Copy.txt";


        public void Path()
        {
            lock (Locker)
            {
                DirSearch(@"C:\\Work");
                Console.ReadKey();

            }


            {
                try
                {
                    using (StreamReader sr = new StreamReader(readPath, System.Text.Encoding.Default))
                    {
                        text = sr.ReadToEnd();
                    }
                    using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(text);
                    }

                    using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                    {
                        sw.WriteLine("Дозапись");
                        sw.Write(4.5);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public void DirSearch(string dir)
        {
            lock (Locker)
            {

                try
                {

                    foreach (string f in Directory.GetFiles(dir))
                    {

                        Console.WriteLine(f);

                        Thread.Sleep(100);
                    }
                    foreach (string d in Directory.GetDirectories(dir))
                    {
                        Console.WriteLine(d);

                        Thread.Sleep(100);
                        DirSearch(d);

                    }


                }
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine(e.Message);
                }

            }


        }





    }
}
