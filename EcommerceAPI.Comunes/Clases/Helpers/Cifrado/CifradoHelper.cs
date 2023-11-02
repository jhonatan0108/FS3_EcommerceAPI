namespace EcommerceAPI.Comunes.Clases.Helpers.Cifrado
{
    public static class CifradoHelper
    {
        ///Escriba una cadena

        public static string Encriptar(this string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encrytde = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encrytde);
            return result;
        }

        ///Esta función desencripta la cadena que le enviamos en el parámetro de entrada

        public static string Desencriptar(this string _cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decrytde = System.Text.Encoding.Unicode.GetBytes(_cadenaAdesencriptar);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decrytde);
            return result;
        }

    }
}
