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


        static void Main(string[] args)
        {

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

            Console.WriteLine("select option");
            int option = int.Parse( Console.ReadLine());
            switch(option)
            {
                case 1:
                    temp1();
                    break;
                case 2:
                    score();
                    break;
                
                    
            }
           

            
        }








    }
}
    



    

