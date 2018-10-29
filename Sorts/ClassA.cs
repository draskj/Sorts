using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    /// <summary>
    /// 
    /// </summary>
    public class ClassA
    {
        public static int NumberA { get; set; }
        public static int NumberB { get; set; }

        public int SomeNumber => NumberA > NumberB ? 1 : 0;

        public int SomeNumber2 = NumberA > NumberB ? 1 : 0;
    }
}
