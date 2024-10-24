using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormListaProveedores : Form
    {
        public FormListaProveedores()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormMantProveedor frm = new FormMantProveedor();
            frm.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormMantProveedor frm = new FormMantProveedor();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                frm.txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.txtnombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.txtapellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.txtdireccion.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.txttelefono.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                frm.ShowDialog();

            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
