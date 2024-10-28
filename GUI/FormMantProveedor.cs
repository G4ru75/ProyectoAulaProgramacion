using ENTITY;
using ProyectoAula;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormMantProveedor : Form
    {
        ProveedorService Service;
        public FormMantProveedor()
        {
            InitializeComponent();
            Service = new ProveedorService();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCerrar1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnguardar_Click(object sender, EventArgs e)
        {
            var proveedor = new Proveedor
            {
                IDProveedor = txtIDProveedor.Text,
                TipoID = txtTipoID.Text,
                Nombre = txtNombre.Text,
                Telefono = double.Parse(txtTelefono.Text),
                Email = txtEmail.Text
            }; 
            var mensaje = Service.Guardar(proveedor);
            MessageBox.Show(mensaje);
            Limpiar(); 

        }

        private void Limpiar()
        {
            txtIDProveedor.Text = "";
            txtTipoID.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = ""; 
        }
        private void FormMantProveedor_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
