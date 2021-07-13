using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_AC_1_2.Classi
{
    public class Rettangolo : Shape
    {
        public double Larghezza { get; set; }
        public double Altezza { get; set; } 
        public override double Area()
        {
            return Larghezza * Altezza;
        }

        public override void drawShape(StreamWriter writer)
        {
            writer.WriteLine("La base del rettangolo vale: {0}\n" +
                "L'altezza del rettangolo vale: {1}\n" +
                "Calcolo l'area del rettangolo...\n", Larghezza, Altezza);
            double A = Area();
            writer.WriteLine("L'area del triangolo è: {0}\n\n", A);
        }

        public override bool LoadFromFile(string fileName)
        {
            Console.WriteLine("Questo sarà il metodo {0} \n", "LoadFromFile");
            return true;
        }

        public override bool SaveToFile(string fileName)
        {
            Console.WriteLine("Questo sarà il metodo {0} \n", "SaveToFile");
            return true;
        }
    }
}
