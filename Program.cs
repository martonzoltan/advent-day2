using System;
using System.Linq;

namespace Day2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting gravity module calculation");
            FirstPart();
            //SecondPart();
        }
        private static void FirstPart()
        {
            var input = GetInput();
            int[] inputInt = input.Select(int.Parse).ToArray();
            for(int i= 0; i < inputInt.Length ; i+=4){
                if(inputInt[i] == 99){
                    Console.WriteLine(string.Join(",", inputInt));
                }
                if(inputInt[i] == 1){
                    var val1 = inputInt[i+1];
                    var val2 = inputInt[i+2];
                    var resultPosition = inputInt[i+3];
                    inputInt[resultPosition] = val1 + val2;
                }

                if(inputInt[i] == 2){
                    var val1 = inputInt[i+1];
                    var val2 = inputInt[i+2];
                    var resultPosition = inputInt[i+3];
                    inputInt[resultPosition] = val1 * val2;
                }
            }
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
