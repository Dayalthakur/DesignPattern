namespace DesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //Console.WriteLine("No of stars for Right-Angle Triangle Pattern : ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("\n");



            //Console.WriteLine("No of stars for Inverted Right-Angle Triangle Pattern : ");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //for (int i = n1; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("\n");


            //Console.WriteLine("No. of rows for pyramid pattern : ");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= n2; i++)
            //{
            //    for (int space = i; space < n2; space++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("* ");
            //    }

            //    Console.WriteLine();
            //}


            Console.WriteLine("Diamond Pattern");
            int n3 = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n3; i++)
            {
                for(int space = i; space < n3; space++)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                } 
                Console.WriteLine();
            }
            for (int i=n3-1;i>=1;i--)
            {
                for(int space = i; space < n3; space++)
                {
                    Console.Write(" ");
                }
                for(int j= 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}