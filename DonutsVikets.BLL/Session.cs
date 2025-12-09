using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DonutsVikets.Models;

namespace DonutsVikets.BLL
{
    public class Session
    {
        public static Usuario UsuarioLogado { get; set; }

        private static string _user;

        public static string user
        {
            get { return Session._user; }
            set { Session._user = value; }
        }
    }
}

