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
    public partial class TelaPrincipal2 : Form
    {
        private object menuStrip1;

        public TelaPrincipal2()
        {
            InitializeComponent();
        }

        private void TelaPrincipal2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult FecharAplicacaoX = (MessageBox.Show("Os valores não serão salvos!" + Environment.NewLine + "Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (FecharAplicacaoX == DialogResult.No)
                e.Cancel = true;
        }

        private void TelaPrincipal2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            DialogResult SfecharAplicacao = (MessageBox.Show("Os valores não serão salvos!" + Environment.NewLine + "Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (SfecharAplicacao == DialogResult.Yes)
                System.Environment.Exit(1);
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            FrmSobre a = new FrmSobre();
            a.MdiParent = this;
            a.Show();
        }

        private void TelaPrincipal2_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI;

            foreach (Control ctl in this.Controls)
            {
                try
                {
                    ctlMDI = (MdiClient)ctl;

                    //ctlMDI.BackColor = System.Drawing.Color.LightSkyBlue;
                    ctlMDI.BackgroundImage = Properties.Resources.BackImages;
                    menuStrip1 = true;

                }
                catch (InvalidCastException exc)
                {

                }

            }


        }
    }
}
