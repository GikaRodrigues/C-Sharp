namespace Aula1.Utils
{
    public class ValidacaoUtil
    {
        /// <sumary>Retornar true caso o email possua @ e .static e false se nao possuir<sumary>
        public static bool ValidarEmail(string email){
            if (email.Contains("@") && email.Contains(".")){
                return true;              
            }
            return false;
        }


        public static bool ConfirmacaoSenha(string senha, string ConfirmaSenha){
            if (senha.Equals(ConfirmaSenha) && senha.Length > 6){
                return true;
            }
            return false;
        }
    }
}