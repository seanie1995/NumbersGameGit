using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NumbersGame
{
    internal class Program
    {
        
        static int CheckGuess(int randomNumber, int input) // Method returns certain integers that trigger different if-statements in the program. See line 78 for example
        {
           
            if (input == randomNumber)
            {
                return 1;
            }
            else if (input > randomNumber)
            {               
                return -1;
            }        
                          
            else if (input < randomNumber)
            {              
                return 0;
            }        
            return 2;
        }

        static void HowWarmCold(int input, int randomNumber) // Compares user input to a range of numbers to guess how far off or how close the guess is to the target number
        {
            if (input >= randomNumber + 5 || input <= randomNumber -5 )
            {
                Console.WriteLine("Kallt!");
            }
            else if (input >= randomNumber + 3 && input <= randomNumber + 5 || input <= randomNumber - 3 && input >= randomNumber -5)
            {
                Console.WriteLine("Varm!");
            }
            else if (input >= randomNumber + 2 && input <= randomNumber + 3 || input <= randomNumber - 2 && input >= randomNumber -3)
            {
                Console.WriteLine("Jättevarm!");
            }
            else if (input == randomNumber + 1 || input == randomNumber -1)
            {
                Console.WriteLine("Det bränns!");
            }
        }
        static void Main(string[] args)
        {
            Random random = new Random(); 
            int randomNumber;
            string[] positiveOutcome = { "Du har rätt! Grattis!", "Bra jobbat!", "Snyggt! Du gissade rätt" }; // Arrays containing different messages to deliver to user to make program less monotonous
            string[] tooHigh = { "För högt!", "Du siktar för högt!", "Det var förmycket!" };
            string[] tooLow = { "För lågt!", "Du siktar för lågt!.", "Tyvärr, men för lågt!" };
          

            // Number guessing game EASY mode
            while (true)
            {
                Console.WriteLine("Välkommen till spelet! Välj svårighets grad [E]asy, [M]edium eller [H]ard");
                string userInput = Console.ReadLine();

                if (userInput == "E" || userInput == "e")
                {
                    randomNumber = random.Next(0, 10); // Selects random number to be guessed
                    
                    Console.WriteLine("Du har (10) försök att gissa rätt. Talet är mellan 0 och 10");
                    Console.WriteLine("Vilket tal tänker jag på?");
                    for (int i = 0; i < 10; i++) // For loop that iterates a certain number of times depending on difficulty level chosen. In this casee, Easy = 10 attempts
                    {
                        int input = int.Parse(Console.ReadLine());
                        HowWarmCold(input, randomNumber);
                        int methodReturn = CheckGuess(randomNumber, input); // Method returns -1, 0 or 1 depending on user input. -1, 0 and 1 are then conditions for the following if-statements
                        if (methodReturn == -1)
                        {
                            Console.WriteLine(tooHigh[random.Next(0, 2)]); // Console writes out randomly selected string from string arrays on lines 56-58 depending on how high/low user input is.                   
                            Console.WriteLine($"Du har {9 - i} försök kvar");            
                            
                        }
                        else if (methodReturn == 0)
                        {
                            Console.WriteLine(tooLow[random.Next(0, 2)]);
                            Console.WriteLine($"Du har {9 - i} försök kvar");
                        }
                        else if (methodReturn == 1)
                        {
                            Console.WriteLine(positiveOutcome[random.Next(0, 2)]);
                            break;
                        }
                        
                    }
                }

                // Number guessing game MEDIUM mode

                else if (userInput == "M" || userInput == "m")
                {
                    randomNumber = random.Next(0, 15);
                    
                    Console.WriteLine("Du har (8) försök att gissa rätt. Talet är mellan 0 och 15");
                    Console.WriteLine("Vilket tal tänker jag på?");
                    for (int i = 0; i < 8; i++)
                    {
                        int input = int.Parse(Console.ReadLine());
                        HowWarmCold(input, randomNumber);
                        int methodReturn = CheckGuess(randomNumber, input);
                        if (methodReturn == -1)
                        {
                            Console.WriteLine(tooHigh[random.Next(0, 2)]);
                            Console.WriteLine($"Du har {7 - i} försök kvar");
                        }
                        else if (methodReturn == 0)
                        {
                            Console.WriteLine(tooLow[random.Next(0, 2)]);
                            Console.WriteLine($"Du har {7 - i} försök kvar");
                        }
                        else if (methodReturn == 1)
                        {
                            Console.WriteLine(positiveOutcome[random.Next(0, 2)]);
                            break;
                        }
                        
                    }
                }

                // Number guessing game HARD mode

                else if (userInput == "H" || userInput == "h")
                {
                    randomNumber = random.Next(0, 20);
                    
                    Console.WriteLine("Du har (5) försök att gissa rätt. Talet är mellan 0 och 20");
                    Console.WriteLine("Vilket tal tänker jag på?");
                    for (int i = 0; i < 5; i++)
                    {
                        int input = int.Parse(Console.ReadLine());
                        HowWarmCold(input, randomNumber);
                        int methodReturn = CheckGuess(randomNumber, input);
                        if (methodReturn == -1)
                        {
                            Console.WriteLine(tooHigh[random.Next(0, 2)]);
                            Console.WriteLine($"Du har {4 - i} försök kvar");
                        }
                        else if (methodReturn == 0)
                        {
                            Console.WriteLine(tooLow[random.Next(0, 2)]);
                            Console.WriteLine($"Du har {4 - i} försök kvar");
                        }
                        else if (methodReturn == 1)
                        {
                            Console.WriteLine(positiveOutcome[random.Next(0, 2)]);
                            break;
                        }
                        
                    }
                }

                Console.WriteLine("Vill du starta om spelet? J/N:");
                userInput = Console.ReadLine();
                 if (userInput == "N" || userInput == "n")
                {
                    Console.WriteLine("Bye bye");
                    break;
                }               
                 else if (userInput == "J" || userInput == "n")
                {

                }
                else
                {
                    Console.WriteLine("Mata in ett giltigt svar"); 
                }
            }
            Console.ReadKey();
            

        }
    } 
}
