using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asd_laba_3
{
    internal class Lines
    {
        public int ID { get; set; }
        public string Value { get; set; }
        public Lines(int ID, string Value) 
        {
            this.ID = ID;
            this.Value = Value;
        }
        public override string ToString()
        {
            return $"{ID} {Value}";
        }
    }
}
