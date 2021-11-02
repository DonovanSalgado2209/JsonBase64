using System;
using System.Collections.Generic;
using System.Text;

namespace JsonBase64.Helpers
{
    public static class Base64Encrypter
    {
        public static string Encriptar(string dato)
        {
            string result = string.Empty;
            if (!string.IsNullOrEmpty(dato))
            {
                byte[] byteArray = Encoding.UTF8.GetBytes(dato);
                result = Convert.ToBase64String(byteArray);
            }

            return result;
        }
    }
}
