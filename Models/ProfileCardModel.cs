using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Checker.Models
{
    public class ProfileCardModel
    {
        public byte[] Image { get; set; } 
        public string Occupation { get; set; }
        public string HomeAddress { get; set; }
        public string Country { get; set; }
        public string County { get; set; }
    }
}