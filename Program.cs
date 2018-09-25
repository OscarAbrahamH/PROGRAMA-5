using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMA_5
{
    class Programa8
    {
        public void Programa8()
        {
            int Repeticion = 0;
            int Posicion = 0;
            int Mayor1 = 0;
            int[] Vector = new int[51];


            Random Random1 = new Random();
            for (int X = 0; X < 1; X++)
            {
                Vector[X] = Random1.Next(1, 70);
                Console.WriteLine(Vector[X]);
            }

            for (int X = 0; X < 51; X++)
            {
                if (X == 0)
                {
                    Mayor1 = Vector[0];
                }
                else if (Vector[X] > Mayor1)
                {
                    Mayor1 = Vector[X];
                }
            }
            for (int X = 0; X < 51; X++)
            {
                if (Mayor1 == Vector[X])
                {
                    Repeticion = Repeticion + 1;
                    Posicion = X;
                
            }
            Console.WriteLine("Numero Mayor: " + Mayor1);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {

        }
    }
}
