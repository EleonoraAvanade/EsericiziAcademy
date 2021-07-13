using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1_AC_1_2.Classi;

namespace Week1_AC_1_2
{
    public class Writer_Reader : IFileSerializable
    {
        public Shape shape { get; set; }
        public bool LoadFromFile(string fileName)
        {
            try
            {
                using (StreamReader reader = File.OpenText(fileName))
                {
                    if (reader != null)
                    {
                        string line = reader.ReadLine();
                        while (line != null)
                        {
                            Console.WriteLine(line + "\n");
                            line = reader.ReadLine();
                        }
                        Console.WriteLine("\n---End of file---\n");
                        return true;
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return false;
        }

        public bool SaveToFile(string fileName)
        {
            try
            {
                using(StreamWriter writer = File.CreateText(fileName))
                {
                    if (shape != null)
                    {
                        shape.drawShape(writer);
                    }
                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return false;
        }
    }
}
