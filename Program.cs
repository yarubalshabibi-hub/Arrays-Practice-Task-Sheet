using System.Security.Cryptography.X509Certificates;

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
        public static void score()
        {
            int[] scores = { 85, 92, 70, 60, 88, 75 };


            Console.WriteLine("Original order: ");
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }
            Array.Reverse(scores);
            Console.WriteLine("Reversed order: ");
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }
        }



        public static void prices()
            {
                double[] prices = { 4.99, 12.50, 7.25, 19.99, 3.75 };


                Console.WriteLine("Product prices:");
                for (int i = 0; i < prices.Length; i++)
                {
                    Console.WriteLine("Product " + (i + 1) + ": " + prices[i]);
                }


                double target = 7.25;
                int index = Array.IndexOf(prices, target);

                if (index != -1)
                {
                    Console.WriteLine("Price " + target + " found at index " + index);
                }
                  
                else
                {
                    Console.WriteLine("Price " + target + " not found");
                }
                    
            }



        public static void FinishTimes()
        {
            int[] finishTimes = { 312, 285, 340, 298, 265, 320, 275, 355 };

            Console.WriteLine("Original finish times:");
            foreach (int time in finishTimes)
            {
                Console.WriteLine(time + " seconds");
            }

            Array.Sort(finishTimes);
            Console.WriteLine("Sorted finish times (fastest first):");
            foreach (int time in finishTimes)
            {
                Console.WriteLine(time + " seconds");
            }

            Console.WriteLine("Total participants: " + finishTimes.Length);

        }



        public static void grade()
        {
            int[] grades = { 72, 88, 95, 60, 45, 78, 91, 83, 55, 67 };

            Array.Sort(grades);

            Array.Reverse(grades);

            Console.WriteLine("Grade Report (Highest to Lowest):");
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine("Rank " + (i + 1) + ": " + grades[i]);

            }
        }

        static void Main(string[] args)
        {


            Console.WriteLine("select one option please: ");
            Console.WriteLine("1.");
            Console.WriteLine("2.");
            Console.WriteLine("3.");
            Console.WriteLine("4.");
            Console.WriteLine("5.");
            Console.WriteLine("6.");
            Console.WriteLine("7.");
            Console.WriteLine("8.");
            Console.WriteLine("9.");
            Console.WriteLine("10.");



            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    temp1();
                    break;

                case 2:
                    score();
                    break;

                case 3:
                    prices();
                    break;

                case 4:
                    FinishTimes();
                    break;

                case 5:
                    grade();
                    break;

                case 6:
                    break;

                case 7:
                    break;

                case 8:
                    break;

                case 9:
                    break;

                case 10:
                    break;


            }
        }
    }
}
    



    

