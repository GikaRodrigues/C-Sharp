namespace AplicativoFInanceiro.Utils {
    public class ValidacaoUtil {
        /// <summary>Retornar true caso o email possua @ e .static e false se  não possuir</summary>
        public static bool ValidarEmail (string email) {
            if (email.Contains ("@") && email.Contains (".")) {
                return true;
            }else
            {
                System.Console.WriteLine("O E-mail deve conter @ e .");
            }
            return false;
        }

        /// <summary>Retorna true caso as senhas sejam iguais e contenha mais de 6 caracteres ou false caso catrario.</summary>
        public static bool ConfirmacaoSenha (string senha, string confirmaSenha) {
            if (senha.Equals (confirmaSenha) && senha.Length > 4) {
                return true;
            }else{
                System.Console.WriteLine("A senha deve ter mais que 4 digitos");
            }
            return false;
        }
        
    }
}
