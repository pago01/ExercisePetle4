using System;
using System.ComponentModel.Design;

namespace ExercisePetle4
{
    class Program
    {
        private static void Main(string[] args)
        {


            int a = 0;
            int b = 1;
            int c = 1;
            //Numer read
            Console.WriteLine("Podaj liczbę");
            Int32.TryParse(Console.ReadLine(), out a);

            //Calculation
            while(a >= b)
            {
                for (int i = 0; i <= c; i++)
                {
                    if (a >= b)
                    {
                        if (i == 0)
                        {
                            Console.WriteLine(b);
                            b++;
                        }
                        else
                        {
                            Console.Write(b);
                            b++;
                        }
                    }
                }
                c++;
            }
        }
            
        
            
            
            
        
    }
}
