using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSequenceGenerator
{
    public class GeneratorParameters
    {
        public GeneratorParameters(int length, int x0, int a, int c)
        {
            this.length = length;
            this.x0 = x0;
            this.a = a;
            this.c = c;
        }

        public void ConvertToMulti()
        {
            c = 0;
        }

        public int length;
        public int x0;
        public int a;
        public int c;
    }
}
