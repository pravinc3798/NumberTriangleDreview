namespace NumberTriangle
{
    public class Triangle
    {
        public static void Create()
        {
            Console.Write("Input the length of Triangle : ");
            var length = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= length; i++)
            {
                for (int j = 1 ; j <= length - i; j++)  // spaces
                    Console.Write(" ");
                for (int k = 1; k <= i; k++)    // start series
                    Console.Write("{0}", k);
                for (int l = i - 1; l >= 1; l--) // end series
                    Console.Write("{0}", l);
                
                Console.WriteLine();   // next loop new line
            }
        }
    }
}