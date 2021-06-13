using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Number of numbers to sort : ");
                int num_data = int.Parse(Console.ReadLine());

                int[] number = new int[num_data];

                for(int i = 0; i < num_data; i++)
                {
                
                    Console.Write("Input number : ") ;
                
                    number[i] = int.Parse(Console.ReadLine());  
                }

            sortone(number, num_data);
            Console.WriteLine();
            sorttwo(number, num_data);
            Console.WriteLine();

            sortthree(number, num_data);
            sortfour(number, num_data);


        }

        static void sortone(int[] number,int num_data)
        {
            /*
            for (int i = 0; i < num_data; i++)
            {
                Console.WriteLine(number[i]);   
            }*/

            

            //วิธีทื่ 1
            for (int i = 0; i < num_data; i++)
            {

                for (int j = i+1; j < num_data; j++)
                { 
                    
                    if (number[j] < number[i])
                    {
                        int x = number[i];

                        number[i] = number[j];

                        number[j] = x;
                    }
                    
                }
            }
            Console.Write("Method 1 ");
            for (int j = 0; j < num_data; j++)
            {
                Console.Write(" {0}",number[j]);
            }
        }


        static void sorttwo(int[] number, int num_data)
        {

            //วิธีทื่ 2
            for (int i = 0; i < num_data-1; i++)
            {

                for (int j = i + 1; j < num_data; j++)
                {

                    if (number[j] < number[i])
                    {
                        int x = number[i];

                        number[i] = number[j+1];

                        number[j] = x;
                    }

                }
            }






            Console.Write("Method 2 ");
            for (int j = 0; j < num_data; j++)
            {
                Console.Write(" {0}", number[j]);
            }
        }


        static void sortthree(int[] number, int num_data)
        {

            //วิธีทื่ 3
            for (int i = 0; i < num_data - 1; i++)
            {

                for (int j = i + 1; j < num_data-1; j++)
                {

                    if (number[j] < number[i])
                    {
                        int x = number[i+1];

                        number[i] = number[j + 1];

                        number[j] = x;
                    }

                }
            }






            Console.Write("Method 3 ");
            for (int j = 0; j < num_data; j++)
            {
                Console.Write(" {0}", number[j]);
            }
        }



        static void sortfour(int[] number, int num_data)
        {
            
        }
    }
}
