using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunter_2022_11_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] állat = new Animal[3];

            állat[0] = new PolarBear();
            állat[1] = new Rabbit();
            állat[2] = new Squirrel();

            for (int i = 0; i < állat.Length; i++)
            {
                Console.WriteLine(állat[i].GetType() + állat[i].getPrice());
            }
        }
    }
}
