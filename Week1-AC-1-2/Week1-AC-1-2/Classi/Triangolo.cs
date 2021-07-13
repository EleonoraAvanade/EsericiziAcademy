using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_AC_1_2.Classi
{
    public class Triangolo : Shape
    {
        public double Base{get;set;}
        public double Altezza{get;set;}
        public override double Area()
        {
            double A = Base * Altezza / 2;
            return A;
        }

        public override void drawShape(StreamWriter writer)
        {
            writer.WriteLine("La base del triangolo vale: {0}\n" +
                "L'altezza del triangolo vale: {1}\n" +
                "Calcolo l'area del triangolo...\n", Base, Altezza);
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
