using System;
using System.Security.Cryptography;
using System.Text;

namespace Domain.Entities.Security
{
    public class Hash
    {
        public Hash() { }

        public string VerifyPassword(string typedPassword)
        {
                SHA512 Algorithm = SHA512.Create();
            
                if (string.IsNullOrEmpty(typedPassword))
                {
                    throw new NullReferenceException("Digite a sua senha de acesso!");
                }


                byte[] inputBytes = Encoding.UTF8.GetBytes(typedPassword);
                byte[] hash = Algorithm.ComputeHash(inputBytes);

                StringBuilder builder = new StringBuilder();
                foreach (var character in hash)
                {
                    builder.Append(character.ToString("x2"));
                }
                return builder.ToString();
            }
           
           
        
    }
}
