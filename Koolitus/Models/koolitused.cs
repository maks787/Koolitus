using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Koolitus.Models
{
    public class koolitused
    {
        public int id { get; set; }
        public string Koolitusnimetus { get; set; }
        public string Koolituskirjeldus { get; set; }
        public int Opetajaid { get; set; }
        public int koolitusehind { get; set; }
        public int koolitusemaht { get; set; }
    }
}