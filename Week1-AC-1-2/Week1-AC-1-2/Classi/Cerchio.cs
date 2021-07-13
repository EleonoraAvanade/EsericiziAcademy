using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_AC_1_2.Classi
{
    public class Cerchio : Shape
    {
        public int[] coordinate { get; set; }
        public double raggio;
        public Cerchio()
        {
            coordinate = new int[2];
        }
        public override double Area()
        {
            double A = raggio * raggio * Math.PI;
            return A;
        }

        public override void drawShape(StreamWriter writer)
        {
            writer.WriteLine("Le coordinate del cerchio sono: [ {0}, {2} ]\n" +
                "Il raggio del cerchio vale: {1}\n" +
                "Calcolo l'area del triangolo...\n", coordinate[0], raggio, coordinate[1]);
            double A = Area();
            writer.WriteLine("L'area del cerchio è: {0}\n\n", A);
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
