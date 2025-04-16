using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul8_103022300123
{
    internal class config
    {
        public string lang { get; set; }
        public transfer transfer { get; set; }
        public List<string> methods { get; set; }
        public confirmation confirmation { get; set; }

        public config() { }
        public config(string lang, transfer transfer, List<string> methods, confirmation confirmation) {
            this.lang = lang;
            this.transfer = transfer;
            this.methods = methods;
            this.confirmation = confirmation;
        }
    }
}
