namespace unit03_jumper
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
        }
 
        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Gets the guesses of a user.
        /// </summary>
        private void GetInputs()
        {
         
            
        }

        /// <summary>
        /// Keeps watch on where the seeker is moving.
        /// </summary>
        private void DoUpdates()
        {
           
        }

        /// <summary>
        /// Provides a hint for the seeker to use.
        /// </summary>
        private void DoOutputs()
        {
           
            
        }
    }
}