using System;
using System.Collections.Generic;

namespace HangmanDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Handelsakademin";
            bool winner = false;
            bool correctGuess = false;
            int maxGuesses = 5;
            int incorrectGuess = 0;
            int correctLetters = 0;
            int wordLength = word.Length;
            List<char> printWord = new List<char>();

            foreach (char c in word)
            {
                printWord.Add('_');
            }

            Console.WriteLine("The word is: ");
            foreach (char c in printWord)
            {
                Console.Write("{0} ", c);
            }
            Console.WriteLine();
            while (!winner && incorrectGuess<maxGuesses)
            {
                correctGuess = false;
                Console.Write("Guess a letter: ");
                char g = Convert.ToChar(Console.ReadLine());

                for (int i = 0; i<word.Length; i++)
                {
                    if(word[i] == g)
                    {
                        correctGuess = true;
                        correctLetters++;
                        printWord[i] = g;
                        if(correctLetters == wordLength)
                        {
                            winner = true;
                            break;
                        }
                    }
                    Console.Write("{0} ", printWord[i]);
                }
                Console.WriteLine();
                if (!correctGuess)
                {
                    incorrectGuess++;
                }
            }
            if (winner)
            {
                Console.WriteLine("Correct! The word was: {0}", word);
                Console.WriteLine("You had {0} incorrect guesses.",incorrectGuess);
            }
            if (!winner)
            {
                Console.WriteLine("Sorry, you lost! The word was: {0}",word);
                Console.WriteLine("You got {0}/{1} letters correct.",correctLetters, wordLength);
            }
        }
    }
}
