using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul8_103022300123
{
    internal class confirmation
    {
        public string en { get; set; }
        public string id { get; set; }

        public confirmation() { }
        public confirmation(string en, string id) {
            this.en = en;
            this.id = id;
        }
    }
}
