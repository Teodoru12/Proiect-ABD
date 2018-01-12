namespace projectbaze
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idcumparareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprodusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numarproduseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cosCumparaturiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazinDataSet1 = new projectbaze.magazinDataSet1();
            this.cosCumparaturiTableAdapter = new projectbaze.magazinDataSet1TableAdapters.CosCumparaturiTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantitate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantittaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTcosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazinDataSet2 = new projectbaze.magazinDataSet2();
            this.pTcosTableAdapter = new projectbaze.magazinDataSet2TableAdapters.PTcosTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosCumparaturiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazinDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTcosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazinDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcumparareDataGridViewTextBoxColumn,
            this.idprodusDataGridViewTextBoxColumn,
            this.numarproduseDataGridViewTextBoxColumn,
            this.sumaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cosCumparaturiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(19, 14);
            this.dataGridView1.TabIndex = 0;
            // 
            // idcumparareDataGridViewTextBoxColumn
            // 
            this.idcumparareDataGridViewTextBoxColumn.DataPropertyName = "id_cumparare";
            this.idcumparareDataGridViewTextBoxColumn.HeaderText = "id_cumparare";
            this.idcumparareDataGridViewTextBoxColumn.Name = "idcumparareDataGridViewTextBoxColumn";
            // 
            // idprodusDataGridViewTextBoxColumn
            // 
            this.idprodusDataGridViewTextBoxColumn.DataPropertyName = "id_produs";
            this.idprodusDataGridViewTextBoxColumn.HeaderText = "id_produs";
            this.idprodusDataGridViewTextBoxColumn.Name = "idprodusDataGridViewTextBoxColumn";
            // 
            // numarproduseDataGridViewTextBoxColumn
            // 
            this.numarproduseDataGridViewTextBoxColumn.DataPropertyName = "numar_produse";
            this.numarproduseDataGridViewTextBoxColumn.HeaderText = "numar_produse";
            this.numarproduseDataGridViewTextBoxColumn.Name = "numarproduseDataGridViewTextBoxColumn";
            // 
            // sumaDataGridViewTextBoxColumn
            // 
            this.sumaDataGridViewTextBoxColumn.DataPropertyName = "suma";
            this.sumaDataGridViewTextBoxColumn.HeaderText = "suma";
            this.sumaDataGridViewTextBoxColumn.Name = "sumaDataGridViewTextBoxColumn";
            // 
            // cosCumparaturiBindingSource
            // 
            this.cosCumparaturiBindingSource.DataMember = "CosCumparaturi";
            this.cosCumparaturiBindingSource.DataSource = this.magazinDataSet1;
            // 
            // magazinDataSet1
            // 
            this.magazinDataSet1.DataSetName = "magazinDataSet1";
            this.magazinDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cosCumparaturiTableAdapter
            // 
            this.cosCumparaturiTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(674, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Finalizare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nume,
            this.Pret,
            this.Cantitate});
            this.dataGridView2.Location = new System.Drawing.Point(12, 46);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(11, 14);
            this.dataGridView2.TabIndex = 2;
            // 
            // Nume
            // 
            this.Nume.HeaderText = "Nume";
            this.Nume.Name = "Nume";
            // 
            // Pret
            // 
            this.Pret.HeaderText = "Pret";
            this.Pret.Name = "Pret";
            // 
            // Cantitate
            // 
            this.Cantitate.HeaderText = "Cantitate";
            this.Cantitate.Name = "Cantitate";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.cantittaDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.pTcosBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(169, 75);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(425, 150);
            this.dataGridView3.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            // 
            // cantittaDataGridViewTextBoxColumn
            // 
            this.cantittaDataGridViewTextBoxColumn.DataPropertyName = "Cantitta";
            this.cantittaDataGridViewTextBoxColumn.HeaderText = "Cantitta";
            this.cantittaDataGridViewTextBoxColumn.Name = "cantittaDataGridViewTextBoxColumn";
            // 
            // pTcosBindingSource
            // 
            this.pTcosBindingSource.DataMember = "PTcos";
            this.pTcosBindingSource.DataSource = this.magazinDataSet2;
            // 
            // magazinDataSet2
            // 
            this.magazinDataSet2.DataSetName = "magazinDataSet2";
            this.magazinDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pTcosTableAdapter
            // 
            this.pTcosTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "TOTAL:";
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(229, 247);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 23);
            this.Button2.TabIndex = 5;
            this.Button2.Text = "Sterge";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 15.75F);
            this.label2.Location = new System.Drawing.Point(116, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(779, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(339, 233);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(665, 262);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(749, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 324);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Shown += new System.EventHandler(this.one_shown_priv);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosCumparaturiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazinDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTcosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazinDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private magazinDataSet1 magazinDataSet1;
        private System.Windows.Forms.BindingSource cosCumparaturiBindingSource;
        private magazinDataSet1TableAdapters.CosCumparaturiTableAdapter cosCumparaturiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcumparareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarproduseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pret;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantitate;
        private System.Windows.Forms.DataGridView dataGridView3;
        private magazinDataSet2 magazinDataSet2;
        private System.Windows.Forms.BindingSource pTcosBindingSource;
        private magazinDataSet2TableAdapters.PTcosTableAdapter pTcosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantittaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}