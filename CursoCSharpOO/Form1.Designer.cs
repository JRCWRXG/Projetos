namespace CursoCSharpOO
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
            this.btCriarCarro = new System.Windows.Forms.Button();
            this.tbQuilometragemCarro = new System.Windows.Forms.TextBox();
            this.tbCapacidadeCarro = new System.Windows.Forms.TextBox();
            this.tbDescricaoCarro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btCriarAviao = new System.Windows.Forms.Button();
            this.tbHorasAviao = new System.Windows.Forms.TextBox();
            this.tbCapacidadeAviao = new System.Windows.Forms.TextBox();
            this.tbDescricaoAviao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMoverCarro = new System.Windows.Forms.Button();
            this.btnMoverAviao = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMoverCarro);
            this.groupBox1.Controls.Add(this.btCriarCarro);
            this.groupBox1.Controls.Add(this.tbQuilometragemCarro);
            this.groupBox1.Controls.Add(this.tbCapacidadeCarro);
            this.groupBox1.Controls.Add(this.tbDescricaoCarro);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carro";
            // 
            // btCriarCarro
            // 
            this.btCriarCarro.Location = new System.Drawing.Point(10, 63);
            this.btCriarCarro.Name = "btCriarCarro";
            this.btCriarCarro.Size = new System.Drawing.Size(75, 23);
            this.btCriarCarro.TabIndex = 6;
            this.btCriarCarro.Text = "Criar";
            this.btCriarCarro.UseVisualStyleBackColor = true;
            this.btCriarCarro.Click += new System.EventHandler(this.btCriarCarro_Click);
            // 
            // tbQuilometragemCarro
            // 
            this.tbQuilometragemCarro.Location = new System.Drawing.Point(210, 36);
            this.tbQuilometragemCarro.Name = "tbQuilometragemCarro";
            this.tbQuilometragemCarro.Size = new System.Drawing.Size(88, 20);
            this.tbQuilometragemCarro.TabIndex = 5;
            // 
            // tbCapacidadeCarro
            // 
            this.tbCapacidadeCarro.Location = new System.Drawing.Point(113, 36);
            this.tbCapacidadeCarro.Name = "tbCapacidadeCarro";
            this.tbCapacidadeCarro.Size = new System.Drawing.Size(88, 20);
            this.tbCapacidadeCarro.TabIndex = 4;
            // 
            // tbDescricaoCarro
            // 
            this.tbDescricaoCarro.Location = new System.Drawing.Point(10, 36);
            this.tbDescricaoCarro.Name = "tbDescricaoCarro";
            this.tbDescricaoCarro.Size = new System.Drawing.Size(88, 20);
            this.tbDescricaoCarro.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quilometragem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Capacidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMoverAviao);
            this.groupBox2.Controls.Add(this.btCriarAviao);
            this.groupBox2.Controls.Add(this.tbHorasAviao);
            this.groupBox2.Controls.Add(this.tbCapacidadeAviao);
            this.groupBox2.Controls.Add(this.tbDescricaoAviao);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(13, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 93);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Avião";
            // 
            // btCriarAviao
            // 
            this.btCriarAviao.Location = new System.Drawing.Point(10, 63);
            this.btCriarAviao.Name = "btCriarAviao";
            this.btCriarAviao.Size = new System.Drawing.Size(75, 23);
            this.btCriarAviao.TabIndex = 6;
            this.btCriarAviao.Text = "Criar";
            this.btCriarAviao.UseVisualStyleBackColor = true;
            this.btCriarAviao.Click += new System.EventHandler(this.btCriarAviao_Click);
            // 
            // tbHorasAviao
            // 
            this.tbHorasAviao.Location = new System.Drawing.Point(210, 36);
            this.tbHorasAviao.Name = "tbHorasAviao";
            this.tbHorasAviao.Size = new System.Drawing.Size(88, 20);
            this.tbHorasAviao.TabIndex = 5;
            // 
            // tbCapacidadeAviao
            // 
            this.tbCapacidadeAviao.Location = new System.Drawing.Point(113, 35);
            this.tbCapacidadeAviao.Name = "tbCapacidadeAviao";
            this.tbCapacidadeAviao.Size = new System.Drawing.Size(88, 20);
            this.tbCapacidadeAviao.TabIndex = 4;
            // 
            // tbDescricaoAviao
            // 
            this.tbDescricaoAviao.Location = new System.Drawing.Point(10, 36);
            this.tbDescricaoAviao.Name = "tbDescricaoAviao";
            this.tbDescricaoAviao.Size = new System.Drawing.Size(88, 20);
            this.tbDescricaoAviao.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Horas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Capacidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Descrição";
            // 
            // btnMoverCarro
            // 
            this.btnMoverCarro.Location = new System.Drawing.Point(113, 63);
            this.btnMoverCarro.Name = "btnMoverCarro";
            this.btnMoverCarro.Size = new System.Drawing.Size(75, 23);
            this.btnMoverCarro.TabIndex = 7;
            this.btnMoverCarro.Text = "Mover";
            this.btnMoverCarro.UseVisualStyleBackColor = true;
            this.btnMoverCarro.Click += new System.EventHandler(this.btnMoverCarro_Click);
            // 
            // btnMoverAviao
            // 
            this.btnMoverAviao.Location = new System.Drawing.Point(113, 63);
            this.btnMoverAviao.Name = "btnMoverAviao";
            this.btnMoverAviao.Size = new System.Drawing.Size(75, 23);
            this.btnMoverAviao.TabIndex = 7;
            this.btnMoverAviao.Text = "Mover";
            this.btnMoverAviao.UseVisualStyleBackColor = true;
            this.btnMoverAviao.Click += new System.EventHandler(this.btnMoverAviao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 241);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Curso de POO com C#";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbQuilometragemCarro;
        private System.Windows.Forms.TextBox tbCapacidadeCarro;
        private System.Windows.Forms.TextBox tbDescricaoCarro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbHorasAviao;
        private System.Windows.Forms.TextBox tbCapacidadeAviao;
        private System.Windows.Forms.TextBox tbDescricaoAviao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btCriarCarro;
        private System.Windows.Forms.Button btCriarAviao;
        private System.Windows.Forms.Button btnMoverCarro;
        private System.Windows.Forms.Button btnMoverAviao;
    }
}

