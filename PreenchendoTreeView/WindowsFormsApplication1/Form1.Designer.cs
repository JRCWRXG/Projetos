namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.lblItem = new System.Windows.Forms.Label();
            this.lnkRecolherItens = new System.Windows.Forms.LinkLabel();
            this.btnCarga = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(12, 330);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(144, 43);
            this.btnCarregar.TabIndex = 0;
            this.btnCarregar.Text = "Carregar Dados (SQL)";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // lblItem
            // 
            this.lblItem.Location = new System.Drawing.Point(191, 408);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(181, 23);
            this.lblItem.TabIndex = 0;
            // 
            // lnkRecolherItens
            // 
            this.lnkRecolherItens.AutoSize = true;
            this.lnkRecolherItens.Location = new System.Drawing.Point(230, 345);
            this.lnkRecolherItens.Name = "lnkRecolherItens";
            this.lnkRecolherItens.Size = new System.Drawing.Size(76, 13);
            this.lnkRecolherItens.TabIndex = 2;
            this.lnkRecolherItens.TabStop = true;
            this.lnkRecolherItens.Text = "Recolher Itens";
            this.lnkRecolherItens.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRecolherItens_LinkClicked);
            // 
            // btnCarga
            // 
            this.btnCarga.Location = new System.Drawing.Point(450, 330);
            this.btnCarga.Name = "btnCarga";
            this.btnCarga.Size = new System.Drawing.Size(140, 43);
            this.btnCarga.TabIndex = 1;
            this.btnCarga.Text = "Carregar Dados (Objetos)";
            this.btnCarga.UseVisualStyleBackColor = true;
            this.btnCarga.Click += new System.EventHandler(this.btnCarga_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 16);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(569, 278);
            this.treeView1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(12, 379);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(572, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 220;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Idade";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 568);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lnkRecolherItens);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.btnCarga);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.LinkLabel lnkRecolherItens;
        private System.Windows.Forms.Button btnCarga;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

