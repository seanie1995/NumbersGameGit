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
        //Adding random intro
        static int CheckGuess(int randomNumber, int input)
        {
           // Too high statemnts

            if (input == randomNumber)
            {
                return 1;
            }
            else if (input > randomNumber)
            {               
                return -1;
            }        
           
            // Too low statements
            
            else if (input < randomNumber)
            {
                
                return 0;
            }
            
            return 2;
        }

        static void HowWarmCold(int input, int randomNumber)
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
            string[] positiveOutcome = { "Du har rätt! Grattis!", "Bra jobbat!", "Snyggt! Du gissade rätt" };
            string[] tooHigh = { "För högt!", "Du siktar för högt!", "Det var förmycket!" };
            string[] tooLow = { "För lågt!", "Du siktar för lågt!.", "Tyvärr, men för lågt!" };
            bool loop = true;

            // Number guessing game EASY mode

            while (loop == true)
            {
                Console.WriteLine("Välkommen till spelet! Välj svårighets grad [E]asy, [M]edium eller [H]ard");
                string userInput = Console.ReadLine();

                if (userInput == "E" || userInput == "e")
                {
                    randomNumber = random.Next(0, 10);
                    
                    Console.WriteLine("Du har (10) försök att gissa rätt. Talet är mellan 0 och 10");
                    Console.WriteLine("Vilket tal tänker jag på?");
                    for (int i = 0; i < 10; i++)
                    {
                        int input = int.Parse(Console.ReadLine());
                        HowWarmCold(input, randomNumber);
                        int methodReturn = CheckGuess(randomNumber, input);
                        if (methodReturn == -1)
                        {
                            Console.WriteLine(tooHigh[random.Next(0, 2)]);                           
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

                Console.WriteLine("Vill du starta om spelet? Y/N:");
                userInput = Console.ReadLine();
                 if (userInput == "N" || userInput == "n")
                {
                    Console.WriteLine("Bye bye");
                    loop = false;
                }               
                 else if (userInput == "Y" || userInput == "y")
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
