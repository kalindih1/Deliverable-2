using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool looping = true;

            bool looped = false;

            string input;

            string previousInput = "";

           while (looping)
            {
                if (looped)
                {

                    Console.WriteLine("What else would you like to say? ");

                }
                else
                {

                    Console.WriteLine("What do you wish to say? ");
                    looped = true;
                }
                
                
                

                input = Console.ReadLine().ToLower();

                if (input == previousInput)
                {
                    Console.WriteLine("I'm sorry but you have already said that");
                }


                else if (input == "hello")
                {

                    Console.WriteLine("Hi good to see you ");
                }

                else if (input == "bye")
                {

                    Console.WriteLine("Good bye! ");

                    looping = false;
                }
                else if (input == "sup")
                {
                    Console.WriteLine("I am good ");
                }
                else if (input == "hello there")
                {

                    Console.WriteLine("General Kenobi ");
                }


                previousInput = input;




            }
        }
    }
}
