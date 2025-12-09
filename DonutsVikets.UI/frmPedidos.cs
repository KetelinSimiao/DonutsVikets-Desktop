using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DonutsVikets.Models;

namespace DonutsVikets.UI
{
    public partial class frmPedidos : Form
    {
        private int? produtoSelecionadoId = null;

        public frmPedidos()
        {
            InitializeComponent();
        }



        private void dgPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgPedidos
                    .Rows[e.RowIndex];

                produtoSelecionadoId = Convert.ToInt32(row.Cells["Id"].Value);
                txtDataPedido.Text = row.Cells["DataPedido"].Value.ToString();
                txtStatus.Text = row.Cells["Status"].Value.ToString();
               
            }
        }
    }
}
