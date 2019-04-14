namespace minesweeper
{
    partial class Rezultat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rezultat));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bDScorDataSet = new minesweeper.BDScorDataSet();
            this.tabelaScorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabelaScorTableAdapter = new minesweeper.BDScorDataSetTableAdapters.tabelaScorTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pseudonimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDScorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaScorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 37.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(13, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 58);
            this.label3.TabIndex = 2;
            this.label3.Text = "Felicitări!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label4.Location = new System.Drawing.Point(18, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Scorul Obținut: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(18, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Timpul tău: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.GhostWhite;
            this.button1.Location = new System.Drawing.Point(23, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Am înțeles!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.pseudonimDataGridViewTextBoxColumn,
            this.timpDataGridViewTextBoxColumn,
            this.scorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tabelaScorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(257, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // bDScorDataSet
            // 
            this.bDScorDataSet.DataSetName = "BDScorDataSet";
            this.bDScorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabelaScorBindingSource
            // 
            this.tabelaScorBindingSource.DataMember = "tabelaScor";
            this.tabelaScorBindingSource.DataSource = this.bDScorDataSet;
            // 
            // tabelaScorTableAdapter
            // 
            this.tabelaScorTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // pseudonimDataGridViewTextBoxColumn
            // 
            this.pseudonimDataGridViewTextBoxColumn.DataPropertyName = "pseudonim";
            this.pseudonimDataGridViewTextBoxColumn.HeaderText = "pseudonim";
            this.pseudonimDataGridViewTextBoxColumn.Name = "pseudonimDataGridViewTextBoxColumn";
            // 
            // timpDataGridViewTextBoxColumn
            // 
            this.timpDataGridViewTextBoxColumn.DataPropertyName = "timp";
            this.timpDataGridViewTextBoxColumn.HeaderText = "timp";
            this.timpDataGridViewTextBoxColumn.Name = "timpDataGridViewTextBoxColumn";
            // 
            // scorDataGridViewTextBoxColumn
            // 
            this.scorDataGridViewTextBoxColumn.DataPropertyName = "scor";
            this.scorDataGridViewTextBoxColumn.HeaderText = "scor";
            this.scorDataGridViewTextBoxColumn.Name = "scorDataGridViewTextBoxColumn";
            // 
            // Rezultat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 268);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rezultat";
            this.Text = "Rezultat";
            this.Load += new System.EventHandler(this.Rezultat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDScorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaScorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BDScorDataSet bDScorDataSet;
        private System.Windows.Forms.BindingSource tabelaScorBindingSource;
        private BDScorDataSetTableAdapters.tabelaScorTableAdapter tabelaScorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pseudonimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scorDataGridViewTextBoxColumn;
    }
}