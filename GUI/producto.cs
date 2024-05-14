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
    public partial class frmProducto : Form
    {
        // Supongamos que tienes una instancia de GestorVentas
        private GestorVentas gestorVentas = new GestorVentas();

        public frmProducto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Crear un nuevo producto con los datos del formulario
            Producto producto = new Producto
            {
                Referencia = txtReferencia.Text,
                Nombre = txtNombre.Text,
                Existencias = int.Parse(txtCantidad.Text),
                PrecioUnitario = double.Parse(txtPrecioUni.Text),
                StockMinimo = int.Parse(txtStock.Text),
                Estado = cmbEstado.SelectedItem.ToString()
            };

            // Agregar el producto al gestor de ventas
            gestorVentas.AgregarProducto(producto);

            // Limpiar los campos del formulario
            txtReferencia.Text = "";
            txtNombre.Text = "";
            txtCantidad.Text = "";
            txtPrecioUni.Text = "";
            txtStock.Text = "";
            cmbEstado.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Limpiar los campos del formulario
            txtReferencia.Text = "";
            txtNombre.Text = "";
            txtCantidad.Text = "";
            txtPrecioUni.Text = "";
            txtStock.Text = "";
            cmbEstado.SelectedIndex = -1;
        }
    }
}

