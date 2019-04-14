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
    public partial class Rezultat : Form
    {
        int timp, scor;
        Form1 joc;
        FormJoc formjoc;

        public Rezultat()
        {
            InitializeComponent();
            this.TopMost = true;
            
        }

        public int Scor { get => scor; set => scor = value; }
        public int Timp { get => timp; set => timp = value; }
        public Form1 Joc { get => joc; set => joc = value; }
        public FormJoc Formjoc { get => formjoc; set => formjoc = value; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // this.tabelaScorTableAdapter.FillDescScorAscTimp//(this.bDScorDataSet.tabelaScor);

            this.tabelaScorTableAdapter.Inserare(formjoc.Pseudonim, timp, scor);
            this.tabelaScorTableAdapter.Update(this.bDScorDataSet.tabelaScor); 
            this.Hide();
            Joc.Hide();
            formjoc.Show();
        }

        private void Rezultat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDScorDataSet.tabelaScor' table. You can move, or remove it, as needed.
            this.tabelaScorTableAdapter.Fill(this.bDScorDataSet.tabelaScor);
            this.Focus();
            button1.Focus();
            label4.Text += scor.ToString();
            string cnst = ":";
            if (timp % 60 < 10)
                cnst += "0";
            label5.Text += (timp / 60).ToString() + cnst + (timp % 60).ToString();
        }
    }
}
