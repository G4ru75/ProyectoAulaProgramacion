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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormMantProductos frm = new FormMantProductos();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                frm.txttid.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.textDescripcion.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.textCategoria.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.textPrecio.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.textStock.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                frm.ShowDialog();

            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormVenta frm = Owner as FormVenta;
            frm.txttid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.textDescripcion.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.textCategoria.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.textPrecio.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.textStock.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            this.Close();   
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }
    }
    }

