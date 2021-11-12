using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

/*
 AQUEST FITXER HAURIA DE ESTAR OCULT I L'IGNORARA EL GITIGNORE <3  
*/

namespace Connexio
{
    public  class Decrypt
    {
        const string PathFitxer = "./Key.txt";
        const string PathClau = "./private.xml";
        public static string DecryptFile(){
            RSACryptoServiceProvider rsa;

            String fileString = File.ReadAllText(PathClau);
            rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(fileString);

            byte[] text = File.ReadAllBytes(PathFitxer);
            byte[] Decrypted = rsa.Decrypt(text,false);

            return System.Text.Encoding.UTF8.GetString(Decrypted); 
        }
    }



    
}



/* Per tornar a encriptar la clau publica

            String fileString = File.ReadAllText(PathClauPublica);
            rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(fileString);
            byte[] text =File.ReadAllBytes(PathFitxer);
            byte[] keyEncrypted = rsa.Encrypt(text, false);
            File.WriteAllBytes(PathFitxer,keyEncrypted);
            const string PathClauPublica = "./public.xml";

*/