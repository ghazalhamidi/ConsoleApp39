using System;

namespace project1
{
    class test1
    {
        public static void main()
        {
            int x = Convert.ToDouble32(Console.ReadLine());
            int y = Convert.ToDouble32(Console.ReadLine());

            double R = calc(x, y);
            Console.WriteLine(R);
        }//end main
        private double calc(double x,double y)
        {
            double result = 0.35 * x + 0.65 * y;
            return result;

        }
    }

}