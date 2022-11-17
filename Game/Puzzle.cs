using System;
using System.Collections.Generic;


namespace unit03_jumper
{
    /// <summary>
    /// The word that the user needs to figure out to win the game.
    /// </summary>
    public class Puzzle
    {
        private string _hint = "apple";

        private List<string> _hintLetters = new List<string> { "a", "p", "p", "l", "e" };
        private List<string> _guesses = new List<string>();

        private List<string> _hintLines = new List<string> { "_ ", "_ ", "_ ", "_ ", "_ " };




        /// <summary>
        /// Constructs a new instance of a Puzzle. 
        /// </summary>
        public Puzzle()
        {

        }

        /// <summary>
        /// Provides a hint for the user.
        /// </summary>
        /// <returns>The amount of letters in the word the user needs to guess</returns>
       
        public void GetHint()
        {
        
            foreach (string line in _hintLines)
            {
                Console.Write(line);
            }

            Console.WriteLine(" ");           
        }

        public void UpdateHint(bool CheckedGuess, string UserGuess)
        {

            if (CheckedGuess == true)
            {
                
                    if (UserGuess == _hintLetters[0])
                    {
                        _hintLines[0] = UserGuess;

                    }
                    else if (UserGuess == _hintLetters[1] && UserGuess == _hintLetters[2])
                    {
                        _hintLines[1] = UserGuess;
                        _hintLines[2] = UserGuess;

                    }
                    else if (UserGuess == _hintLetters[3])
                    {
                        _hintLines[3] = UserGuess;

                    }
                    else if (UserGuess == _hintLetters[4])
                    {
                        _hintLines[4] = UserGuess;

                    }
 
            }
        }

        
        /// <summary>
        /// Checks whether or not the guessed letter is the hidden word.
        /// </summary>
        public bool CheckGuess(string guess)
        {
            _guesses.Add(guess);
            foreach (string letter in _guesses)
            {
                if (_hint.Contains(guess))
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }

            return false;
        }


        public bool PuzzleCompleted()
        {
            if(_hintLines.Contains("_ "))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}