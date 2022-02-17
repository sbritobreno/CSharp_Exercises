using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__week3
{
    //    3. Create a game like Hangman in which a player guesses letters to try to replicate a hidden
    //word.Store at least eight words in an array, and randomly select one to be the hidden word.
    //Initially, display the hidden word using asterisks to represent each letter.Allow the user to
    //guess letters to replace the asterisks in the hidden word until the user completes the entire
    //word. If the user guesses a letter that is not in the hidden word, display an appropriate
    //message. If the user guesses a letter that appears multiple times in the hidden word, make
    //sure that each correct letter is placed.
    public class Exercise3
    {
        public static void Exer3()
        {
            Console.WriteLine("\nExercise 3\n");

            string[] words = new string[] { "Programming", "Database", "Networking", "Linux", "DevOps" };

            Random r = new Random();

            var word = words[r.Next(5)].ToLower();
            var wordLength = word.Length;
            var wordArray = word.ToCharArray();

            Console.WriteLine($"\nTry to guess what is the word :) You can only miss 5 letters \nHint: It is related to IT \nThe word has {wordLength} letters");

            string[] guessingWord = new string[wordLength];
            for (int i = 0; i < wordLength; i++)
                guessingWord[i] = "_ ";

            foreach(var l in guessingWord)
            {
                Console.Write(l);
            }
            
            var maxMissiedLetters = 5;

            while(maxMissiedLetters > 0)
            {
            Console.WriteLine("\nGuess a letter: ");

            var input = Console.ReadLine().ToLower();

                if (word.Equals(input))
                {
                    Console.WriteLine("\nYou got it...");
                    break;
                }
                if(Convert.ToString(input) == "" || Convert.ToString(input).Length > 1)
                {
                    Console.WriteLine("Try entering a single letter!");
                    continue;
                }
                else if (!wordArray.Contains(Convert.ToChar(input)))
                {
                    maxMissiedLetters--;
                    if (maxMissiedLetters == 0)
                    {
                        Console.WriteLine("You ran out of tries...");
                        break;
                    }
                    Console.WriteLine("You have " + maxMissiedLetters + " missing words left");
                }
                else {

                    for (int i = 0; i < wordLength; i++)
                    {                    
                        if (wordArray[i] == Convert.ToChar(input))
                        {
                            guessingWord[i] = Convert.ToString(input);                           
                        }                      
                    }
                    foreach (var l in guessingWord)
                    {
                        Console.Write(l);
                    }

                    if (!guessingWord.Contains("_ "))
                    {
                        Console.WriteLine("\nYou got it...");
                        break;
                    }
                }             
            }
        }
    }
}
