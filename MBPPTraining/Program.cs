using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBPPTraining
{
    class Program
    {
        static void Main(string[] args)
        {

            //declare and define variables your favourite books title
            const string bookTitle1 = "Harry Potter";
            const string bookTitle2 = "Twighlight ";
            const string bookTitle3 = "Fantastic Beasts";

            //declare and define variables for the costs of the book
            float bookCost1 = 10.42f; //float
            double bookCost2 = 20.43d; //double
            float bookCost3 = 30.56f; //decimal = 30.56m

            Console.WriteLine(bookTitle1);
            Console.Write(bookTitle2);
            Console.Write(bookTitle3 + "\n");

            string userInput = Console.ReadLine();

            var test = userInput == "" ? "User did not enter anything" : "User has submitted: " + userInput;

            Console.WriteLine(test);

            float parsedUserInput;
            if (float.TryParse(userInput, out parsedUserInput))
            {
                if(parsedUserInput == bookCost1)
                {
                    Console.WriteLine("This is the cost for book 1");
                }
                else if(parsedUserInput == bookCost2)
                {
                    Console.WriteLine("This is the cost for book 2 ");
                }
                else if(parsedUserInput == bookCost3)
                {
                    Console.WriteLine("This is the cost for book 3");
                }
                else
                {
                    Console.WriteLine("This cost doesn't match any books");
                }
            }
            else
            {
                switch(userInput)
                {
                    case bookTitle1:
                        Console.WriteLine("This is the book title 1");
                        break;

                    case bookTitle2:
                        Console.WriteLine("This is the book title 2");
                        break;

                    case bookTitle3:
                        Console.WriteLine("This is the book title 3");
                        break;

                    default:
                        Console.WriteLine("This doesn't match any books");
                        break;
                }
            }

            static bool CheckBookTitles(string stringToCompare, string bookTitle);
            {

            }

            Console.ReadKey(); //press any key, dia akan stop execute 
        }
    }
}
