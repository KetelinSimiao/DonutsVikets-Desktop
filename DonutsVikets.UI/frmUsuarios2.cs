using DonutsVikets.DAL.Data;
using DonutsVikets.DAL.Repositories;
using DonutsVikets.DTOs;
using Microsoft.EntityFrameworkCore;
using Project.BLL.Services;
using System.Data;

namespace DonutsVikets.UI
{
    public partial class frmUsuarios2 : Form
    {
        private DonutsVikets3Context _context;
        private UsuarioRepository _usuarioRepo;
        private UsuarioService _usuarioService;

        public frmUsuarios2()
        {
            InitializeComponent();
            SetupDependencies();
        }

        private void SetupDependencies()
        {
            var options = new DbContextOptionsBuilder<DonutsVikets3Context>()
                .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DonutsVikets3Context;Trusted_Connection=True;")
                .Options;

            _context = new DonutsVikets3Context(options);
            _context.Database.EnsureCreated();

            _usuarioRepo = new UsuarioRepository(_context);
            _usuarioService = new UsuarioService(_usuarioRepo);
        }

        private async void frmUsuarios2_Load(object sender, EventArgs e)
        {
            await CarregarTiposUsuarioAsync();

        }

        private async Task CarregarTiposUsuarioAsync()
        {
            var tipos = await _context.TipoUsuarios.AsNoTracking().ToListAsync();
            cmbTipoUsuario.DataSource = tipos;
            cmbTipoUsuario.DisplayMember = "Nome";
            cmbTipoUsuario.ValueMember = "Id";
        }










        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                var dto = new UsuarioDTO
                {
                    Nome = txtNome.Text,
                    Email = txtEmail.Text,
                    Senha = txtSenha.Text,
                    TipoUsuarioId = (int)cmbTipoUsuario.SelectedValue
                };

                var (success, message) = await _usuarioService.CreateAsync(dto);

                if (success)
                {
                    MessageBox.Show($"Usuário {dto.Nome} cadastrado com sucesso!");
                    txtNome.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtSenha.Text = string.Empty;
                    cmbTipoUsuario.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show($"Erro: {message}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}");
            }
        }

    }
}
