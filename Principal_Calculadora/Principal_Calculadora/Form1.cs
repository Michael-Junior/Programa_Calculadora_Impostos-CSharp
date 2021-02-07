using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal_Calculadora
{
    public partial class TelaPRINCIPAL : Form
    {
        public TelaPRINCIPAL()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(TelaINICIAL);
        }

        private void TelaINICIAL(object sender, EventArgs e)
        {

        }

        private void buttonICMS_Click(object sender, EventArgs e)
        {

        }

        private void buttonICMSST_Click(object sender, EventArgs e)
        {

        }

        private void buttonICMSDIFAL_Click(object sender, EventArgs e)
        {

        }

        private void buttonIPI_Click(object sender, EventArgs e)
        {

        }

        private void buttonPIS_Click(object sender, EventArgs e)
        {

        }

        private void buttonCOFINS_Click(object sender, EventArgs e)
        {

        }

        private void buttonINICIO_Click(object sender, EventArgs e)
        {

        }

        /*private void buttonSAIR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Todos os valores serão apagados" + Environment.NewLine + "Deseja mesmo sair? ", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }*/



        
        private void buttonSOBRE_Click(object sender, EventArgs e)
        {

        }

        private void FecharTela(object sender, CancelEventArgs e)
        {
            if (MessageBox.Show("Deseja Encerrar a Aplicação?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }



    }
}

