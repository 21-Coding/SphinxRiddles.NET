using System;

namespace sphinxApp
{
    class Program
    {
        static void riddleCall(string riddles)
        {
        
          
              Console.WriteLine("Is the " + riddles);
          
          
        }
        static void Main()
        {
            riddleCall("road smooth?");
            string userInput = Console.ReadLine();
            bool riddleAnswer =  bool.Parse(userInput);

            if (riddleAnswer == true)
            {
                riddleCall("sky blue?");
                string userInput0 = Console.ReadLine();
               
            }
             else if (riddleAnswer == true)
            {
                riddleCall("grass green?");
                string userInput1 = Console.ReadLine();
            }
            else if (riddleAnswer == true)
            {
                riddleCall("lemonade yellow?");
                string userInput2 = Console.ReadLine();
            }
           
                
        }
    }
}
