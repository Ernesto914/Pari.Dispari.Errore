using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            
            InsNum.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            Button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            TipoNumero.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            Etichetta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(InsNum.Text, out int i))
            {
                TipoNumero.Text = "Errore";
                Button.BackColor = Color.Green;
            }
            else
            {
                if (i % 2 == 0)
                {
                    TipoNumero.Text = "Pari";
                    Button.BackColor = Color.Red;
                }
                else
                {
                    TipoNumero.Text = "Dispari";
                    Button.BackColor = Color.Azure;
                }
            }
        }
    }
}
