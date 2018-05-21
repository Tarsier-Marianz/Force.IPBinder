using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Force.IPBinder.Constants {
    public class BindingFile {
        public const string DatabaseFile = "Tarsier.Bindings.dll";
        public const string RegStartupKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
    }

    public class Messages {
        public const string EXIT = "Are you sure you want to exit application?";
        public const string REMOVE = "{0} network interface will permanently deleted in force binding!\nAre you sure you want to delete selected item in list?";
        public const string CLEAR = "All binded application to specific network interface will permanently deleted!\nAre you sure you want to delete all items in list?";
        public const string INVALID_IP = "IP Address {0} is not valid!. Please check your entered IP Address.";
        public const string EMPTY_IP = "Please provide IP Address to proceed force binding.";
        public const string EMPTY_EXE = "Please provide executable file of application to proceed force binding.";
    }
}
