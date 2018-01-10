namespace projectbaze
{
    partial class Cos
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
        protected void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cosCumparaturiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazinDataSet = new projectbaze.magazinDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cosCumparaturiTableAdapter = new projectbaze.magazinDataSetTableAdapters.CosCumparaturiTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantitate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idcumparareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprodusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numarproduseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magazinDataSet1 = new projectbaze.magazinDataSet1();
            this.produseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produseTableAdapter = new projectbaze.magazinDataSet1TableAdapters.ProduseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cosCumparaturiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazinDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cosCumparaturiBindingSource
            // 
            this.cosCumparaturiBindingSource.DataMember = "CosCumparaturi";
            this.cosCumparaturiBindingSource.DataSource = this.magazinDataSet;
            // 
            // magazinDataSet
            // 
            this.magazinDataSet.DataSetName = "magazinDataSet";
            this.magazinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Finalizare";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sterge";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cosCumparaturiTableAdapter
            // 
            this.cosCumparaturiTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nume,
            this.Pret,
            this.Cantitate});
            this.dataGridView1.Location = new System.Drawing.Point(69, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(369, 75);
            this.dataGridView1.TabIndex = 3;
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
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcumparareDataGridViewTextBoxColumn,
            this.idprodusDataGridViewTextBoxColumn,
            this.numarproduseDataGridViewTextBoxColumn,
            this.sumaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.cosCumparaturiBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(69, 103);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(446, 62);
            this.dataGridView2.TabIndex = 4;
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
            // magazinDataSet1
            // 
            this.magazinDataSet1.DataSetName = "magazinDataSet1";
            this.magazinDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produseBindingSource
            // 
            this.produseBindingSource.DataMember = "Produse";
            this.produseBindingSource.DataSource = this.magazinDataSet1;
            // 
            // produseTableAdapter
            // 
            this.produseTableAdapter.ClearBeforeFill = true;
            // 
            // Cos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 280);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Cos";
            this.Text = "Cos";
            this.Load += new System.EventHandler(this.Cos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cosCumparaturiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazinDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private magazinDataSet magazinDataSet;
        private System.Windows.Forms.BindingSource cosCumparaturiBindingSource;
        private magazinDataSetTableAdapters.CosCumparaturiTableAdapter cosCumparaturiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pret;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantitate;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcumparareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarproduseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumaDataGridViewTextBoxColumn;
        private magazinDataSet1 magazinDataSet1;
        private System.Windows.Forms.BindingSource produseBindingSource;
        private magazinDataSet1TableAdapters.ProduseTableAdapter produseTableAdapter;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}