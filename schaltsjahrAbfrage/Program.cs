using System;

namespace MeinCSharpProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben sie das jahr ein für die abfrage");
            int jahr = Convert.ToInt32(Console.ReadLine());

            if (jahr % 4 == 0)
            {
                
                if (jahr % 100 == 0)
                {
                     System.Console.WriteLine(jahr + " ist kein schaltjahr");
                }
                else
                {
                    System.Console.WriteLine(jahr + " ist kein schaltjahr");
                    if (jahr % 400 == 0)
                    {
                        System.Console.WriteLine(jahr + " ist ein schaltjahr");
                    }
                    else
                    {

                        System.Console.WriteLine(jahr + " ist kein schaltjahr");
                
                    }
                   

                }
                    
            }
            else
            {

                System.Console.WriteLine(jahr + " ist kein schaltjahr");

            }
            
           
            
            Console.ReadLine();
        }
    }
}