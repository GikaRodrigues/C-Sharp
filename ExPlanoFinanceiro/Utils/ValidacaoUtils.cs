namespace Ex2.Utils
{
    public class ValidacaoUtil
    {
        
        public static bool ValidarEmail(string email){
            if (email.Contains("@") && email.Contains("."))
            {
                return true;
            }else
            {
                System.Console.WriteLine("O E-mail deve conter @ e .");
            }
            return false;
        }

        public static bool ValidarSenha(string senha){
            if (senha.Length > 4){
                return true;
            }else{
                System.Console.WriteLine("A senha deve conter mais de 4 digitos");
            }
            return false;
        }
    }
}