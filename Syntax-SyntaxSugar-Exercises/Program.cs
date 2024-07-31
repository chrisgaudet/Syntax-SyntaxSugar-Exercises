using System.Threading.Channels;

namespace Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            int trueAnswer = 4;
            Console.WriteLine($"What is your answer to the problem?");

            var response = Console.ReadLine();

            bool isParsable = int.TryParse(response, out trueAnswer);

            if (trueAnswer < 9)
            {
                Console.WriteLine("trueAnswer is less than nine.");
            }
            else
            {
                Console.WriteLine("Please try a different answer.");
            }

            var response2 = (trueAnswer < 9) ? $"{trueAnswer} is less than nine." : $"{trueAnswer} is more than nine";
            Console.WriteLine(response2);
        }
    }


}           
        
    

