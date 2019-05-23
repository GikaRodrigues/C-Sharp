namespace Ex2.Utils
{
    public class ValidacaoUtil
    {
        
        public static bool ValidarEmail(string email){
            if (email.Contains("@") && email.Contains("."))
            {
                return true;
            }
            return false;
        }

        public static bool ValidarSenha(string senha){
            if (senha.Length > 4){
                return true;
            }
            return false;
        }
    }
}