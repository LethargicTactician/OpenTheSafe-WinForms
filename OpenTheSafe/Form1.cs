namespace OpenTheSafe
{
    public partial class OpenTheSafe : Form
    {
        List<Label> lblResults = new List<Label>();
        List<PictureBox> pictureBoxes = new List<PictureBox>();
        int answer = 0;
        int answer2 = 0;
        int answer3 = 0;
        int numGuess = 0;
        int numGuess2 = 0;
        int numGuess3 = 0;
        int randMax = 9;
        

        private void StartGame()
        {
            Random random = new Random();
            answer = random.Next(0, randMax + 1);
            answer2 = random.Next(0, randMax + 1);
            answer3 = random.Next(0, randMax + 1);

            answerLbl1.Text = answer.ToString();
            answerlbl2.Text = answer2.ToString();
            answerlbl3.Text = answer3.ToString();
            numlbl1.Enabled = true;
            numlbl2.Enabled = true; 
            numlbl3.Enabled = true;
            btnStart.Text = "Reset";
            


        }

        private void ResetGame()
        {
            numGuess= 0;
            btnStart.Enabled= true;
            numlbl1.Enabled = false;
            numlbl2.Enabled = false;
            numlbl3.Enabled = false;
            

            foreach (Label label in lblResults)
                label.Text = "";
            foreach (PictureBox pic in pictureBoxes)
                pic.Image= null;

        }

        private void InitializeGame()
        {    
       


        }

        public OpenTheSafe()
        {
            InitializeComponent();
        }
      
        private void OpenTheSafe_Load(object sender, EventArgs e)
        {
            InitializeGame();
            ResetGame();
        }

        private void GameWon()
        {
            answerLbl1.Enabled = false;
            answerlbl2.Enabled = false;
            answerlbl3.Enabled = false;

            MessageBox.Show("you win");
            pic1.Image = Properties.Resources.happy;
            pic2.Image = Properties.Resources.happy;
            pic3.Image = Properties.Resources.happy;
        }
        public void GameLost()
        {
            answerLbl1.Enabled = false;
            answerlbl2.Enabled = false;
            answerlbl3.Enabled = false;
            MessageBox.Show("You suck!!!!! The answer was : " + answer + ", lol. loser");
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int intGuess;
            int intGuess2;
            int intGuess3;
            bool correct = true;
            
            if(!int.TryParse(numlbl1.Text, out intGuess))
                {
                    MessageBox.Show("You did not enter a number");
                    return;
                }
            if (!int.TryParse(numlbl2.Text, out intGuess2))
            {
                MessageBox.Show("You did not enter a number");
                return;
            }
            if (!int.TryParse(numlbl3.Text, out intGuess3))
            {
                MessageBox.Show("You did not enter a number");
                return;
            }

            //fist answer
            if (intGuess <= answer-2|| intGuess >= answer+2)
                {
                   //cliking
                    pic1.Image = Properties.Resources.click;
                correct = false;

                }
                else if(intGuess > answer|| intGuess<answer)
                {
                  //change to click
                    pic1.Image = Properties.Resources.click;
                    correct = false;
            }
                else
                {
                    
                    pic1.Image = Properties.Resources.correct_icon;
                    //GameWon();
                }

            //second answer
            if (intGuess2 <= answer2 - 2 || intGuess2 >= answer2 + 2)
            {
             
                pic2.Image = Properties.Resources.click;
                correct = false;

            }
            else if (intGuess2 > answer2 || intGuess2 < answer2)
            {
               
                pic2.Image = Properties.Resources.click;
                correct = false;
            }
            else
            {
              
                pic2.Image = Properties.Resources.correct_icon;
                //GameWon();
            }

            //third answer
            if (intGuess3 <= answer3 - 2 || intGuess3 >= answer3 + 2)
            {
              
                pic3.Image = Properties.Resources.click;
                correct = false;

            }
            else if (intGuess3 > answer3 || intGuess3 < answer3)
            {
               
                pic3.Image = Properties.Resources.click;
                correct = false;
            }
            else
            {
              
                pic3.Image = Properties.Resources.correct_icon;
                //GameWon();
            }
                numGuess++;
            if (correct)
            {
                GameWon();
            }
                if(numGuess == 3)
                {
                    GameLost();
                }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Start")
            {
                StartGame();

            }
            else
            {
                ResetGame();
            }
        }


        private void cheatCheck_CheckedChanged(object sender, EventArgs e)
        {
            // cheatSheet.Visible = false;
            if (cheatCheck.Checked)
            {
                cheatSheet.Visible = true;
            }
            else
            {
                cheatSheet.Visible = false;
            }
        }



        private void numlbl1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numlbl2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numlbl3_TextChanged(object sender, EventArgs e)
        {

        }

        private void cheatSheet_Enter(object sender, EventArgs e)
        {

        }

       
    }
}
