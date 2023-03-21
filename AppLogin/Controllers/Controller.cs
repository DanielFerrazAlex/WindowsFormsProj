using AppLogin.DAL;
using System;

namespace AppLogin.Controllers
{
    class Controller
    {
        public bool tem = false;
        public string menssagem = "";
        public bool Acesso(String login, String senha)
        {
            var LoginDao = new LoginDaoCommands();
            tem = LoginDao.VerificarLogin(login, senha);
            if (!LoginDao.menssagem.Equals(""))
            {
                this.menssagem = LoginDao.menssagem;
            }
            return tem;
        }
        public String cadastrar(String login, String senha, String email)
        {
            return menssagem;
        }
    }
}
