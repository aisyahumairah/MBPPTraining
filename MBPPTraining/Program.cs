using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MBPPTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine("debugging write line");
            Trace.WriteLine("Trace write line");
            Console.ReadLine();
            //Declare and define variables with your favourite book titles
            // IEnumerable
            List<Book> books = new List<Book>();

            Book storyBook1 = new Book("Harry Potter");
            Book storyBook2 = new Book("Twilight");
            books.Add(storyBook1);
            books.Add(storyBook2);
            List<Book> selectedBooks = books.Where(b => b.title.Contains("Harry")).ToList();
            

            Console.WriteLine("disposing storybook");
            storyBook1.Dispose();
            Book.Flip();

            Notebook myNotebook = new Notebook();
            Console.WriteLine("disposing notebook");
            myNotebook.Dispose();

            Console.ReadLine();

            const string bookTitle1 = "Harry Potter";
            const string bookTitle2 = "Twilight";
            const string bookTitle3 = "Fantastic Beasts";
            string[] bookTitles = { "Harry Potter", "Twilight", "Fantastic Beasts", "Pirates of the Caribbean" };
            bookTitles.Concat(new string[] { "abc" }).ToArray();
            Console.WriteLine("first in array: " + bookTitles.First());

            foreach(string title in bookTitles)
            {
                if (title == "Harry Potter")
                {
                    continue;
                }
                Console.WriteLine(title);
                if (title == "Fantastic Beasts")
                {
                    break;
                }
                if (title == "Twilight")
                {
                    return;
                }
            }

            for (int i = 0; i < bookTitles.Length; i++)
            {
                Console.WriteLine(bookTitles[i]);
            }

            int x = 0;
            do
            {
                Console.WriteLine("this is number " + x);
                x++;
            } while(x < bookTitles.Length);

            int y = 0;
            while (x < bookTitles.Length)
            {
                Console.WriteLine("this is no " + y);
                y++;
            }
            
            //Declare and define variables for the cost of the books
            float bookCost1 = 10.42f;
            double bookCost2 = 20.43d;
            float bookCost3 = 33.32f;

            //Declare a variable that will accept any input from the user
            Console.WriteLine(bookTitle1);
            Console.Write(bookTitle2);
            Console.Write(bookTitle3 + "\n");

            //Check if what the user inputs is the title or the price of the books
            while (true)
            {

                string userInput = Console.ReadLine();
                var test = userInput == "" ? "User did not enter anything" : "user has submitted " + userInput;
                Console.WriteLine(test);
                float parsedUserInput;
            

                if (bookTitle1.Contains(userInput))
                {
                    Console.WriteLine("The user input matches part of book title 1");
                }

                if (float.TryParse(userInput, out parsedUserInput))
                {
                    if (parsedUserInput == bookCost1 || parsedUserInput == bookCost2)
                    {
                        Console.WriteLine("This is the cost matches one of the books");
                    }
                    else if (parsedUserInput == bookCost2)
                    {
                        Console.WriteLine("This is the cost for book 2");
                    }
                    else if (parsedUserInput == bookCost3)
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
                    switch (userInput)
                    {
                        case bookTitle1:
                            Console.WriteLine("This is book title 1");
                            break;

                        case bookTitle2:
                            Console.WriteLine("This is book title 2");
                            break;

                        case bookTitle3:
                            Console.WriteLine("This is book title 3");
                            break;

                        default:
                            Console.WriteLine("This doesn't match any books");
                            break;
                    }
                }
            }

            //Prevent auto closure
            //CheckBookTitles(userInput);
            Console.ReadKey();
        }

        static bool CheckBookTitles(string stringToCompare, string bookTitle = "Harry Potter")
        {
            if (stringToCompare == bookTitle)
            {
                return true;
            }
            return false;
        }
    }
}
