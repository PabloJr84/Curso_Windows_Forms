namespace CursoWindowsForms
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Btn_ModicaLabel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Location = new System.Drawing.Point(954, 521);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.Btn_Sair.TabIndex = 1;
            this.Btn_Sair.Text = "Sair";
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Btn_ModicaLabel
            // 
            this.Btn_ModicaLabel.Location = new System.Drawing.Point(15, 78);
            this.Btn_ModicaLabel.Name = "Btn_ModicaLabel";
            this.Btn_ModicaLabel.Size = new System.Drawing.Size(138, 23);
            this.Btn_ModicaLabel.TabIndex = 2;
            this.Btn_ModicaLabel.Text = "Modifica Texto do  Label";
            this.Btn_ModicaLabel.UseVisualStyleBackColor = true;
            this.Btn_ModicaLabel.Click += new System.EventHandler(this.Btn_ModicaLabel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(12, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(196, 18);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Visual Studio .NET Version";
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 556);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btn_ModicaLabel);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.lbl_Titulo);
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Button Btn_ModicaLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_Titulo;
    }
}

