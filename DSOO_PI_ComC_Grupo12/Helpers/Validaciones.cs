using System.Text.RegularExpressions;

namespace DSOO_PI_ComC_Grupo12.Helpers
{
    internal static class Validaciones
    {
        public static bool EmailValido(string email)
        {
            string patronEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, patronEmail);
        }

        public static bool CamposVacios(params string[] campos)
        {
            foreach (var campo in campos)
            {
                if (string.IsNullOrWhiteSpace(campo))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
