using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    btns[i, j].Top = i*20;
                    if (rnd.Next(1, 4) == 1)
                        isBomb[i, j] = true; 
                    btns[i, j].MouseClick += new MouseEventHandler(Apasare);
                    //btns[i, j]. += new EventHandler(Apasare);
                }
        }

        public void EndGane()
        {
            label1.Text = "AI PIERDUT";
        }

        public bool ValidIndicies (int i, int j)
        {
            if (i < 1 || j < 1 || i > 16 || j > 16)
                return false;
            return true;
        }

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

        private void Apasare(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            int i = btn.Top / 20;
            int j = btn.Left / 20;

            if (e.Button == MouseButtons.Left) {
                if (isBomb[i, j])
                    btn.BackColor = Color.Black;
                else
                    btn.Text = CheckBombs(i, j).ToString();

                label1.Text = i.ToString() + " " + j.ToString();
                

            } else
                    btn.BackColor = Color.Red;
                    
            

           
            
        }


    }
}
