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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormMantProveedor : Form
    {
        ProveedorService Service;
        public event Action ProveedorModificado;
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

            if (!Validar())
            {
                MessageBox.Show("Por favor revisar los datos");
            }
            else
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

        }
        private bool Validar()
        {
            txtEmail.Text = txtEmail.Text.Trim();
            if (!Regex.IsMatch(txtIDProveedor.Text, @"^\d{7,12}$") || (txtIDProveedor.Text == ""))
            {
                MessageBox.Show("El ID debe ser numérico y tener entre 7 y 12 dígitos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var tiposID = new[] { "TI", "CC", "TE", "CE" };
            if (!tiposID.Contains(txtTipoID.Text))
            {
                MessageBox.Show("El tipo de ID debe ser TI, CC, TE o CE.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(txtNombre.Text, @"^[a-zA-ZñÑáéíóúÁÉÍÓÚ\s]+$") || (txtNombre.Text == ""))
            {
                MessageBox.Show("El nombre debe contener solo letras.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error); return false;
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$") || (txtEmail.Text == ""))
            {
                MessageBox.Show("Por favor, ingresa un email válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                MessageBox.Show("Por favor revisar los datos");
            }
            else
            {
                var proveedor = new Proveedor
                {
                    IDProveedor = txtIDProveedor.Text,
                    TipoID = txtTipoID.Text,
                    Nombre = txtNombre.Text,
                    Telefono = double.Parse(txtTelefono.Text),
                    Email = txtEmail.Text
                };
                var mensaje = Service.Actualizar(proveedor);
                MessageBox.Show(mensaje);
                ProveedorModificado?.Invoke(); 
            }
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}