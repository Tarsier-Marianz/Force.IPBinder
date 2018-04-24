using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Force.IPBinder.Models {
   public class BindingIP {
        public int ID { get; set; }
        public string Description { get; set; }
        public string IPAddress { get; set; }
        public string Path { get; set; }
        public int AutoBind { get; set; }
        public string Code { get; set; }
    }
}
