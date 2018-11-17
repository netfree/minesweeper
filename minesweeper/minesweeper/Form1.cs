using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace minesweeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private int ConvertItoX()
        //{

        //}

        Random rnd = new Random();
        Button[,] btns = new Button[101, 101];
        bool[,] isBomb = new bool[101,101];
        int[,] expanded = new int[101, 101];
        bool[,] flagged = new bool[101, 101];


        public void InitGame()
        {
            timer.Start();
            global_time = 0;
            score = 0;
            nBombs = 0;
            lblScore.Text = score.ToString();

            for (int i = 1; i <= 16; ++i)
                for (int j = 1; j <= 16; ++j)
                {
                    if (rnd.Next(1, 107) == 1)
                    {
                        isBomb[i, j] = true;
                        nBombs++;
                    }
                    else
                        isBomb[i, j] = false;

                    btns[i, j].BackColor = BTN_DEFAULT_COLOR;
                    btns[i, j].Text = "";
                    btns[i, j].BackgroundImage = null;
                    expanded[i, j] = 0;
                    flagged[i, j] = false;
                    btns[i, j].Enabled = true;

                }
        }

        const int CONST_TOP = 50;
        Color BTN_DEFAULT_COLOR;



        private void Form1_Load(object sender, EventArgs e)
        {
            
            for (int i = 1; i <= 16; ++i)
                for (int j = 1; j <= 16; ++j)
                {
                    btns[i, j] = new Button();
                    Controls.Add(btns[i, j]);
                    btns[i, j].Width = 20;
                    btns[i, j].Height = 20;
                    btns[i, j].Left = j * 20;
                    btns[i, j].Enabled = false;
                    BTN_DEFAULT_COLOR = btns[i, j].BackColor;
                    btns[i, j].Top = i * 20 + CONST_TOP;
                    
                    btns[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    btns[i, j].MouseDown += new MouseEventHandler(Apasare);
                }
            InitGame();
        }

        int global_time; int nBombs;
        int left = 0;

        public void EndGane()
        {
            timer.Stop();
            bool winningGame = true;

            for(int i = 1; i<=16; ++i)
                for(int j = 1; j <= 16; ++j)
                {
                    if (btns[i, j].Enabled)
                        left++;

                    btns[i, j].Enabled = false;

                    if ((flagged[i, j] && isBomb[i, j] == false) || (!flagged[i, j] && isBomb[i, j]))
                    {
                        winningGame = false;
                        btns[i, j].BackColor = Color.DarkRed;
                    }
                }



            for (int i = 1; i <= 16; ++i)
                for (int j = 1; j <= 16; ++j)
                    if (isBomb[i, j])
                    {
                        btns[i, j].BackgroundImage = minesweeper.Properties.Resources.mine1;
                        if(btns[i, j].BackColor != Color.DarkRed)
                            btns[i, j].BackColor = Color.DarkGray;
                    }
                    else
                    {

                        if (CheckBombs(i, j) != 0)
                            btns[i, j].Text = CheckBombs(i, j).ToString();
                    }

            

            if (!winningGame)
                MessageBox.Show("BOOM BOOM! " + "Ai pierdut! TZEAPA!");
        }

        public bool ValidIndicies (int i, int j)
        {
            if (i < 1 || j < 1 || i > 16 || j > 16)
                return false;
            return true;
        }

        int score = 0;

        public int CheckBombs(int ii, int jj)
        {
            int k = 0;
            for(int i = ii - 1; i <= ii + 1; ++i)
                for(int j = jj - 1; j <= jj + 1; ++j)
                    if(!(i == ii && j == jj))
                    {
                        if (ValidIndicies(i, j))
                            if (isBomb[i, j] == true)
                                k++;
                    }
            return k;
        }

        private void Expand(int ii, int jj)
        {
            btns[ii, jj].BackColor = Color.DarkGray;
            expanded[ii, jj]++;
            score++;
            btns[ii, jj].Enabled = false;

            btns[ii, jj].BackgroundImage = null;

            if (CheckBombs(ii, jj) != 0)
                btns[ii, jj].Text = CheckBombs(ii, jj).ToString();

            Debug.WriteLine(ii.ToString(), ' ', jj.ToString(), "\n");

            for (int i = ii - 1; i <= ii + 1; ++i)
                for (int j = jj - 1; j <= jj + 1; ++j)
                    if (!(i == ii && j == jj))
                        if (ValidIndicies(i, j) && CheckBombs(ii, jj) == 0 && btns[i,j].Enabled != false)
                            Expand(i, j);
        }

        private void Apasare(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            int i = (btn.Top - CONST_TOP) / 20;
            int j = btn.Left / 20;
            

            if (e.Button == MouseButtons.Left) {
                if (isBomb[i, j])
                {
                    EndGane();
                }
                else
                {
                    if (CheckBombs(i, j) != 0)
                    {
                        btn.Text = CheckBombs(i, j).ToString();
                        btns[i, j].BackColor = Color.DarkGray;
                    }
                    else
                        Expand(i, j);

                    

                    lblScore.Text = (score).ToString();
                }

                btn.Enabled = false;

            } else
            {
                if (btn.BackgroundImage == null)
                {
                    btn.BackgroundImage = minesweeper.Properties.Resources.flag;
                    flagged[i, j] = true;
                }
                else
                {
                    flagged[i, j] = false;
                    btn.BackgroundImage = null;
                }
                
            }

            btnSmiley.Focus();

        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            global_time++;
            string cnst = ":";
            if (global_time % 60 < 10)
                cnst += "0";
            lblTime.Text = (global_time/60).ToString() + cnst + (global_time % 60).ToString();

            int all = 0;
    
            for(int i = 1; i<=16; ++i)
                for(int j = 1; j<=16; ++j)
                {
                    if (flagged[i, j] && isBomb[i, j])
                        all++;
                }

            if (all == nBombs)
            {
                timer.Stop();
                MessageBox.Show("Ai castigat!");
            }


        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitGame();
        }
    }
}
