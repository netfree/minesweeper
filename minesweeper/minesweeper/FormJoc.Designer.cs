namespace minesweeper
{
    partial class FormJoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJoc));
            this.tabelaScorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDScorDataSet = new minesweeper.BDScorDataSet();
            this.tabelaScorTableAdapter = new minesweeper.BDScorDataSetTableAdapters.tabelaScorTableAdapter();
            this.buttonJocNou = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.scorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pseudonimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabelaScorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bDScorDataSet1 = new minesweeper.BDScorDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaScorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDScorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaScorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDScorDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabelaScorBindingSource
            // 
            this.tabelaScorBindingSource.DataMember = "tabelaScor";
            this.tabelaScorBindingSource.DataSource = this.bDScorDataSet;
            // 
            // bDScorDataSet
            // 
            this.bDScorDataSet.DataSetName = "BDScorDataSet";
            this.bDScorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabelaScorTableAdapter
            // 
            this.tabelaScorTableAdapter.ClearBeforeFill = true;
            // 
            // buttonJocNou
            // 
            this.buttonJocNou.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonJocNou.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonJocNou.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJocNou.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonJocNou.Location = new System.Drawing.Point(438, 336);
            this.buttonJocNou.Name = "buttonJocNou";
            this.buttonJocNou.Size = new System.Drawing.Size(207, 59);
            this.buttonJocNou.TabIndex = 0;
            this.buttonJocNou.Text = "Înceară și tu!";
            this.buttonJocNou.UseVisualStyleBackColor = false;
            this.buttonJocNou.Click += new System.EventHandler(this.buttonJocNou_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scorDataGridViewTextBoxColumn,
            this.timpDataGridViewTextBoxColumn,
            this.pseudonimDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tabelaScorBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(13, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(345, 356);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // scorDataGridViewTextBoxColumn
            // 
            this.scorDataGridViewTextBoxColumn.DataPropertyName = "scor";
            this.scorDataGridViewTextBoxColumn.HeaderText = "scor";
            this.scorDataGridViewTextBoxColumn.Name = "scorDataGridViewTextBoxColumn";
            this.scorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timpDataGridViewTextBoxColumn
            // 
            this.timpDataGridViewTextBoxColumn.DataPropertyName = "timp";
            this.timpDataGridViewTextBoxColumn.HeaderText = "timp";
            this.timpDataGridViewTextBoxColumn.Name = "timpDataGridViewTextBoxColumn";
            this.timpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pseudonimDataGridViewTextBoxColumn
            // 
            this.pseudonimDataGridViewTextBoxColumn.DataPropertyName = "pseudonim";
            this.pseudonimDataGridViewTextBoxColumn.HeaderText = "pseudonim";
            this.pseudonimDataGridViewTextBoxColumn.Name = "pseudonimDataGridViewTextBoxColumn";
            this.pseudonimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tabelaScorBindingSource1
            // 
            this.tabelaScorBindingSource1.DataMember = "tabelaScor";
            this.tabelaScorBindingSource1.DataSource = this.bDScorDataSet1;
            // 
            // bDScorDataSet1
            // 
            this.bDScorDataSet1.DataSetName = "BDScorDataSet";
            this.bDScorDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox1.Location = new System.Drawing.Point(438, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(200, 38);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Resize += new System.EventHandler(this.textBox1_Resize);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cele mai bune rezultate:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ai nevoie de ajutor?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(412, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Alege-ți un pseudonim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Joc Minesweeper";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::minesweeper.Properties.Resources.mine5;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(465, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 155);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FormJoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonJocNou);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormJoc";
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.FormJoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaScorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDScorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaScorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDScorDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BDScorDataSet bDScorDataSet;
        private System.Windows.Forms.BindingSource tabelaScorBindingSource;
        private BDScorDataSetTableAdapters.tabelaScorTableAdapter tabelaScorTableAdapter;
        private System.Windows.Forms.Button buttonJocNou;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BDScorDataSet bDScorDataSet1;
        private System.Windows.Forms.BindingSource tabelaScorBindingSource1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn scorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pseudonimDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}