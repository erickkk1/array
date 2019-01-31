using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring an array
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            try
            {

                foreach (int i in numbers)
                {
                    Console.WriteLine("Element Value={0}", +i);
                }
                Console.WriteLine("");
                Console.WriteLine("__________________________________________");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);
            }//End of  a try


            catch
            {
                Console.WriteLine("Please exit now.");
                Console.ReadKey(true);
            }
            

           
        }
    }
}
