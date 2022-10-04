namespace Janken
{
    public partial class Form1 : Form
    {
        private string playerChoice;
        private string computerChoice;
        private string[] Options = { "R", "P", "S", "P", "S", "R"};
        private Random random = new Random();
        private int computerScore;
        private int playerScore;
        private string? draw;

        public Form1()
        {
            InitializeComponent();
        }

        private void MakeChoiceEvent(object sender, EventArgs e)
        {
            Button tempButton = sender as Button;

            playerChoice = (string)tempButton.Tag;

            int i = random.Next(0, Options.Length);
            computerChoice = Options[i];

            lblPlayerChoice.Text = "Player is: " + UpdateTextAndImage(playerChoice, PLAYER_PIC);
            lblCPUChoice.Text = "Computer is: " + UpdateTextAndImage(computerChoice, CPU_PIC);
            CheckGame();
        }

        private string UpdateTextAndImage(string text, PictureBox pic) 
        {
            string? word = null;

            switch (text) 
            {
                case "R":
                    word = "Rock";
                    pic.Image = Properties.Resources.ROCK;
                    break;
                case "P":
                    word = "Paper";
                    pic.Image = Properties.Resources.PAPER;
                    break;
                case "S":
                    word = "Scissors";
                    pic.Image = Properties.Resources.SCISSORS;
                    break;
                default:
                    word = "";
                    break;
            }

            return word;
        }

        private void CheckGame() 
        {
            if (playerChoice == computerChoice)
                draw = " Draw! ";
            else 
            {
                bool computerWin =
                playerChoice == "R" && computerChoice == "P" ||
                playerChoice == "S" && computerChoice == "R" ||
                playerChoice == "P" && computerChoice == "S";

                bool playerWin =
                    playerChoice == "R" && computerChoice == "S" ||
                    playerChoice == "S" && computerChoice == "P" ||
                    playerChoice == "P" && computerChoice == "R";

                draw = null;

                computerScore += computerWin ? 1 : 0;
                playerScore += playerWin ? 1 : 0;
            }

            lblCPUResult.Text = "Computer Score: " + computerScore + Environment.NewLine + draw;
            lblPlayerResult.Text = "Player Score: " + playerScore + Environment.NewLine + draw;
        }
    }
}