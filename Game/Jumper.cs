using System;
using System.Collections.Generic;


namespace unit03_jumper
{
    /// <summary>
    /// <para>The parachute</para>
    /// <para>
    /// The responsibility of a Jumper is to keep track of the
    /// parachute.
    /// </para>
    /// </summary>
    
    public class Jumper
    {
        private string Chute =
           @" ____" + "\n"
        + @"/    \" + "\n"
        + @"\____/" + "\n"
        + @" \  /" + "\n"
        + @"   O " + "\n"
        + @"  -|- " + "\n"
        + @"  / \ " + "\n";

        public int WrongGuessCount = 0;

        private List<string> JumperList = new List<string>();
        


        /// <summary>
        /// Constructs a new instance of Jumper.
        /// </summary>
        public Jumper()
        {     

        }

        /// <summary>
        /// Creates the Parachute
        /// </summary>
        /// <returns>The an image of a parachute.</returns>
        public string GetChute()
        {
            return Chute;
        }

        /// <summary>
        /// Determines whether or not the Jumper is dead.
        /// </summary>
        /// <returns>
        /// True or False depending on if the Jumper is dead.
        /// </returns>
        public bool IsDead()
        {
            if(WrongGuessCount >= 5)
            {
                return true;
            }
            else
            {
                return false;

            }
        }


        /// <summary>
        /// Deletes lines off the parachute.
        /// </summary>
        public string CutLine(int WrongGuesses)
        {
            
            if(WrongGuesses == 1){
               Chute =  @"/    \" + "\n"
                        + @"\____/" + "\n"
                        + @" \  /" + "\n"
                        + @"   O " + "\n"
                        + @"  -|- " + "\n"
                        + @"  / \ " + "\n";
            }
            else if(WrongGuesses == 2){
                 Chute =  @"\____/" + "\n"
                        + @" \  /" + "\n"
                        + @"   O " + "\n"
                        + @"  -|- " + "\n"
                        + @"  / \ " + "\n";
            }
            else if(WrongGuesses == 3){
                 Chute =  @" \  /" + "\n"
                        + @"   O " + "\n"
                        + @"  -|- " + "\n"
                        + @"  / \ " + "\n";
            }
            else if(WrongGuesses == 4){
                 Chute =  @"   O " + "\n"
                        + @"  -|- " + "\n"
                        + @"  / \ " + "\n";
            }
            else if(WrongGuesses == 5){
                 Chute =  @"   X " + "\n"
                        + @"  -|- " + "\n"
                        + @"  / \ " + "\n";
            }

            return Chute;
        }
    } 

    
}