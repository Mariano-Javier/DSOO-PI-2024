using DSOO_PI_ComC_Grupo12.Repositories;
using DSOO_PI_ComC_Grupo12.Models;
using System;
using System.Windows.Forms;

namespace DSOO_PI_ComC_Grupo12.Controllers
{
    public class LoginController
    {
        private readonly AutenticacionRepository _autenticacionRepository;

        public LoginController()
        {
            _autenticacionRepository = new AutenticacionRepository();
        }

        public Empleado AutenticarUsuario(string usuario, string contrasenia)
        {
            return _autenticacionRepository.AutenticarUsuario(usuario, contrasenia);
        }

        public void HandleLogin(string usuario, string contrasenia, Action<Empleado> onSuccess, Action onFailure)
        {
            try
            {
                Empleado empleado = AutenticarUsuario(usuario, contrasenia);
                if (empleado != null)
                {
                    onSuccess(empleado);
                }
                else
                {
                    onFailure();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
