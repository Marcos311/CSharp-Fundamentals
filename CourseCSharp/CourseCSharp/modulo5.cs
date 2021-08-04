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

            if (count == 0)
            {
                Console.WriteLine("Impossível calcular");
            } else
            {

                Console.WriteLine("A média das idades é igual a : " + somaIdade / count);
            }
        }

        public void forBasico()
        {
            int N = int.Parse(Console.ReadLine()), x, soma=0;

            for(int i=0; i < N; i++)
            {
                x = int.Parse(Console.ReadLine());
                soma += x;
            }

            Console.WriteLine(soma);
        }

        public void forValordei()
        {
            int Max = int.Parse(Console.ReadLine());

            for (int i = 0; i <= Max; i++)
            {
                Console.WriteLine("Valor de i: " + i);
            }
        }

        public void forValordeiDecr()
        {
            int Min = int.Parse(Console.ReadLine());

            for(int i=4; i >= Min; i--)
            {
                Console.WriteLine("Valor decrescente de i : " + i);
            }
        }
    }
}
