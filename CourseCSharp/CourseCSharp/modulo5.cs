using System;
using System.Collections.Generic;
using System.Text;

namespace CourseCSharp
{
    public class modulo5
    {
        public void Crescedecr(){

            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            while (X != Y)
            {
                X = int.Parse(Console.ReadLine());
                Y = int.Parse(Console.ReadLine());

                if (X > Y)
                {
                    Console.WriteLine("Decrescente");
                }
                else if(X < Y)
                {
                    Console.WriteLine("Crescente");
                }
            }
        }

        public void somaIdade()
        {
            double idade = int.Parse(Console.ReadLine());
            int count = 0;
            double somaIdade = 0.0;

            while (idade > 0)
            {
                somaIdade += idade;
                count += 1;
                idade = int.Parse(Console.ReadLine());
            } 

            Console.WriteLine("A média das idades é igual a : " + somaIdade / count);
        }
    }
}
