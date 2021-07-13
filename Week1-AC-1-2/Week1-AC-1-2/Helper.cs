using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1_AC_1_2.Classi;

namespace Week1_AC_1_2
{
    public class Helper
    {
        private static string path=@"C:\Users\eleonora.lombardo\Desktop\Shape.txt";
        public static bool Menu(List<Shape> fig)
        {
            Writer_Reader writer_Reader = new Writer_Reader();
            Console.WriteLine("Scegli quale operazione fare: \n" +
                "\t1 - Calcola l'area e mostra la lista delle una figure salvate\n" +
                "\t2 - Immetti i dati e aggiungi la figura alla lista\n" +
                "\t3 - Esci\n");
            double index = Input(3);
            if (index == 3) return false;
            else if (index == 1)
            {
                Console.WriteLine("\n\n\n");
                if (fig.Count == 0) { Console.WriteLine("Nessuna figura salvata\n"); return true; }
                foreach (object ob in fig)
                {
                    ((Shape)ob).drawShape(new StreamWriter(Console.OpenStandardOutput()));
                    writer_Reader.LoadFromFile(path);
                }
            }
            else
            {
                InsertANewOneAndCalcArea(fig);
            }
            return true;
        }

        private static void InsertANewOneAndCalcArea(List<Shape> fig)
        {
            Console.Clear();
            Console.WriteLine("Quale figura vuoi aggiungere?\n" +
                "\t1 - Rettangolo\n" +
                "\t2 - Triangolo\n" +
                "\t3 - Cerchio\n" +
                "\t4 - Indietro\n");
            double input = Input(4);
            Shape l=null;
            if (input == 4) return;
            if (input == 1||input==2) { 
                Console.WriteLine("Immetti base e altezza: \n");
                double bas,alt ;
                Double.TryParse(Console.ReadLine(), out bas);
                Double.TryParse(Console.ReadLine(), out alt);
                if (input == 1)
                {
                    Rettangolo r = new Rettangolo();
                    r.Altezza = alt;
                    r.Larghezza = bas;
                    l = r;
                    Writer_Reader writer_Reader = new Writer_Reader();
                    writer_Reader.shape = l;
                    writer_Reader.SaveToFile(path);
                }
                else
                {
                    Triangolo r = new Triangolo();
                    r.Altezza = alt;
                    r.Base = bas;
                    l = r;
                    Writer_Reader writer_Reader = new Writer_Reader();
                    writer_Reader.shape = l;
                    writer_Reader.SaveToFile(path);
                }
            }
            else if(input==3)
            {
                Console.WriteLine("Immetti le coordinate del centro e il raggio: \n");
                double raggio;
                int[] coordinate = new int[2];
                Double.TryParse(Console.ReadLine(), out raggio);
                Int32.TryParse(Console.ReadLine(), out coordinate[0]);
                Int32.TryParse(Console.ReadLine(), out coordinate[1]);
                Cerchio r = new Cerchio();
                r.coordinate = coordinate;
                r.raggio = raggio;
                l = r;
                Writer_Reader writer_Reader = new Writer_Reader();
                writer_Reader.shape = l;
                writer_Reader.SaveToFile(path);
            }
            fig.Add(l);
        }

        private static double Input(int max)
        {
            double input = 0;
            while (input < 1 || input > max)
                while (!Double.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Inserisci un numero!\n");
                }
            return input;
        }
    }
}
