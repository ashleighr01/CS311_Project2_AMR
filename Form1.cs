namespace CS311_Project2_AMR
{
    public partial class frmCraps : Form
    {
        private float bet;
        private float balance;

        public frmCraps()
        {
            InitializeComponent();
            
        }

        private GameStatus calculate_score()
        {
            int die1 = new Random().Next(1, 6);
            int die2 = new Random().Next(1, 6);

            bet = float.Parse(txtBet.Text);
            balance = 100;
            //balance = float.Parse(lblBankBalance.Text);
            lblBankBalance.Text = balance.ToString("C");
            float newBalance1 = bet + balance;
            float newBalance2 = balance - bet;

            lblDie1.Text = die1.ToString();
            lblDie2.Text = die2.ToString();

            int sum = die1 + die2;
            
            //GameStatus go = GameStatus.Continue;
            //GameStatus stop = GameStatus.End;

            switch (sum)
            {
                case 2:
                    lblResult.Text = "You lose!";
                    lblBankBalance.Text = newBalance2.ToString("C");
                    return GameStatus.End;                  
                case 3:
                    lblResult.Text = "You lose!";
                    lblBankBalance.Text = newBalance2.ToString("C");
                    return GameStatus.End;
                case 4:
                    lblResult.Text = "Point is " + sum;
                    return GameStatus.Continue;
                case 5:
                    lblResult.Text = "Point is " + sum;
                    return GameStatus.Continue;
                case 6:
                    lblResult.Text = "Point is " + sum;
                    return GameStatus.Continue;
                case 7:
                    lblResult.Text = "You win!";
                    lblBankBalance.Text = newBalance1.ToString("C");
                    return GameStatus.End;
                case 8:
                    lblResult.Text = "Point is " + sum;
                    return GameStatus.Continue;
                case 9:
                    lblResult.Text = "Point is " + sum;
                    return GameStatus.Continue;
                case 10:
                    lblResult.Text = "Point is " + sum;
                    return GameStatus.Continue;
                case 11:
                    lblResult.Text = "You win!";
                    lblBankBalance.Text = newBalance1.ToString("C");
                    return GameStatus.End;
                case 12:
                    lblResult.Text = "You lose!";
                    lblBankBalance.Text = newBalance2.ToString("C");
                    return GameStatus.End;
                }

            }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            if (balance >= bet)
                calculate_score();
            else if (balance < bet)
                MessageBox.Show("You don't have enough money for this bet!");
        }

        public enum GameStatus
        {
            Continue,
            End
        }
    }
}