using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KacperStudennyLab1
{
    class Resources
    {
        // Obecny poziom budynku
        private short buildingLevel = 1;
        // Obecna ilość surowców
        private UInt64 resourceAmount = 100;

        /// <summary>
        /// Geter dla zmiennej zasobów 
        /// </summary>
        /// <returns></returns>
        public UInt64 GetResourceAmount()
        {
            return resourceAmount;
        }

        /// <summary>
        /// Zwiększa przetrzymywany zasób o zadaną ilość 
        /// </summary>
        /// <param name="addedResource"></param>
        public void SetResourceAmount(UInt64 addedResource)
        {
            resourceAmount += addedResource;
        }

        /// <summary>
        /// Zwraca obecny poziom budynku
        /// </summary>
        /// <returns></returns>
        public short GetBuildingLevel()
        {
            return buildingLevel;
        }

        /// <summary>
        /// Zwiększa poziom budynku o jeden
        /// </summary>
        /// <returns></returns>
        public void SetBuildingLevel()
        {
            ++buildingLevel;
        }

        /// <summary>
        /// Dokłada ilość przetrzymywanych zasobów 
        /// </summary>
        public void ProduceResources()
        {
            // Ilość produkowanych zasobób na poziom budynku
            int producedResourcesPerLevel = 50;
            // Dodaje do spichlerza odpowiednią ilość surowcu
            resourceAmount += Convert.ToUInt64(producedResourcesPerLevel * buildingLevel);
        }
    }
}
