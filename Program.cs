using _16AugHomeWork.Models;
using System;

namespace _16AugHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int checker = 0;
            
            do
            {
                Console.WriteLine("Which figure  you want to find area? \n 1.Square \n 2.Rectangular \n 0.Exit ");
                checker = Convert.ToInt32(Console.ReadLine());
                if (checker == 1)
                {
                    Console.Write("Enter side of square:");
                    decimal Side = Convert.ToDecimal(Console.ReadLine());
                    Square square = new Square(Side);
                    Console.WriteLine(square.CalcArea());


                }
                else if (checker == 2)
                {
                    Console.Write("Enter width of rectangular:");
                    decimal Width = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Enter length of rectangular:");
                    decimal Length = Convert.ToDecimal(Console.ReadLine());
                    Rectangular rectangular = new Rectangular(Width, Length);
                    Console.WriteLine(rectangular.CalcArea());
                }
                else if (checker != 0) 
                {
                    Console.WriteLine("Please enter valid character!!!");
                }

                


            } while (checker!=0);


            Console.WriteLine("Thanks for using my code :)");
                

                
        }
    }
}
