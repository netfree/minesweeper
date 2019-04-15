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
    public partial class FormJoc : Form
    {
        public FormJoc()
        {
            InitializeComponent();
        }

        string pseudonim = "Anonim";

        public string Pseudonim { get => pseudonim; set => pseudonim = value; }

        //Label[,] labels = new Label[11, 4];

        public void Reactualizare()
        {
            this.tabelaScorTableAdapter.Update(this.bDScorDataSet1.tabelaScor);
            this.tabelaScorTableAdapter.FillDescScorAscTimp(this.bDScorDataSet1.tabelaScor);
        }

        private void FormJoc_Load(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Text = "Anonim";

            
            //int rows = 11, columns = 4;

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        labels[i, j] = new Label();
            //        labels[i, j].Parent = this;
            //        labels[i, j].Name = i + "_" + j;
            //        labels[i, j].TextAlign = ContentAlignment.MiddleCenter;
            //        labels[i, j].Location = new Point(20 + 20 * j, 20 + 20 * i);
            //        labels[i, j].Visible = true;
            //        labels[i, j].Size = new Size(20, 20);
            //        labels[i, j].Text = "A";
            //    }
            //}

            // TODO: This line of code loads data into the 'bDScorDataSet1.tabelaScor' table. You can move, or remove it, as needed.
            this.tabelaScorTableAdapter.FillDescScorAscTimp(this.bDScorDataSet1.tabelaScor);
            // TODO: This line of code loads data into the 'bDScorDataSet.tabelaScor' table. You can move, or remove it, as needed.
            //this.tabelaScorTableAdapter.FillDescScorAscTimp(this.bDScorDataSet.tabelaScor);

            foreach (DataRow dw in this.bDScorDataSet.tabelaScor)
            {
                Debug.WriteLine(dw[1]);
            }


        }

        

        private void buttonJocNou_Click(object sender, EventArgs e)
        {
            Form1 joc = new Form1();
            joc.Formjoc = this;
            joc.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Pseudonim = textBox1.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillDescScorAscTimpToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tabelaScorTableAdapter.FillDescScorAscTimp(this.bDScorDataSet.tabelaScor);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillDescScorAscTimpToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.tabelaScorTableAdapter.FillDescScorAscTimp(this.bDScorDataSet.tabelaScor);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInformatii forminfo = new FormInformatii();

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FormInformatii))
                {
                    form.Activate();
                    return;
                }
            }

            forminfo.Show();
        }

        private void textBox1_Resize(object sender, EventArgs e)
        {

        }
    }
}
