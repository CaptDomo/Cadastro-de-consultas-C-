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
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
        }

        private void frmConsultas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void consultaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro Salvo.", "Alerta",
           MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Validate();
            this.consultaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultorioDataSet);

        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'consultorioDataSet.Paciente' table. You can move, or remove it, as needed.
            this.pacienteTableAdapter.Fill(this.consultorioDataSet.Paciente);
            // TODO: This line of code loads data into the 'consultorioDataSet.Medico' table. You can move, or remove it, as needed.
            this.medicoTableAdapter.Fill(this.consultorioDataSet.Medico);
            // TODO: This line of code loads data into the 'consultorioDataSet.Consulta' table. You can move, or remove it, as needed.
            this.consultaTableAdapter.Fill(this.consultorioDataSet.Consulta);

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

        private void hORA_INICIODateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
