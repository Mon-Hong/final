using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number of items : ");
            int number = int.Parse(Console.ReadLine());
            string[,] name = new string[number, 2];

            for (int i = 0; i < number; i++)
            {

                Console.Write("Input item name : ");

                name[i, 0] = Console.ReadLine();

                Console.Write("Input item type : ");

                name[i, 1] = Console.ReadLine();
            }
            string search;
            string end;

            do
            {
                end = "End";
                Console.Write("\nSearch : ");
                search = Console.ReadLine();
                Console.Write("\n");

                for (int i = 0; i < number; i++)
                { }

                    if (search == "ShowAll")
                {
                    for (int i = 0; i < number; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            Console.WriteLine(" {0} ", name[i, j]);

                        }
                        Console.WriteLine();

                    }
                }

                for (int i = 0; i < number; i++)
                {
                    if (search == name[i, 0])
                    {
                        for (int j = 0; j < number; j++)
                        {

                            Console.WriteLine(" \n{0} ", name[j, 0]);

                        }
                        
                        
                    }
                }
                for (int i = 0; i < number; i++)
                {
                    if (search == "ShowAll" || search == name[i, 0] )
                    {
                        
                        end = "0";
                    }
                }
            
            } while(end == "0");

            Console.WriteLine("\nEnd");

        }
    }
}
