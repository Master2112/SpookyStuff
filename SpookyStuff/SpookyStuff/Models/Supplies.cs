using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpookyStuff.Models
{
    public class SupplyList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Beschrijving { get; set; }

        public SpookyDecoration[] Decorations { get; set; }

        public TraumaTypes TraumaType
        {
            get
            {
                float totalAmount = 0;
                int count = 0;

                foreach(SpookyDecoration deco in Decorations)
                {
                    count++;
                    totalAmount += (float)deco.TraumaIntensity;
                }

                totalAmount /= count;
                return (TraumaTypes)((int)Math.Round(totalAmount));
            }
        }
    }
}
