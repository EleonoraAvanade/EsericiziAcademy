using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_AC_1_2.Classi
{
    public abstract class Shape:IFileSerializable
    {
        public string Nome { get; set; }
        public abstract double Area();
        public abstract void drawShape(StreamWriter writer);

        public abstract bool LoadFromFile(string fileName);

        public abstract bool SaveToFile(string fileName);
    }
}
