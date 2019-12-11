using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text2Bf
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] text = new char[0];
            if (args.Length > 0)
            {
                text = args[0].ToCharArray();
            }
            int x = 0;
            for (int i = 0; i < text.Length; i++)
            {
                int z = (int)text[i] - x;
                x += z;
                Console.Write($"Cell={x} \t");
                for (int y = 0; y < Math.Abs(z); y++)
                {
                    Console.Write(z < 0 ? "-":"+");
                }
                Console.Write($".\n");
            }
            
        }
    }
}
