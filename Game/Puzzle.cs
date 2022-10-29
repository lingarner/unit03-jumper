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
        private List<string> _guesses = new List<string>();

        private string _correct = "";
        

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
        public string GetHint()
        {
            string puz = "_ _ _ _ _";
            return puz;
        }

        /// <summary>
        /// Checks whether or not the guessed letter is the word.
        /// </summary>
        public void CheckGuess(string guess)
        {
            _guesses.Add(guess);
            foreach (string letter in _guesses)
            {
                if (_hint.Contains(guess))
                {
                    char g = char.Parse(guess);
                    _hint = _hint.Replace('_', g);
                }
                else
                {
                    break;
                }
            }


        }

    }
}