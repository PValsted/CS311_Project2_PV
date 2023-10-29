namespace CS311_Project2_PV
{
    public partial class Craps : Form
    {
        int d1, d2, sum, point, rolls = 0;
        double bet, bank = 100.0;

        public Craps()
        {
            InitializeComponent();
        }//end constructor

        /*
         * Generates a random number from 1-6 to simulate a die being rolled.
         *
         */
        public int RandomGen()
        {
            System.Random r = new System.Random();
            return r.Next(1, 7);
        }//end RandomGen

        /*
         * Runs when user wins; displays win message,
         * resets rolls to 0, and adds wager to bank amount.
         * 
         */
        public void win()
        {
            lblResult.Text = "You win!";
            rolls = 0;
            bank = bank + bet;
        }//end win

        /*
         * Runs when user loses; displays lose message,
         * resets rolls to 0, and subtracts wager from bank amount.
         * 
         */
        public void lose()
        {
            lblResult.Text = "You lose!";
            rolls = 0;
            bank = bank - bet;
        }//end lose

        /*
         * Runs when the user rolls the dice. This method is the backbone
         * of the program.
         * 
         */
        public void calculate_score()
        {
            d1 = RandomGen();
            d2 = RandomGen();
            sum = d1 + d2; //assigns random number to each die, adds them up to get score

            lblD1.Text = d1.ToString();
            lblD2.Text = d2.ToString();
            lblSum.Text = sum.ToString(); //assigns values to appropriate visual locations

            rolls++; //increments rolls to differentiate between first and subsequent rolls

            if (rolls == 1) //this switch statement only runs if first roll
            {
                switch (sum) //7 and 11 run the win method & 2, 3, and 12 run the lose method
                {
                    case 7:
                        {
                            win();
                            break;
                        }
                    case 11:
                        {
                            win();
                            break;
                        }
                    case 2:
                        {
                            lose();
                            break;
                        }
                    case 3:
                        {
                            lose();
                            break;
                        }
                    case 12:
                        {
                            lose();
                            break;
                        }
                    default: //otherwise, the sum is stored as the point
                        {
                            point = sum;
                            lblResult.Text = "Point is " + point;
                            break;
                        }


                }
            }
            else //runs after the first roll
            {
                switch (sum) //7 runs the lose method
                {
                    case 7:
                        {
                            lose();
                            break;
                        }
                    default:
                        {
                            if (sum == point) win(); //if the sum equals the point, the win method is run. otherwise, continues to roll
                            break;
                        }
                }
            }

        }//end caculate_score

        /**
         * Executes when roll button is clicked;
         * checks to see if bet doesn't outweigh bank amount,
         * executes calculate_score code
         * 
         */
        private void btnRoll_Click(object sender, EventArgs e)
        {
            bet = double.Parse(txtBet.Text);
            if (bet <= bank)
            {
                calculate_score();
                lblRolls.Text = "Rolls: " + rolls.ToString();
                lblBank.Text = "Balance: " + bank.ToString("C");
            }
            else lblBank.Text = "You can't afford this bet.";
        }//end btnRoll_Click

        /**
         * Executes when reset button is clicked;
         * resets all values to default values
         * 
         */
        private void btnReset_Click(object sender, EventArgs e)
        {
            rolls = 0;
            bank = 100.0;
            lblRolls.Text = "Rolls: " + rolls.ToString();
            lblBank.Text = "Balance: " + bank.ToString("C");
            lblD1.Text = "  ";
            lblD2.Text = "  ";
            lblSum.Text = "Sum";
            lblResult.Text = "";
        }//end btnReset_Click

    }//end form
}//end namespace