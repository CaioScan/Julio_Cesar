using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Newtonsoft.Json;

namespace verificaCNPJ
{
    public class Atualizar
    {
        public static void PegaInformacoes()
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("https://api.codenation.dev/v1/challenge/dev-ps/generate-data?token=2c7f4adfe2e51bd54772a8fd0aa0e124867206fe");
            webRequest.Method = "GET";
            webRequest.UserAgent = "MSIE 6.0";
            webRequest.Credentials = CredentialCache.DefaultCredentials;

            try
            {
                HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
                var streamDados = response.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
                object objResponse = reader.ReadToEnd();

                var Get = Newtonsoft.Json.JsonConvert.DeserializeObject<Get>(objResponse.ToString());

                var decifrado = Decipher(Get.cifrado, Get.numero_casas);
                
                var resumo_criptografico = Hash(decifrado);

                Get.decifrado = decifrado.ToString();
                Get.resumo_criptografico = resumo_criptografico.ToString();

                string Arquivo = JsonConvert.SerializeObject(Get);

                string folder = @"D:\Desenvolvimento\";
                // Filename  
                string fileName = "answer.json";
                // Fullpath. You can direct hardcode it if you like.  
                string fullPath = folder + fileName;

                File.WriteAllText(fullPath, Arquivo);
                // Read a file  
                string readText = File.ReadAllText(fullPath);
                Console.WriteLine(readText);

            }
            catch (WebException we)
            {
                var responseStatus = ((HttpWebResponse)we.Response).StatusCode;
                Console.WriteLine(responseStatus);
            }

        }

        #region "Helpers"
        public static char cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {

                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);


        }

        public static string Encipher(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += cipher(ch, key);

            return output;
        }

        public static string Decipher(string input, int key)
        {
            return Encipher(input, 26 - key);
        }

        static string Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder();

                foreach (byte b in hash)
                {
                    
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }

        #endregion
    }
}
