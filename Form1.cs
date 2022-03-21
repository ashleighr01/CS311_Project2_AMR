namespace CS311_Project2_AMR
{
    public partial class frmCraps : Form
    {
        private float bet;
        private float balance = 100;
        private bool firstRoll = true;

        /**
         * Enumeration used to track the status of the game.
         * Continue means the game is continuing while end means
         * the game has been completed.
         */
        public enum GameStatus
        {
            Continue,
            End
        }
        public frmCraps()
        {
            InitializeComponent();

        }

        /**
         * Method used to calculate the score of the roll,
         * print results of rolls, and move money (balances and bets),
         * 
         */
        private void calculate_score()
        {
            int die1 = new Random().Next(1, 7);
            int die2 = new Random().Next(1, 7);


            bet = float.Parse(txtBet.Text);
            float newBalance1 = bet + balance;
            float newBalance2 = balance - bet;

            lblDie1.Text = die1.ToString();
            lblDie2.Text = die2.ToString();


            int sum = die1 + die2;
            int sum2 = 0;
           

            GameStatus status = new GameStatus();

            /**
             * If statement to ensure the roller is on their first roll that way
             * proper rules are applied. Within the statement, craps rules are 
             * applied for the first roll. (7 & 11 win while 2, 3, & 12 lose)
             */
            if (firstRoll)
            {
                switch (sum)
                {
                    case 2:
                    case 3:
                    case 12:
                        status = GameStatus.End;
                        break;
                    case 7:
                        status = GameStatus.End;
                        break;
                    case 11:
                        status = GameStatus.End;
                        break;
                    default:
                        status = GameStatus.Continue;
                        break;
                } //end switch

                if (sum == 7 || sum == 11)
                {
                    lblBankBalance.Text = newBalance1.ToString("C");
                    lblResult.Text = "You win!";
                }
                else if (sum == 2 || sum == 3 || sum == 12)
                {
                    lblBankBalance.Text = newBalance2.ToString("C");
                    lblResult.Text = "You lose!";
                }
                else
                {
                    lblResult.Text = "Your point is " + sum + ".\nRoll Again!";
                    sum2 = sum;
                } //end if-else if- else statement
                
            } //end first roll if statement
            
            
            /**
             * While loop used to decipher the rolls for any rolls after the first.
             * (7 is a loss, roll the same number as your first roll is a win,
             * any other number is just point)
             */
            while (!firstRoll && status == GameStatus.Continue)
            {
                sum2 = die1 + die2;
                if (sum == 7)
                {
                    lblResult.Text = "You lose!";
                    lblBankBalance.Text = newBalance2.ToString("C");
                } 
                else if (sum == sum2)
                {
                    lblResult.Text = "You win!";
                    lblBankBalance.Text = newBalance1.ToString("C");
                }
                else
                {
                    lblResult.Text = "Your point is " + sum;
                } //end if-else if-else statement
                 
            } //end while loop
            
        } //end calculate_score

        /**
         * Method for when the user clicks the roll
         * button. Ensures the user has enough money to bet.
         */
        private void btnRoll_Click(object sender, EventArgs e)
        {
            GameStatus status = new GameStatus();

                if (balance >= bet && status == GameStatus.Continue)
                {
                    calculate_score();
                    firstRoll = false;
                }           
                else if (balance < bet || status == GameStatus.End)
                    MessageBox.Show("This bet is invalid!");
        } //end btnRoll_Click


    } //end frmCraps
} //end namespace