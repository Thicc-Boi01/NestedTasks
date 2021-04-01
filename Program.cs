using System;

namespace Nedted
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name:");
            String Name =Console.ReadLine();

            int counter1= 0;

            while(counter1 < 10){
                int counter2 = counter1;

                while(counter2 < 5){
                    Console.Write(Name);
                    counter2++;
                }
                Console.WriteLine();
                counter1++;
            }
                
                
             Console.WriteLine("Goodbye "+Name);

        }
    }
}

