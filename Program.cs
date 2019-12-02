using System;

namespace Day2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting fuel calculation module");
            //FirstPart();
            SecondPart();
        }
        private static void FirstPart()
        {
            var modulesInNeetOfCalibrating = GetInput();
        }

        private static void SecondPart()
        {
            
        }

        private static string[] GetInput(){
            var input = System.IO.File.ReadAllLines(@"input.txt");
            return input;
        }
    }
}
