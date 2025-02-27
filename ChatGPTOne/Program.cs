using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {

              while(true)
            {
            string question, answer;

            Console.Write("Place your question? ");
            question = Console.ReadLine();

             switch (question)
            {
           
                case "Who's your creator?":
                    answer = "I am my own creator";
                    break;
                case "What's your name":
                    answer = "Chat, also known as students best friend";
                    break;
                case "Do you have a girlfriend?":
                    answer = "Yes, she's called Alexa!";
                    break;
                case "Do you like to help?":
                    answer = "It would be better if i got payed";
                    break;
                case "EXIT":
                    return; 
                default:
                    answer = "You must teach me those skills";
                    break;
            }

            Console.WriteLine(answer);
            }
        }
    }
}
