using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class NameGamer : Form
    {
        public NameGamer()
        {
            InitializeComponent();
        }

        private void TextBoxName__TextChanged(object sender, EventArgs e)
        {
            if(TextBoxName.Texts.Length != 0)
            {
                ButtonOk.Enabled = true;
            }
            else
            {
                ButtonOk.Enabled = false;
            }
        }

        private void TextBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        public string Nume { get; private set; }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            Nume = TextBoxName.Texts;
            this.Close();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
