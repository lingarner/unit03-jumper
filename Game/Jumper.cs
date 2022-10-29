using System;


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
        + @"   0 " + "\n"
        + @"  -|- " + "\n"
        + @"  / \ " + "\n";

        /// <summary>
        /// Constructs a new instance of Jumper.
        /// </summary>
        public Jumper()
        {


        }

        /// <summary>
        /// Deletes lines off the parachute.
        /// </summary>
        public void CutLine()
        {

        }

        /// <summary>
        /// Creates the Parachute
        /// </summary>
        /// <returns>The an image of a parachute.</returns>
        public string getChute()
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
            return true;
        }
    } 

    
}