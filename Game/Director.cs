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

        public int WrongGuessCount = 0;

        public bool _firsTime = true;


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
            if (_isPlaying == false)
            {
                _puzzle.GetHint();
                _terminalService.WriteText(_jumper.GetChute());

            }
            else if (_isPlaying == true)
            {
                _puzzle.GetHint();
                _terminalService.WriteText(_jumper.GetChute());
                guess =  _terminalService.ReadText("Guess a letter [a-z]: ");
            }

        }

        /// <summary>
        /// Updates the Jumper to display the result of a user's correct or incorrect guess. 
        /// </summary>
        private void DoUpdates()
        {
            bool _checkComplete =_puzzle.CheckGuess(guess);

            if(_checkComplete == false)
            {
                _jumper.WrongGuessCount += 1;
            }
            else
            {
                _jumper.WrongGuessCount += 0;
            }

            _jumper.CutLine(_jumper.WrongGuessCount);
            _puzzle.UpdateHint(_checkComplete, guess);


        }

        /// <summary>
        /// Provides a hint for the seeker to use.
        /// </summary>
        private void DoOutputs()
        {
            bool dead = _jumper.IsDead();
            bool finishedPuzzle = _puzzle.PuzzleCompleted();
            
            if(finishedPuzzle == true || dead == true)
            {
                 _puzzle.GetHint();
                _terminalService.WriteText(_jumper.GetChute());
                _terminalService.WriteText("you're done.");
                _isPlaying = false;
            }
        }
    }
}