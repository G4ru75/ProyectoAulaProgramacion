﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using ENTITY;
using ProyectoAula;

namespace GUI
{
    public partial class FormListaProveedores : Form
    {
        ProveedorService Service;
        public FormListaProveedores()
        {
            InitializeComponent();
            Service = new ProveedorService();
            Service.ProveedorGuardado += ProveedorGuardado;
            CargarDatos();
        }  
        private void CargarDatos()
        {
            TablaProveedores.Rows.Clear();
            var proveedores = Service.Consultar();
            foreach (var proveedor in proveedores)
            {
                TablaProveedores.Rows.Add(proveedor.IDProveedor, proveedor.TipoID, proveedor.Nombre, proveedor.Telefono, proveedor.Email);
            }
        }

        private void ProveedorGuardado(Proveedor proveedor)
        {
            TablaProveedores.Rows.Add(proveedor.IDProveedor, proveedor.TipoID ,proveedor.Nombre, proveedor.Telefono, proveedor.Email);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormMantProveedor frm = new FormMantProveedor();
            frm.ShowDialog();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormMantProveedor frm = new FormMantProveedor();
            if (TablaProveedores.SelectedRows.Count > 0)
            {
                Insertar(); 
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
        private void Insertar()
        {
            FormMantProveedor frm = new FormMantProveedor();
            frm.txtIDProveedor.Text = TablaProveedores.CurrentRow.Cells[0].Value.ToString();
            frm.txtTipoID.Text = TablaProveedores.CurrentRow.Cells[1].Value.ToString();
            frm.txtNombre.Text = TablaProveedores.CurrentRow.Cells[2].Value.ToString();
            frm.txtTelefono.Text = TablaProveedores.CurrentRow.Cells[3].Value.ToString();
            frm.txtEmail.Text = TablaProveedores.CurrentRow.Cells[4].Value.ToString();

            frm.ProveedorModificado += RefrescarDataGridView;
            frm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormListaProveedores_Load(object sender, EventArgs e)
        {
            RefrescarDataGridView();
        }

        private void RefrescarDataGridView()
        {
            TablaProveedores.Rows.Clear();
            Service.RefrescarLista();
            var proveedores = Service.Consultar();
            foreach (var proveedor in proveedores)
            {
                TablaProveedores.Rows.Add(proveedor.IDProveedor, proveedor.TipoID, proveedor.Nombre, proveedor.Telefono, proveedor.Email);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
