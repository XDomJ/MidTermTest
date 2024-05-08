using System;
namespace ExamQ1
{
    class program
    {
        static void Main(string[] args)
        {
            bool keepAsking = false;

            do
            {
                Console.WriteLine("Eliza is here to listen, what would you like to say?");
                string input = Console.ReadLine();
                Console.WriteLine(CreateElizaResponse(input));

                keepAsking = GetAnotherQuestion();
            } while (keepAsking);


        }
        
        static string CreateElizaResponse (string input)
        {
            string response = "";
            string[] inputArray = input.Split();
            
            for (int i =0; i < inputArray.Length;i++)
            {
                if (inputArray[i].ToLower()  == "my")
                {
                    response += (" Tell me more about your " + inputArray[i+1] + " ");                    
                }else if (inputArray[i].ToLower() == "love" || inputArray[i].ToLower() == "hate")
                {
                    response += " You have strong feelings about that! ";                    
                }
            }
            if (response == "")
            {
                return "Please go on.";
            } else
            return response;
        }

        static bool GetAnotherQuestion()
        {
            Console.WriteLine("Would you like to say more? yes to continue");
            string userChoice = Console.ReadLine();

            if (userChoice.ToLower() == "yes")
                return true;
            else
                return false;
        }
    }

}