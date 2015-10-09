using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpookyStuff.Models
{
    public class Scenario
    {
        [Key] public int Id { get; set; }
        [Required] public string Name { get; set; }
        public int SuppliesId { get; set; }

        public virtual SupplyList SuppliesNeeded
        {
            get
            {
                return suppliesNeeded;
            }

            set
            {
                SuppliesId = value.Id;
                suppliesNeeded = value;
            }
        }

        private SupplyList suppliesNeeded { get; set; }
    }
}
