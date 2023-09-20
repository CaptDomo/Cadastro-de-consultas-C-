using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmCadastroMedico : Form
    {
        public frmCadastroMedico()
        {
            InitializeComponent();
        }

        private void medicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro Salvo.", "Alerta", 
            MessageBoxButtons.OK, MessageBoxIcon.Information); 
            this.Validate();
            this.medicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultorioDataSet);

        }

        private void frmCadastroMedico_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'consultorioDataSet.Medico' table. You can move, or remove it, as needed.
            this.medicoTableAdapter.Fill(this.consultorioDataSet.Medico);

        }

        private void frmCadastroMedico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
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
    

