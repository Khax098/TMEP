using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KacperStudennyLab1
{
    public class Gold
    {
        // Obecny poziom budynku
        public UInt16 buildingLevel { get; set; }
        // Obecna ilość surowców
        public UInt64 resourceAmount { get; set; }
        // Podatki
        public uint taxes { get; set; }

        public Gold()
        {
            buildingLevel = 1;
            resourceAmount = 100;
            taxes =  1;
        }

        public void ProduceResources(People people)
        {
            // Ilość produkowanych zasobób na poziom budynku
            uint producedResourcesPerLevel = people.peopleAmount;
            // Dodaje do spichlerza odpowiednią ilość surowcu
            resourceAmount += Convert.ToUInt64(producedResourcesPerLevel * buildingLevel * 0.5 * taxes);
        }

    }
}
