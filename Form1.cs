using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        bool turn = true;
        int turn_count = 0;

        public TicTacToe()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Button_click(object sender, EventArgs e)
        {
            Button main = (Button)sender;
            if (turn)
                main.Text = "X";
            else
                main.Text = "O";

            turn = !turn;
            main.Enabled = false;
            turn_count++;

            Checker();
        }

        private void Checker()
        {
            // For X
            // horizontal winning pattern
            if (Btn1TTT.Text == "X" && Btn2TTT.Text == "X" && Btn3TTT.Text == "X")
            {
                MessageBox.Show("Player X Wins! Would you like to try again?", "Congrats!", MessageBoxButtons.YesNo);
                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Btn1TTT.Enabled = true;
                    Btn2TTT.Enabled = true;
                    Btn3TTT.Enabled = true;
                    Btn4TTT.Enabled = true;
                    Btn5TTT.Enabled = true;
                    Btn6TTT.Enabled = true;
                    Btn7TTT.Enabled = true;
                    Btn8TTT.Enabled = true;
                    Btn9TTT.Enabled = true;

                    Btn1TTT.Text = "";
                    Btn2TTT.Text = "";
                    Btn3TTT.Text = "";
                    Btn4TTT.Text = "";
                    Btn5TTT.Text = "";
                    Btn6TTT.Text = "";
                    Btn7TTT.Text = "";
                    Btn8TTT.Text = "";
                    Btn9TTT.Text = "";
                }

                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Application.Exit();

                }
            }

            if (Btn4TTT.Text == "X" && Btn5TTT.Text == "X" && Btn6TTT.Text == "X")
            {
                MessageBox.Show("Player X Wins! Would you like to try again?", "Congrats!", MessageBoxButtons.YesNo);
                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Btn1TTT.Enabled = true;
                    Btn2TTT.Enabled = true;
                    Btn3TTT.Enabled = true;
                    Btn4TTT.Enabled = true;
                    Btn5TTT.Enabled = true;
                    Btn6TTT.Enabled = true;
                    Btn7TTT.Enabled = true;
                    Btn8TTT.Enabled = true;
                    Btn9TTT.Enabled = true;

                    Btn1TTT.Text = "";
                    Btn2TTT.Text = "";
                    Btn3TTT.Text = "";
                    Btn4TTT.Text = "";
                    Btn5TTT.Text = "";
                    Btn6TTT.Text = "";
                    Btn7TTT.Text = "";
                    Btn8TTT.Text = "";
                    Btn9TTT.Text = "";
                }

                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Application.Exit();

                }
            }

            if (Btn7TTT.Text == "X" && Btn8TTT.Text == "X" && Btn9TTT.Text == "X")
            {
                MessageBox.Show("Player X Wins! Would you like to try again?", "Congrats!", MessageBoxButtons.YesNo);
                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Btn1TTT.Enabled = true;
                    Btn2TTT.Enabled = true;
                    Btn3TTT.Enabled = true;
                    Btn4TTT.Enabled = true;
                    Btn5TTT.Enabled = true;
                    Btn6TTT.Enabled = true;
                    Btn7TTT.Enabled = true;
                    Btn8TTT.Enabled = true;
                    Btn9TTT.Enabled = true;

                    Btn1TTT.Text = "";
                    Btn2TTT.Text = "";
                    Btn3TTT.Text = "";
                    Btn4TTT.Text = "";
                    Btn5TTT.Text = "";
                    Btn6TTT.Text = "";
                    Btn7TTT.Text = "";
                    Btn8TTT.Text = "";
                    Btn9TTT.Text = "";
                }

                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Application.Exit();

                }
            }

            // vertical winning pattern
            if (Btn1TTT.Text == "X" && Btn4TTT.Text == "X" && Btn7TTT.Text == "X")
            {
                MessageBox.Show("Player X Wins! Would you like to try again?", "Congrats!", MessageBoxButtons.YesNo);
                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Btn1TTT.Enabled = true;
                    Btn2TTT.Enabled = true;
                    Btn3TTT.Enabled = true;
                    Btn4TTT.Enabled = true;
                    Btn5TTT.Enabled = true;
                    Btn6TTT.Enabled = true;
                    Btn7TTT.Enabled = true;
                    Btn8TTT.Enabled = true;
                    Btn9TTT.Enabled = true;

                    Btn1TTT.Text = "";
                    Btn2TTT.Text = "";
                    Btn3TTT.Text = "";
                    Btn4TTT.Text = "";
                    Btn5TTT.Text = "";
                    Btn6TTT.Text = "";
                    Btn7TTT.Text = "";
                    Btn8TTT.Text = "";
                    Btn9TTT.Text = "";
                }

                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Application.Exit();

                }
            }

            if (Btn2TTT.Text == "X" && Btn5TTT.Text == "X" && Btn8TTT.Text == "X")
            {
                MessageBox.Show("Player X Wins! Would you like to try again?", "Congrats!", MessageBoxButtons.YesNo);
                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Btn1TTT.Enabled = true;
                    Btn2TTT.Enabled = true;
                    Btn3TTT.Enabled = true;
                    Btn4TTT.Enabled = true;
                    Btn5TTT.Enabled = true;
                    Btn6TTT.Enabled = true;
                    Btn7TTT.Enabled = true;
                    Btn8TTT.Enabled = true;
                    Btn9TTT.Enabled = true;

                    Btn1TTT.Text = "";
                    Btn2TTT.Text = "";
                    Btn3TTT.Text = "";
                    Btn4TTT.Text = "";
                    Btn5TTT.Text = "";
                    Btn6TTT.Text = "";
                    Btn7TTT.Text = "";
                    Btn8TTT.Text = "";
                    Btn9TTT.Text = "";
                }

                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Application.Exit();

                }
            }

            if (Btn3TTT.Text == "X" && Btn6TTT.Text == "X" && Btn9TTT.Text == "X")
            {
                MessageBox.Show("Player X Wins! Would you like to try again?", "Congrats!", MessageBoxButtons.YesNo);
                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Btn1TTT.Enabled = true;
                    Btn2TTT.Enabled = true;
                    Btn3TTT.Enabled = true;
                    Btn4TTT.Enabled = true;
                    Btn5TTT.Enabled = true;
                    Btn6TTT.Enabled = true;
                    Btn7TTT.Enabled = true;
                    Btn8TTT.Enabled = true;
                    Btn9TTT.Enabled = true;

                    Btn1TTT.Text = "";
                    Btn2TTT.Text = "";
                    Btn3TTT.Text = "";
                    Btn4TTT.Text = "";
                    Btn5TTT.Text = "";
                    Btn6TTT.Text = "";
                    Btn7TTT.Text = "";
                    Btn8TTT.Text = "";
                    Btn9TTT.Text = "";
                }

                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Application.Exit();

                }
            }

            // diagonal winning pattern
            if (Btn1TTT.Text == "X" && Btn5TTT.Text == "X" && Btn9TTT.Text == "X")
            {
                MessageBox.Show("Player X Wins! Would you like to try again?", "Congrats!", MessageBoxButtons.YesNo);
                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Btn1TTT.Enabled = true;
                    Btn2TTT.Enabled = true;
                    Btn3TTT.Enabled = true;
                    Btn4TTT.Enabled = true;
                    Btn5TTT.Enabled = true;
                    Btn6TTT.Enabled = true;
                    Btn7TTT.Enabled = true;
                    Btn8TTT.Enabled = true;
                    Btn9TTT.Enabled = true;

                    Btn1TTT.Text = "";
                    Btn2TTT.Text = "";
                    Btn3TTT.Text = "";
                    Btn4TTT.Text = "";
                    Btn5TTT.Text = "";
                    Btn6TTT.Text = "";
                    Btn7TTT.Text = "";
                    Btn8TTT.Text = "";
                    Btn9TTT.Text = "";
                }

                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Application.Exit();

                }
            }

            if (Btn3TTT.Text == "X" && Btn5TTT.Text == "X" && Btn7TTT.Text == "X")
            {
                MessageBox.Show("Player X Wins! Would you like to try again?", "Congrats!", MessageBoxButtons.YesNo);
                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Btn1TTT.Enabled = true;
                    Btn2TTT.Enabled = true;
                    Btn3TTT.Enabled = true;
                    Btn4TTT.Enabled = true;
                    Btn5TTT.Enabled = true;
                    Btn6TTT.Enabled = true;
                    Btn7TTT.Enabled = true;
                    Btn8TTT.Enabled = true;
                    Btn9TTT.Enabled = true;

                    Btn1TTT.Text = "";
                    Btn2TTT.Text = "";
                    Btn3TTT.Text = "";
                    Btn4TTT.Text = "";
                    Btn5TTT.Text = "";
                    Btn6TTT.Text = "";
                    Btn7TTT.Text = "";
                    Btn8TTT.Text = "";
                    Btn9TTT.Text = "";
                }
                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Application.Exit();

                }
            }

            // For O
            // horizontal winning pattern
            if (Btn1TTT.Text == "X" && Btn2TTT.Text == "O" && Btn3TTT.Text == "O")
            {
                MessageBox.Show("Player O Wins! Would you like to try again?", "Congrats!", MessageBoxButtons.YesNo);
                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Btn1TTT.Enabled = true;
                    Btn2TTT.Enabled = true;
                    Btn3TTT.Enabled = true;
                    Btn4TTT.Enabled = true;
                    Btn5TTT.Enabled = true;
                    Btn6TTT.Enabled = true;
                    Btn7TTT.Enabled = true;
                    Btn8TTT.Enabled = true;
                    Btn9TTT.Enabled = true;

                    Btn1TTT.Text = "";
                    Btn2TTT.Text = "";
                    Btn3TTT.Text = "";
                    Btn4TTT.Text = "";
                    Btn5TTT.Text = "";
                    Btn6TTT.Text = "";
                    Btn7TTT.Text = "";
                    Btn8TTT.Text = "";
                    Btn9TTT.Text = "";
                }
                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Application.Exit();

                }
            }

            if (Btn4TTT.Text == "O" && Btn5TTT.Text == "O" && Btn6TTT.Text == "O")
            {
                MessageBox.Show("Player O Wins! Would you like to try again?", "Congrats!", MessageBoxButtons.YesNo);
                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Btn1TTT.Enabled = true;
                    Btn2TTT.Enabled = true;
                    Btn3TTT.Enabled = true;
                    Btn4TTT.Enabled = true;
                    Btn5TTT.Enabled = true;
                    Btn6TTT.Enabled = true;
                    Btn7TTT.Enabled = true;
                    Btn8TTT.Enabled = true;
                    Btn9TTT.Enabled = true;

                    Btn1TTT.Text = "";
                    Btn2TTT.Text = "";
                    Btn3TTT.Text = "";
                    Btn4TTT.Text = "";
                    Btn5TTT.Text = "";
                    Btn6TTT.Text = "";
                    Btn7TTT.Text = "";
                    Btn8TTT.Text = "";
                    Btn9TTT.Text = "";
                }
                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Application.Exit();

                }
            }

            if (Btn7TTT.Text == "O" && Btn8TTT.Text == "O" && Btn9TTT.Text == "O")
            {
                MessageBox.Show("Player O Wins! Would you like to try again?", "Congrats!", MessageBoxButtons.YesNo);
                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Btn1TTT.Enabled = true;
                    Btn2TTT.Enabled = true;
                    Btn3TTT.Enabled = true;
                    Btn4TTT.Enabled = true;
                    Btn5TTT.Enabled = true;
                    Btn6TTT.Enabled = true;
                    Btn7TTT.Enabled = true;
                    Btn8TTT.Enabled = true;
                    Btn9TTT.Enabled = true;

                    Btn1TTT.Text = "";
                    Btn2TTT.Text = "";
                    Btn3TTT.Text = "";
                    Btn4TTT.Text = "";
                    Btn5TTT.Text = "";
                    Btn6TTT.Text = "";
                    Btn7TTT.Text = "";
                    Btn8TTT.Text = "";
                    Btn9TTT.Text = "";
                }
                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Application.Exit();

                }
            }

            // vertical winning pattern
            if (Btn1TTT.Text == "O" && Btn4TTT.Text == "O" && Btn7TTT.Text == "O")
            {
                MessageBox.Show("Player O Wins! Would you like to try again?", "Congrats!", MessageBoxButtons.YesNo);
                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Btn1TTT.Enabled = true;
                    Btn2TTT.Enabled = true;
                    Btn3TTT.Enabled = true;
                    Btn4TTT.Enabled = true;
                    Btn5TTT.Enabled = true;
                    Btn6TTT.Enabled = true;
                    Btn7TTT.Enabled = true;
                    Btn8TTT.Enabled = true;
                    Btn9TTT.Enabled = true;

                    Btn1TTT.Text = "";
                    Btn2TTT.Text = "";
                    Btn3TTT.Text = "";
                    Btn4TTT.Text = "";
                    Btn5TTT.Text = "";
                    Btn6TTT.Text = "";
                    Btn7TTT.Text = "";
                    Btn8TTT.Text = "";
                    Btn9TTT.Text = "";
                }
                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Application.Exit();

                }
            }

            if (Btn2TTT.Text == "O" && Btn5TTT.Text == "O" && Btn8TTT.Text == "O")
            {
                MessageBox.Show("Player O Wins! Would you like to try again?", "Congrats!", MessageBoxButtons.YesNo);
                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Btn1TTT.Enabled = true;
                    Btn2TTT.Enabled = true;
                    Btn3TTT.Enabled = true;
                    Btn4TTT.Enabled = true;
                    Btn5TTT.Enabled = true;
                    Btn6TTT.Enabled = true;
                    Btn7TTT.Enabled = true;
                    Btn8TTT.Enabled = true;
                    Btn9TTT.Enabled = true;

                    Btn1TTT.Text = "";
                    Btn2TTT.Text = "";
                    Btn3TTT.Text = "";
                    Btn4TTT.Text = "";
                    Btn5TTT.Text = "";
                    Btn6TTT.Text = "";
                    Btn7TTT.Text = "";
                    Btn8TTT.Text = "";
                    Btn9TTT.Text = "";
                }
                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Application.Exit();

                }
            }

            if (Btn3TTT.Text == "O" && Btn6TTT.Text == "O" && Btn9TTT.Text == "O")
            {
                MessageBox.Show("Player O Wins! Would you like to try again?", "Congrats!", MessageBoxButtons.YesNo);
                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Btn1TTT.Enabled = true;
                    Btn2TTT.Enabled = true;
                    Btn3TTT.Enabled = true;
                    Btn4TTT.Enabled = true;
                    Btn5TTT.Enabled = true;
                    Btn6TTT.Enabled = true;
                    Btn7TTT.Enabled = true;
                    Btn8TTT.Enabled = true;
                    Btn9TTT.Enabled = true;

                    Btn1TTT.Text = "";
                    Btn2TTT.Text = "";
                    Btn3TTT.Text = "";
                    Btn4TTT.Text = "";
                    Btn5TTT.Text = "";
                    Btn6TTT.Text = "";
                    Btn7TTT.Text = "";
                    Btn8TTT.Text = "";
                    Btn9TTT.Text = "";
                }
                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Application.Exit();

                }
            }

            // diagonal winning pattern
            if (Btn1TTT.Text == "O" && Btn5TTT.Text == "O" && Btn9TTT.Text == "O")
            {
                MessageBox.Show("Player O Wins! Would you like to try again?", "Congrats!", MessageBoxButtons.YesNo);
                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Btn1TTT.Enabled = true;
                    Btn2TTT.Enabled = true;
                    Btn3TTT.Enabled = true;
                    Btn4TTT.Enabled = true;
                    Btn5TTT.Enabled = true;
                    Btn6TTT.Enabled = true;
                    Btn7TTT.Enabled = true;
                    Btn8TTT.Enabled = true;
                    Btn9TTT.Enabled = true;

                    Btn1TTT.Text = "";
                    Btn2TTT.Text = "";
                    Btn3TTT.Text = "";
                    Btn4TTT.Text = "";
                    Btn5TTT.Text = "";
                    Btn6TTT.Text = "";
                    Btn7TTT.Text = "";
                    Btn8TTT.Text = "";
                    Btn9TTT.Text = "";
                }

                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Application.Exit();

                }
            }

            if (Btn3TTT.Text == "O" && Btn5TTT.Text == "O" && Btn7TTT.Text == "O")
            {
                MessageBox.Show("Player O Wins! Would you like to try again?", "Congrats!", MessageBoxButtons.YesNo);
                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Btn1TTT.Enabled = true;
                    Btn2TTT.Enabled = true;
                    Btn3TTT.Enabled = true;
                    Btn4TTT.Enabled = true;
                    Btn5TTT.Enabled = true;
                    Btn6TTT.Enabled = true;
                    Btn7TTT.Enabled = true;
                    Btn8TTT.Enabled = true;
                    Btn9TTT.Enabled = true;

                    Btn1TTT.Text = "";
                    Btn2TTT.Text = "";
                    Btn3TTT.Text = "";
                    Btn4TTT.Text = "";
                    Btn5TTT.Text = "";
                    Btn6TTT.Text = "";
                    Btn7TTT.Text = "";
                    Btn8TTT.Text = "";
                    Btn9TTT.Text = "";
                }

                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Application.Exit();

                }

            }
            if (turn_count == 9)
            {
                MessageBox.Show("It's a Draw! Would you like to try again?", "Ouch!", MessageBoxButtons.YesNo);
                if (MessageBox.Show("It's a Draw! Would you like to try again?", "Ouch!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Btn1TTT.Enabled = true;
                    Btn2TTT.Enabled = true;
                    Btn3TTT.Enabled = true;
                    Btn4TTT.Enabled = true;
                    Btn5TTT.Enabled = true;
                    Btn6TTT.Enabled = true;
                    Btn7TTT.Enabled = true;
                    Btn8TTT.Enabled = true;
                    Btn9TTT.Enabled = true;

                    Btn1TTT.Text = "";
                    Btn2TTT.Text = "";
                    Btn3TTT.Text = "";
                    Btn4TTT.Text = "";
                    Btn5TTT.Text = "";
                    Btn6TTT.Text = "";
                    Btn7TTT.Text = "";
                    Btn8TTT.Text = "";
                    Btn9TTT.Text = "";
                }

                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Application.Exit();

                }
            }
            
            }


            }

        }


            