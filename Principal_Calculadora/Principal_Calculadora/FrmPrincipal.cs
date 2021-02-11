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
        string pasta_aplicacao = "";

        public TelaPrincipal()

        {
            
            InitializeComponent();
            pasta_aplicacao = Application.StartupPath + @"\";

            MessageBox.Show(pasta_aplicacao + @"images\Image_calc_imp.png"); ;
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
            var Form1 = new FrmInicial();
            Form1.MdiParent = this;
            Form1.Show();
        }

        private void ButtonSair_Click(object sender, EventArgs e)
        {
            DialogResult SfecharAplicacao = (MessageBox.Show("Os valores não serão salvos" + Environment.NewLine + "Deseja realmente sair do sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (SfecharAplicacao == DialogResult.Yes)
                System.Environment.Exit(1);
        }

        private void TelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TelaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult FecharAplicacaoX = (MessageBox.Show("Os valores não serão salvos" + Environment.NewLine + "Deseja realmente sair do sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (FecharAplicacaoX == DialogResult.No)
                e.Cancel = true;
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(pasta_aplicacao + @"images\Image_calc_imp.png");
        }

        private void ButtonSobre_Click(object sender, EventArgs e)
        {
            var Form1 = new FrmSobre();
            Form1.MdiParent = this;
            Form1.Show();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

