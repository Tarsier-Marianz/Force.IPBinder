using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarsier.Extensions {
     public static class ObjectsUtils {
        public static string SerializeT<T>(this T objToSerialize) {
            return JsonConvert.SerializeObject(objToSerialize);
        }

        public static T DeserializeT<T>(this string toDeserialize) {
            if(String.IsNullOrEmpty(toDeserialize)) {
                return default(T); ;
            }
            return (T)JsonConvert.DeserializeObject<T>(toDeserialize);
        }
    }
}
