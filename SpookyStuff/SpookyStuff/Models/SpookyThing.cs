using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpookyStuff.Models
{
    public class SpookyDecoration
    {
        [Key] public int Id { get; set; }
        [Required] public string Name { get; set; }
        public string Description { get; set; }
        public TraumaTypes Type { get; set; }
        public int TraumaIntensity { get; set; }
    }
}
