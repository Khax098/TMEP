using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KacperStudennyLab1
{
    public class Resources
    {
        public Resources()
        {
            buildingLevel = 1;
            resourceAmount = 100;
        }
        // Obecny poziom budynku
        public UInt16 buildingLevel { get; set; }
        // Obecna ilość surowców
        public UInt64 resourceAmount { get; set; }


        /// <summary>
        /// Zwiększa przetrzymywany zasób o zadaną ilość 
        /// </summary>
        /// <param name="addedResource"></param>
        public void SetResourceAmount(UInt64 addedResource)
        {
            resourceAmount += addedResource;
        }


        /// <summary>
        /// Zwiększa poziom budynku o jeden
        /// </summary>
        /// <returns></returns>
        public void AddBuildingLevel()
        {
            ++buildingLevel;
        }


        /// <summary>
        /// Dokłada ilość przetrzymywanych zasobów 
        /// </summary>
        public virtual void ProduceResources()
        {
            // Ilość produkowanych zasobób na poziom budynku
            int producedResourcesPerLevel = 50;
            // Dodaje do spichlerza odpowiednią ilość surowcu
            resourceAmount += Convert.ToUInt64(producedResourcesPerLevel * buildingLevel);
        }
    }
}
