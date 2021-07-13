using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_AC_1_2
{
    public interface IFileSerializable
    {
        public bool SaveToFile(string fileName);
        public bool LoadFromFile(string fileName);
    }
}
