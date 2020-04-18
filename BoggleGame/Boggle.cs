using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace BoggleGame
{
    /// <summary>
    /// A GUI for a simple Boggle game
    /// </summary>
    public partial class Boggle : Form
    {
        /// <summary>
        /// Holds the number of minutes for the timer
        /// </summary>
        private int _minutes = 3;

        /// <summary>
        /// Holds the number of seconds for the time
        /// </summary>
        private int _seconds = 0;

        /// <summary>
        /// Generates the dice for the boggle game board
        /// probably should have implemented a different way, but I know this way allows
        /// for the dice to be reused and for the dice to be only used once per round
        /// </summary>
        List<string> diceList = new List<string>();

        /// <summary>
        /// "Little Boggle" dice 
        /// </summary>
        string[] littleBoggle = new string[16]{ "AAEEGN", "ABBJOO", "ACHOPS", "AFFKPS",
                                             "AOOTTW", "CIMOTU", "DEILRX", "DELRVY", 
                                             "DISTTY", "EEGHNW", "EEINSU", "EHRTVW", 
                                             "EIOSST", "ELRTTY", "HIMNQU", "HLNNRZ"};

        /// <summary>
        /// "Big Boggle" dice 
        /// </summary>
        string[] bigBoggle = new string[] { "AAAFRS", "AAEEEE", "AAFIRS", "ADENNN", "AEEEEM", 
                                            "AEEGMU" , "AEGMNN" , "AFIRSY" , "BJKQXZ" , "CCNSTW",
                                            "CEIILT" , "CEILPT" , "CEIPST" , "DHHNOT" , "DHHLOR", 
                                            "DHLNOR" , "DDLNOR" , "EIIITT" , "EMOTTT" , "ENSSSU", 
                                            "FIPRSY" , "GORRVW" , "HIPRRY" , "NOOTUW" , "OOOTTU"};
        /// <summary>
        /// Allows the size of the board to be changed from a 4x4 to a 5x5
        /// </summary>
        int SIZE_OF_BOARD;

        /// <summary>
        /// Initialization of the GUI
        /// </summary>
        public Boggle()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Handles the Click Event for the Play Little Boggle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxStart_Click(object sender, EventArgs e)
        {
            uxMinLabel.Text = "3";
            uxSecLabel.Text = "00";
            _minutes = 3;
            _seconds = 0;
            Button button = (Button)sender;
            if (button.Text.Equals("Play Little Boggle"))
            {
                getDice(littleBoggle); //adds all the dice to the list each time to make sure they have only been used once
                SIZE_OF_BOARD = 4;// 4x4 board
            }
            else
            {
                getDice(bigBoggle); //adds all the dice to the list each time to make sure they have only been used once
                SIZE_OF_BOARD = 5;// 5x5 board
            }
            makeBoard();//uxDisplay is the large textbox in case there is any confusion
            
            uxMinLabel.ForeColor = Color.Black;
            uxSecLabel.ForeColor = Color.Black;
            uxColonLabel.ForeColor = Color.Black;
            uxCountDownTimer.Start();//starts the timer
        }

        /// <summary>
        /// Handles the Timer with 1000ms interval and allows for the count
        /// down to be visibly displayed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCountDownTimer_Tick(object sender, EventArgs e)
        {
            _seconds--;//decrement seconds on each pass of the timer interval
            if(_seconds == -1)
            {//allows for seconds to countdown properly and update the minutes
             //once seconds runout
                _minutes--;
                _seconds = 59;
            }
            //converting to a string to update the labels
            string minutes = _minutes.ToString();
            string seconds = _seconds.ToString();

            if(seconds.Length == 1)
            {//handles formating so that once seconds are no longer 
             //double digits there is a leading zero displayed
                string temp = "0" + seconds;
                seconds = temp;
            }
            
            if(_minutes == 0 && _seconds <= 10)
            {
                uxMinLabel.ForeColor = Color.Red;
                uxColonLabel.ForeColor = Color.Red;
                uxSecLabel.ForeColor = Color.Red;
            }
            else
            {
                uxMinLabel.ForeColor = Color.Black;
                uxSecLabel.ForeColor = Color.Black;
                uxColonLabel.ForeColor = Color.Black;
            }
            //Updating the labels
            uxMinLabel.Text = minutes;
            uxSecLabel.Text = seconds;
            if (_minutes == 0 && _seconds == 0)
            {//If the timer is done, stop and play alarm sounds and display a message
                uxCountDownTimer.Stop();
                //Like covering the board with the shield when the timer is done
                string temp = uxDisplay.Text;
                uxDisplay.Text = "";
                MessageBox.Show("Times Up!\nPut Down What You Are Writing With!");
                //"Uncovering the board so everyone can see how we came up with different words
                uxDisplay.Text = temp;
            }
            else if(_minutes == 0 && _seconds == 1)
            {//used else if bc there is about a 1 sec delay for the sound to play
                playSound();
            }
        }

        /// <summary>
        /// Handles the Click Event for the Reset Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxReset_Click(object sender, EventArgs e)
        {
            //resets the game to a new start time and stops the timer
            uxMinLabel.ForeColor = Color.Black;
            uxSecLabel.ForeColor = Color.Black;
            uxColonLabel.ForeColor = Color.Black;
            _minutes = 3;
            _seconds = 0;
            uxMinLabel.Text = "3";
            uxSecLabel.Text = "00";
            uxCountDownTimer.Stop();
        }

        /// <summary>
        /// Plays a sound to notify players that the game is over
        /// </summary>
        private void playSound()
        {//C:\Users\slkra\OneDrive\Desktop\VirtualGames\media.io_endSound.wav
            SoundPlayer endAlert = new SoundPlayer(@"C:\Users\slkra\OneDrive\Desktop\VirtualGames\Boggle\soundFiles\warning_horn.wav");
            endAlert.Play();
        }

        /// <summary>
        /// Generates the Boggle board and displays it
        /// </summary>
        private void makeBoard()
        {
            StringBuilder sb = new StringBuilder("\r\n");
            Random r = new Random();
            for(int row = 0; row < SIZE_OF_BOARD; row++)
            {
                sb.Append("   ");
                for (int col = 0; col < SIZE_OF_BOARD; col++)
                {
                    int index = r.Next(diceList.Count);
                    string lettersOnDie = diceList[index];
                    diceList.RemoveAt(index);//removes the die that has been used so it can't be used again
                    char c = lettersOnDie[r.Next(lettersOnDie.Length)];
                  
                    if(c == 'I')
                    {
                            sb.Append(" ");
                            sb.Append(c.ToString());
                    }
                    else if(c == 'Q')
                    {//adds a u to go with Q (I saw it I assume on some newer boggle game boards)
                        string temp = c.ToString() + "u";  
                        sb.Append(temp.PadRight(10)); 
                    }
                    else
                    {
                        sb.Append(c.ToString());
                    }
                    
                    if (col < SIZE_OF_BOARD - 1)
                    {
                        sb.Append("\t");
                    }
                    
                    
                }
                /*
                if(row < (SIZE_OF_BOARD - 1))
                {
                    sb.Append("\r\n");
                }
                */
               if(row < (SIZE_OF_BOARD - 1) && SIZE_OF_BOARD == 4)
                {
                    sb.Append("\r\n\r\n\r\n");
                }
                else if (row < (SIZE_OF_BOARD - 1) && SIZE_OF_BOARD == 5)
                {
                    sb.Append("\r\n\r\n\r\n");
                }
                
            }
            uxDisplay.Text = sb.ToString();
        }

        /// <summary>
        /// Generates the list of available dice
        /// </summary>
        /// <param name="diceArray">The array of dice for the Boggle Game</param>
        private void getDice(string[] diceArray)
        {
            foreach (string die in diceArray)
                diceList.Add(die);
        }

    }
}
