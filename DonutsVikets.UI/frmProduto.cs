using System;
using DonutsVikets.Models;
using Project.BLL.Services;

namespace DonutsVikets.UI
{
    public partial class frmProduto : Form
    {
        CategoriaService categoriaBLL = new CategoriaService();
        public string categoria { get; private set; }

        public frmProduto()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }



        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var produto = new Produto()
            {
                Nome = txtNome.Text,
                Descricao = txtDescricao.Text,
                Preco = Convert.ToDecimal(txtPreco.Text),
                categoria = cboCategoria.SelectedItem as Categoria
            };

            produto.CadastrarProduto(produto);

            MessageBox.Show($"Produto {produto.Nome} cadastrado com sucesso!");

            // Limpar os campos
            txtNome.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtPreco.Text = string.Empty;
            cboCategoria.SelectedValue = string.Empty;
        }


        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            var categoria = categoriaBLL.GetAllAsync();

            // Define o DataSource
            cboCategoria.DataSource = categoria;
            cboCategoria.DisplayMember = "Descricao";
            cboCategoria.ValueMember = "Id";

            // Opcional: adiciona um placeholder
            cboCategoria.SelectedIndex = -1;
            cboCategoria.Text = "Selecione o tipo";
        }
    }

}


