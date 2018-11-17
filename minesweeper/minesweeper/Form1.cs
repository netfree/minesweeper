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
        bool[,] expanded = new bool[101, 101];

        const int CONST_TOP = 50;

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 1; i<=16; ++i)
                for(int j = 1; j<=16; ++j)
                {
                    btns[i, j] = new Button();
                    Controls.Add(btns[i, j]);
                    btns[i, j].Width = 20;
                    btns[i, j].Height = 20;
                    btns[i, j].Left = j*20;
                    btns[i, j].Top = i*20 + CONST_TOP;
                    btns[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    if (rnd.Next(1, 8) == 1)
                        isBomb[i, j] = true; 
                    btns[i, j].MouseDown += new MouseEventHandler(Apasare);
                    //btns[i, j]. += new EventHandler(Apasare);
                }
        }

        public void EndGane()
        {
            timer.Stop();

            for (int i = 1; i <= 16; ++i)
                for (int j = 1; j <= 16; ++j)
                    if (isBomb[i, j])
                        btns[i, j].BackgroundImage = minesweeper.Properties.Resources.mine1;
                    else
                    {
                        btns[i, j].BackColor = Color.DarkGray;
                        if (CheckBombs(i, j) != 0)
                            btns[i, j].Text = CheckBombs(i, j).ToString();
                    }
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
            expanded[ii, jj] = true;
            if (CheckBombs(ii, jj) != 0)
                btns[ii, jj].Text = CheckBombs(ii, jj).ToString();

            Debug.WriteLine(ii.ToString(), ' ', jj.ToString(), "\n");

            for (int i = ii - 1; i <= ii + 1; ++i)
                for (int j = jj - 1; j <= jj + 1; ++j)
                    if (!(i == ii && j == jj))
                        if (ValidIndicies(i, j) && CheckBombs(ii, jj) == 0 && !expanded[i,j])
                            Expand(i, j);
        }

        private void Apasare(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Focus();
            int i = (btn.Top - CONST_TOP) / 20;
            int j = btn.Left / 20;
            expanded[i, j] = true;

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

                    lblScore.Text = (++score).ToString();
                }

            } else
            {
                if (btn.BackgroundImage == minesweeper.Properties.Resources.flag)
                    btn.BackgroundImage = minesweeper.Properties.Resources.tile;
                else
                    btn.BackgroundImage = minesweeper.Properties.Resources.flag;
            }
                

        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        int global_time = 0;

        private void timer_Tick(object sender, EventArgs e)
        {
            global_time++;
            string cnst = ":";
            if (global_time % 60 < 10)
                cnst += "0";
            lblTime.Text = (global_time/60).ToString() + cnst + (global_time % 60).ToString();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }
    }
}
