using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKR_PATTERNS
{
    class Recipient
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public Recipient(string name, string code)
        {
            Name = name;
            Code = code;

        }
    }
}
