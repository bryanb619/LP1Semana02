using System;
using System.Net;

namespace ChatGPTOne
{
    class Program
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {

            string input = "", response; 
    
        

           while(input != "EXIT")

           {
        
                Console.Write
                ("Hi I am a very smart ai, please ask me things!: "); 

                input = Console.ReadLine(); 
                

                switch(input)
                {
                    case "are you amazing?":
                    {   
                        response = "extremely";
                        break; 
                    }

                    case "is earth round or square?":
                    {   
                        response = "Round...";
                        break; 
                    }
                    case "do you like ai?":
                    {   
                        response = "Yes I'm one";
                        break; 
                    }
                    case "do you like c#?":
                    {   
                        response = "No, I like Python 3.6.1";
                        break; 
                    }
                    case "EXIT":
                    {
                        response = "EXITING";
                        break;
    
            
                    }
                    default:
                    {
                        response = "I could not understand,\nplease try again!";
                        break; 
                    }

               
                }

                Console.WriteLine(response); 
           }
        }
    }
}
