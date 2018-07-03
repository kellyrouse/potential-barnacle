using System;

namespace Helpers {
    public class StringHelper {
        public static string encodeB64( string txt ) {
            byte[] encodedBytes = System.Text.Encoding.UTF8.GetBytes( txt );
            string encodedTxt = Convert.ToBase64String( encodedBytes );
            return encodedTxt;
        }

        public static string decodeB64( string b64string ) {
            byte[] decodedBytes = Convert.FromBase64String(Convert.ToBase64String(System.Text.Encoding.Unicode.GetBytes(b64string)));
            string decodedTxt = System.Text.Encoding.UTF8.GetString(decodedBytes);
            // string decodedTxt2 = System.Text.Encoding.Unicode.GetString(decodedBytes);
            return decodedTxt;
        }
    }
}

