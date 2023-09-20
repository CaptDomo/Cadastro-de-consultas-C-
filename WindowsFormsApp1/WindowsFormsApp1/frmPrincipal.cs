using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void toolCadMed_Click(object sender, EventArgs e)
        {
            frmCadastroMedico Cmedico = new frmCadastroMedico();
            Cmedico.ShowDialog();
            
        }

        private void toolCadpaciente_Click(object sender, EventArgs e)
        {
            frmCadastroPaciente Cpaciente = new frmCadastroPaciente();
            Cpaciente.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmConsultas cConsulta = new frmConsultas();
            cConsulta.ShowDialog();
        }
    }
}
