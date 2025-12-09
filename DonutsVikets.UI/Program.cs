using Microsoft.Extensions.DependencyInjection;
using DonutsVikets.DAL.Data;
using DonutsVikets.DAL.Repositories;
using Project.BLL.Services;

namespace DonutsVikets.UI
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            // Configura os serviços
            services.AddDbContext<DonutsVikets3Context>();
            services.AddScoped<UsuarioRepository>();
            services.AddScoped<UsuarioService>();
            services.AddScoped<CategoriaRepository>();
            services.AddScoped<CategoriaService>();

            // Adiciona os formulários
            services.AddScoped<frmLogin>();
            services.AddScoped<frnCategoria>();
            services.AddScoped<frmProduto>();

            ServiceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();

            // Inicia com o formulário de login
            var loginForm = ServiceProvider.GetRequiredService<frmLogin>();
            Application.Run(loginForm);
        }
    }
}
