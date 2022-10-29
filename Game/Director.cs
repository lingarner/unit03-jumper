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
        private Puzzle _puzzle = new Puzzle();
        private Jumper _jumper = new Jumper();
        private TerminalService _terminalService = new TerminalService();
        private bool _isPlaying = true;
        private string guess = "";


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
            _terminalService.WriteText(_puzzle.GetHint());
            _terminalService.WriteText(_jumper.getChute());
            guess =  _terminalService.ReadText("Guess a letter [a-z]: ");

        }

        /// <summary>
        /// Keeps watch on where the seeker is moving.
        /// </summary>
        private void DoUpdates()
        {
            _puzzle.CheckGuess(guess);
        }

        /// <summary>
        /// Provides a hint for the seeker to use.
        /// </summary>
        private void DoOutputs()
        {
            // _isPlaying = false;

        }
    }
}