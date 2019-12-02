using System;
using System.Linq;

namespace Day2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting gravity module calculation");
            //FirstPart();
            SecondPart();
        }
        private static int FirstPart(int[] inputInt, int noun, int verb)
        {
            inputInt[1] = noun;
            inputInt[2] = verb;
            for(int i= 0; i < inputInt.Length ; i+=4){
                var a = inputInt[i];
                if(inputInt[i] == 99){
                    return inputInt[0];
                }
                if(inputInt[i] == 1){
                    var val1 = inputInt[inputInt[i+1]];
                    var val2 = inputInt[inputInt[i+2]];
                    var resultPosition = inputInt[i+3];
                    inputInt[resultPosition] = val1 + val2;
                    //Console.WriteLine(string.Join(",", inputInt));
                }

                if(inputInt[i] == 2){
                    var val1 = inputInt[inputInt[i+1]];
                    var val2 = inputInt[inputInt[i+2]];
                    var resultPosition = inputInt[i+3];
                    inputInt[resultPosition] = val1 * val2;
                    //Console.WriteLine(string.Join(",", inputInt));
                }
            }
            return 0;
        }

        private static void SecondPart()
        {
            for(int noun = 1; noun < 99 ; noun++){
                for(int verb = 1; verb < 99 ; verb++){
                     var input = GetInput();
                    int[] inputInt = input.Select(int.Parse).ToArray();
                    var result = FirstPart(inputInt,noun,verb);
                    //Console.WriteLine(result);
                    if(result == 19690720){
                        Console.WriteLine("noun:" + noun);
                        Console.WriteLine("verb:" + verb);

                        break;
                    }
                }
            }
        }

        private static string[] GetInput(){
            var input = System.IO.File.ReadAllLines(@"input.txt");
            return input;
        }
    }
}
