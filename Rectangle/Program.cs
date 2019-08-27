using System;

namespace Rectangle
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Enter the length of the rectangle: ");

            // Get input from the user and save it to a variable.
            string lengthInput = Console.ReadLine();
            int length = Convert.ToInt32(lengthInput);

            Console.Write("Enter the width of the rectangle: ");

            // Get input from the user and save it to a second variable.
            string widthInput = Console.ReadLine();
            int width = Convert.ToInt32(widthInput);

            // Output - The area of the rectangle is (computed value)
            int area = length * width;
            Console.WriteLine($"The area of the rectangle is " + area);

            Console.ReadLine();
        }
    }
}
