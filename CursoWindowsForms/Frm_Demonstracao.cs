using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Demonstracao : Form
    {
        public Frm_Demonstracao()
        {
            InitializeComponent();
        }

        private void Txt_Imput_KeyDown(object sender, KeyEventArgs e)
        {
            Txt_Msg.AppendText("\r\n" + " Precione uma tecla: " + e.KeyCode + "\r\n");
            Txt_Msg.AppendText("\t" + " Código da tecla: " +((int)e.KeyCode) + "\r\n");
            Txt_Msg.AppendText("\t" + " Nome da tecla: " + e.KeyData + "\r\n");
           Lbl_Lower.Text = e.KeyCode.ToString().ToLower();
            Lbl_Upper.Text = e.KeyCode.ToString().ToUpper();
        }

        private void Txt_Imput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Msg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
