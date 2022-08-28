namespace CursoWindowsForms
{
    partial class Frm_Demonstracao
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
            this.Txt_Imput = new System.Windows.Forms.TextBox();
            this.Txt_Msg = new System.Windows.Forms.TextBox();
            this.Btn_Rest = new System.Windows.Forms.Button();
            this.Lbl_Minus = new System.Windows.Forms.Label();
            this.Lbl_Maius = new System.Windows.Forms.Label();
            this.Lbl_Upper = new System.Windows.Forms.Label();
            this.Lbl_Lower = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_Imput
            // 
            this.Txt_Imput.Location = new System.Drawing.Point(8, 8);
            this.Txt_Imput.Name = "Txt_Imput";
            this.Txt_Imput.Size = new System.Drawing.Size(100, 20);
            this.Txt_Imput.TabIndex = 0;
            this.Txt_Imput.TextChanged += new System.EventHandler(this.Txt_Imput_TextChanged);
            this.Txt_Imput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Imput_KeyDown);
            // 
            // Txt_Msg
            // 
            this.Txt_Msg.Location = new System.Drawing.Point(8, 40);
            this.Txt_Msg.Multiline = true;
            this.Txt_Msg.Name = "Txt_Msg";
            this.Txt_Msg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txt_Msg.Size = new System.Drawing.Size(304, 232);
            this.Txt_Msg.TabIndex = 1;
            this.Txt_Msg.TabStop = false;
            this.Txt_Msg.TextChanged += new System.EventHandler(this.Txt_Msg_TextChanged);
            // 
            // Btn_Rest
            // 
            this.Btn_Rest.Location = new System.Drawing.Point(328, 8);
            this.Btn_Rest.Name = "Btn_Rest";
            this.Btn_Rest.Size = new System.Drawing.Size(75, 28);
            this.Btn_Rest.TabIndex = 2;
            this.Btn_Rest.Text = "Limpa";
            this.Btn_Rest.UseVisualStyleBackColor = true;
            this.Btn_Rest.Click += new System.EventHandler(this.Btn_Rest_Click);
            // 
            // Lbl_Minus
            // 
            this.Lbl_Minus.AutoSize = true;
            this.Lbl_Minus.Location = new System.Drawing.Point(320, 104);
            this.Lbl_Minus.Name = "Lbl_Minus";
            this.Lbl_Minus.Size = new System.Drawing.Size(38, 13);
            this.Lbl_Minus.TabIndex = 3;
            this.Lbl_Minus.Text = "Minus.";
            // 
            // Lbl_Maius
            // 
            this.Lbl_Maius.AutoSize = true;
            this.Lbl_Maius.Location = new System.Drawing.Point(320, 56);
            this.Lbl_Maius.Name = "Lbl_Maius";
            this.Lbl_Maius.Size = new System.Drawing.Size(38, 13);
            this.Lbl_Maius.TabIndex = 4;
            this.Lbl_Maius.Text = "Maius.";
            // 
            // Lbl_Upper
            // 
            this.Lbl_Upper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Upper.Location = new System.Drawing.Point(368, 56);
            this.Lbl_Upper.Name = "Lbl_Upper";
            this.Lbl_Upper.Size = new System.Drawing.Size(32, 23);
            this.Lbl_Upper.TabIndex = 5;
            // 
            // Lbl_Lower
            // 
            this.Lbl_Lower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Lower.Location = new System.Drawing.Point(368, 104);
            this.Lbl_Lower.Name = "Lbl_Lower";
            this.Lbl_Lower.Size = new System.Drawing.Size(32, 23);
            this.Lbl_Lower.TabIndex = 6;
            // 
            // Frm_Demonstracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 281);
            this.Controls.Add(this.Lbl_Lower);
            this.Controls.Add(this.Lbl_Upper);
            this.Controls.Add(this.Lbl_Maius);
            this.Controls.Add(this.Lbl_Minus);
            this.Controls.Add(this.Btn_Rest);
            this.Controls.Add(this.Txt_Msg);
            this.Controls.Add(this.Txt_Imput);
            this.Name = "Frm_Demonstracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demonstração Evento Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Imput;
        private System.Windows.Forms.TextBox Txt_Msg;
        private System.Windows.Forms.Button Btn_Rest;
        private System.Windows.Forms.Label Lbl_Minus;
        private System.Windows.Forms.Label Lbl_Maius;
        private System.Windows.Forms.Label Lbl_Upper;
        private System.Windows.Forms.Label Lbl_Lower;
    }
}