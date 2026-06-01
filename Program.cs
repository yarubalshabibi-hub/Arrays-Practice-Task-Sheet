namespace Arrays_Practice_Task_Sheet
{
    internal class Program
    {
        public static void temp1()
        {
            double[] temperatures = { 11, 22, 33, 44, 55, 66, 77 };


            for (int i = 0; i < temperatures.Length; i++)
            {
                Console.WriteLine("Day " + (i + 1) + ": " + temperatures[i] + " C");
            }


            Console.WriteLine("Total readings: " + temperatures.Length);
        }
     static void Main(string[] args)
            {
            temp1();
            }
        }
    }



    

