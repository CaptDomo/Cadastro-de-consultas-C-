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
    public partial class frmCadastroPaciente : Form
    {
        public frmCadastroPaciente()
        {
            InitializeComponent();
        }

        private void frmCadastroPaciente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void pacienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro Salvo.", "Alerta",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Validate();
            this.pacienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultorioDataSet);

        }

        private void frmCadastroPaciente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'consultorioDataSet.Paciente' table. You can move, or remove it, as needed.
            this.pacienteTableAdapter.Fill(this.consultorioDataSet.Paciente);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deletar registro?", "Confirmação",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar a resposta do usuário.
            if (resultado == DialogResult.Yes)
            {
                Console.WriteLine(bindingNavigatorDeleteItem);
            }
            else
            {
                Close();
            }
        }
    }
}
