using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практика_16
{
    class Class1
    {
        int[] x;
        public Class1()
        {
            for (int i = 0; i < 10; i++)
            {
                x[i] = i;
            }
        }
        public Class1(string s)
        {
            string[] s1 = s.Split(' ');
            x = new int[s1.Length];
            for (int i = 0; i < s1.Length; i++)
            {
                x[i] = int.Parse(s1[i]);
            }
        }
        public int length
        {
            get
            {
                return x.Length;
            }

        }
        public int[] ConvertTo2()
        {
            int[] x2 = new int[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; x[i] > 0; j++)
                {
                    if (x[i] % 2 != 0) x2[i] = x2[i] + (int)Math.Pow(10, j);
                    x[i] = x[i] / 2;
                }
            }
            return x2;
        }
        public int[] ConvertTo8()
        {
            int[] x2 = new int[x.Length];
            for(int i = 0; i < x.Length; i++)
            {
                for(int j = 0; x[i] > 0; j++)
                {
                    if (x[i] % 8 != 0) x2[i] = x2[i] + (int)((x[i] % 8) * Math.Pow(10, j));
                    x[i] = x[i] / 8;
                }
            }
            return x2;
        }
        public int[] ConvertTo16()
        {
            int[] x2 = new int[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; x[i] > 0; j++)
                {
                    if (x[i] % 16 != 0) x2[i] = x2[i] + (int)((x[i] % 16) * Math.Pow(10, j));
                    x[i] = x[i] / 16;
                }
            }
            return x2;
        }
    }
}
