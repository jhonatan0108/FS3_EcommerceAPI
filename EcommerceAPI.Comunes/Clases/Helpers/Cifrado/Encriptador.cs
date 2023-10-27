using System.Security.Cryptography;
using System.Text;

namespace EcommerceAPI.Comunes.Clases.Helpers.Cifrado
{
    public class Encriptador
    {
        /// <summary>
        /// Genera un salt aleatorio unico de 16 bytes para usarlo al momento de encriptar contraseñas
        /// </summary>
        /// <returns>Array de 16 bytes que contiene el salt</returns>
        private static byte[] GenerateRandomSalt()
        {
            // Crear un generador criptografico de numeros aleatorios
            // Se usa el "using" para evitar que el recurso quede abierto 
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                // Crear un array de 16 bytes para guardar el salt
                byte[] salt = new byte[16];

                // Genero bytes aleatorios para llenar el array
                rng.GetBytes(salt);

                // Se regresa el array
                return salt;
            }
        }

        /// <summary>
        /// El metodo combina una contraseña (string) y un salt (array de bytes aleatorios)
        /// para agregar seguridad extra entes de encriptar la contraseña
        /// </summary>
        /// <param name="password">Contraseña a combinar on el salt</param>
        /// <param name="salt">Array de bytes aleatorios</param>
        /// <returns></returns>
        private static byte[] CombineSaltAndPassword(string password, byte[] salt)
        {
            // Convertir el password a bytes usando codificacion UTF-8.
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            // Crear un array para guardar la contraseña con el salt, la longitud es la suma de las dos longitudes
            byte[] saltedPasswordBytes = new byte[passwordBytes.Length + salt.Length];

            //Copiar la contraseña en bytes al array donde se guardara con el salt, offset de 0 para copiar todo
            // BlockCopy(Array src, int srcOffset, Array dst, int dstOffset, int count)
            Buffer.BlockCopy(passwordBytes, 0, saltedPasswordBytes, 0, passwordBytes.Length);

            // Copiar el salt en bytes al array donde se guardara con el salt, offset de 0 para copiar todo
            Buffer.BlockCopy(salt, 0, saltedPasswordBytes, passwordBytes.Length, salt.Length);

            // Convertir el array de bytes que tiene la contraseña y el salt, a un string con codificacion Base64
            return saltedPasswordBytes;
        }

        /// <summary>
        /// El metodo toma un array de bytes que contiene una contraseña y un salt combinados
        /// aplica al algoritmo SHA-256 para encriptarlos y lo regresa como un string
        /// </summary>
        /// <param name="saltedPasswordBytes">Array de bytes que contiene la combinacion de la contraseña y el salt</param>
        /// <returns>String de la contraseña con salt y encriptacion (hash)</returns>
        private static string HashPassword(byte[] saltedPasswordBytes)
        {
            // Crear una instancia de el algoritmo de hashing SHA-256.
            using (SHA256 sha256 = SHA256.Create())
            {
                // Generar el hash de la contraseña combinada con el salt usando SHA-256.
                byte[] hashBytes = sha256.ComputeHash(saltedPasswordBytes);

                // Convertir el hash a un string, removiendo los guiones (-) para simplificar el proceso de comparacion
                return BitConverter.ToString(hashBytes).Replace("-", string.Empty);
            }
        }

        /// <summary>
        /// El metodo toma una contraseña ingresada por el usuario, la encripta y regresa el salt unico
        /// junto con la contraseña encriptada para almacenarlos en al base de datos
        /// </summary>
        /// <param name="password">Contraseña ingresada por el usuario</param>
        /// <returns>Una tupla de valores que tiene la constraseña encriptada y el array de bytes de el salt</returns>
        public static (string, byte[]) EncryptPassword(string password)
        {
            byte[] salt = GenerateRandomSalt();

            byte[] saltedPassword = CombineSaltAndPassword(password, salt);

            return (HashPassword(saltedPassword), salt);
        }

        /// <summary>
        /// Metodo utilizado para el inicio de sesion, comparando la contraseña encriptada de la base de datos
        /// </summary>
        /// <param name="inputPassword">Contraseña ingresada por el usuario</param>
        /// <param name="storedPassword">Contraseña encriptada guardada en la base de datos</param>
        /// <param name="storedSalt">Salt de 16 bytes guardado en la base de datos (uncio por cada usuario)</param>
        /// <returns></returns>
        public static bool ComparePasswords(string inputPassword, string storedPassword, byte[] storedSalt)
        {
            //Combinar la contraseña ingresada con el salt guardado en la base de datos
            byte[] saltedPassword = CombineSaltAndPassword(inputPassword, storedSalt);

            // Encriptar la contraseña con salt usando Hash
            string hashedPassword = HashPassword(saltedPassword);

            // Comparar el hash guardado con el que se genero con base al input del usuario
            if (hashedPassword == storedPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
