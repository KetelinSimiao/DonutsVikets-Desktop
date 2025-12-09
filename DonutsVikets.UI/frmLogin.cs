using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DonutsVikets.BLL;
using DonutsVikets.DAL.Data;
using DonutsVikets.DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Project.BLL.Services;

namespace DonutsVikets.UI
{
    public partial class frmLogin : Form
    {
        private readonly UsuarioService _usuarioService;
       
        public frmLogin(UsuarioService usuarioService)
        {
            InitializeComponent();
            _usuarioService = usuarioService;
        }



        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = await _usuarioService.LoginAsync(txtEmail.Text, txtSenha.Text);
                Session.UsuarioLogado = usuario;

                var principal = Program.ServiceProvider.GetRequiredService<frnCategoria>();
                principal.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }




        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmUsuarios2 cadastrar = new frmUsuarios2();
            cadastrar.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

