using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpookyStuff.Models
{
    public class Supplies
    {
        public int Id { get; set; }
        public TraumaTypes TraumaTypes { get; set; }
        public string Name { get; set; }
        public string Beschrijving { get; set; }
    }
}
