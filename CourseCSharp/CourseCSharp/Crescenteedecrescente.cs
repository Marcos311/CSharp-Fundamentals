using System;
using System.Collections.Generic;
using System.Text;

namespace CourseCSharp
{
    public class CrescenteeDecrescente
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
    }
}
