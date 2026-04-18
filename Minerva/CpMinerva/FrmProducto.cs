using ClnMinerva;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpMinerva
{
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void listar()
        {
            dgvLista.DataSource = ProductoCln.listarPa(txtParametro.Text);
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["idUnidadMedida"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            Size = new Size(915, 347);
            listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Size = new Size(915, 484);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Size = new Size(915, 484);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(915, 347);
        }
    }
}
