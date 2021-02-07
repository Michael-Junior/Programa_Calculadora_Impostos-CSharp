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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();

        }

        private void TelaInicial(object sender, EventArgs e)
        {

        }

        private void ButtonIcms_Click(object sender, EventArgs e)
        {

        }

        private void ButtonIcmsSt_Click(object sender, EventArgs e)
        {

        }

        private void ButtonIcmsDifal_Click(object sender, EventArgs e)
        {

        }

        private void ButtonIpi_Click(object sender, EventArgs e)
        {

        }

        private void ButtonPis_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCofins_Click(object sender, EventArgs e)
        {

        }

        private void ButtonInicio_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Todos os valores serão apagados" + Environment.NewLine + "Deseja mesmo sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void ButtonSobre_Click(object sender, EventArgs e)
        {


        }

        private void TelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TelaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult FecharAplicacao = (MessageBox.Show("Os valores não serão salvos" + Environment.NewLine + "Deseja realmente sair do sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (FecharAplicacao == DialogResult.No)
                e.Cancel = true;
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}

