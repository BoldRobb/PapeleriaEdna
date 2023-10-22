using DataAccess;
namespace Negocio
{
    public class UsuarioModel
    {
        UsuarioDao userDao = new UsuarioDao();
        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
        }
    }
}