using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tarsier.Extensions;

namespace Force.IPBinder.Helpers {
    public class Validator {
        public static bool CheckIPValid(string strIPAddress) {
            string[] arrOctets = strIPAddress.Split('.');
            if(arrOctets.Length != 4)
                return false;
            foreach(string strOctet in arrOctets) {
                if(strOctet.Length > 3) //to return false if 0000, 000001
                    return false;
                int i = strOctet.ToSafeInteger();
                if((i < 0) || (i > 255))
                    return false;
            }
            return true;
        }
    }
}