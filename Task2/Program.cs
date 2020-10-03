using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {  //fibonacci algorithm
        static void Main(string[] args)
        {
            int[] alg = new int [3];
            alg[0] = 0;
            alg[1] = 1;
            
            int value = Convert.ToInt32(Console.ReadLine());
            Console.Write(alg[0] + " " + alg[1]);
            do
            {
                
                alg[2] = alg[0] + alg[1];
                alg[0] = alg[1];
                alg[1] = alg[2];
                Console.Write(" " + alg[2]);
                if (alg[2] > value) 
                {
                    Console.Clear();
                    Console.WriteLine("Not found");
                    break; 
                }; 
            }
            while (alg[2] != value);
        }
    }
}
