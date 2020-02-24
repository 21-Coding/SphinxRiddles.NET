using System;
using System.Collections.Generic;

namespace sphinxApp
{
    public class Riddle 
    {
        public string Question;
        public string Answer;
    }
    class Program
    {


        static void Main()
        {  
            Riddle question1 = new Riddle();
            question1.Question = "How many chucks could a woodchuck chuck if a woodchuck could chuck wood?";
            question1.Answer = "200";

            Riddle question2 = new Riddle();
            question2.Question = "If a duck could pull a truck, it would weigh how much?";
            question2.Answer = "10lbs";

            Riddle question3 = new Riddle();
            question3.Question = "How many licks does it take to get too the tootsie roll center of a tootsie pop?";
            question3.Answer = "1";
            
            List<Riddle> Riddles = new List<Riddle>() { question1, question2, question3 };

                foreach(Riddle quest in Riddles) 
                {
                    Console.WriteLine(quest.Question);
                    string userInput = Console.ReadLine();
                AskDiferentQuestion();
                }
            

                void AskDiferentQuestion()
                {
                      


                    Random rnd = new Random();
                    int intRiddle = rnd.Next(1);

                    Console.WriteLine(Riddles[intRiddle].Question);
                    string userInput = Console.ReadLine();
                    if( userInput.Contains(Riddles[intRiddle].Answer))
                    {
                        Console.WriteLine("You are past the first round!");
                    }
                     else if (userInput.Contains(Riddles[intRiddle].Answer))
                        {

                        Console.WriteLine("Sorry! You are not past the first round!");

                        }
                }
        }
    }
}