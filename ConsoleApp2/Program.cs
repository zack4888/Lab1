using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            { 

                // Declarations 
                string[] Answers = new string[20];
                string Answer;
                int Count = 1;
                ConsoleKeyInfo KeyPress;
                int CorrectAnswers = 0;
                int EXIT = 0;
                List<int> IncorrectAnswers = new List<int>();
                string[] Thing3 = new string[] { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B", "D", "A" };
                ConsoleKeyInfo StartProgram;

                // intro to the program 
                Console.WriteLine("Welcome to the Drivers test\n");
                Console.WriteLine("Press Enter to begin taking the test");
                StartProgram = Console.ReadKey();
                while (StartProgram.Key != ConsoleKey.Enter)
                {
                    StartProgram = Console.ReadKey();
                }
                Console.Clear();

                //Outputting questions to the user 
                foreach (string i in Thing3)
                {
                    Console.WriteLine("Drivers Test\n");
                    Console.Write("Please enter Your answer to Question {0}: \nA)\nB)\nC)\nD)\n", Count);

                    Answer = Console.ReadLine();
                    while ((Answer.ToUpper() != "A") && (Answer.ToUpper() != "B") && (Answer.ToUpper() != "C") && (Answer.ToUpper() != "D"))
                    {
                        Console.Write("Invalid option, Please enter a value that is between A - D: ");
                        Answer = Console.ReadLine();
                    }
                    Answers[Count - 1] = Answer;
                    if (Answer.ToUpper() == i)
                    {
                        CorrectAnswers = CorrectAnswers + 1;

                    }

                    else
                    {
                        IncorrectAnswers.Add(Count);
                    }

                    Console.Clear();
                    Count = Count + 1;
                }//ending foreach loop
                if (CorrectAnswers >= 15)
                {
                    Console.WriteLine("You passed the test!");
                }
                else
                {
                    Console.WriteLine("You did not pass the test. ");
                }
                Console.WriteLine("You got {0} Answers Correct", CorrectAnswers);
                Console.WriteLine("Incorrect answers:");
                foreach (int i in IncorrectAnswers)
                {
                    Console.WriteLine("# " + i.ToString());
                }
                while (true)
                {
                    Console.WriteLine("To take the test again press the Enter Key, To quit press Escape: ");
                    KeyPress = Console.ReadKey();
                    if (KeyPress.Key == ConsoleKey.Escape)
                    {
                        EXIT = 1;
                        break;
                    }
                    else if (KeyPress.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }// ending while loop 
                if (EXIT == 1)
                {
                    break;
                }


            }// closing outer while loop
        }// ending Main 
    }// Ending class
}// ending namespace 
