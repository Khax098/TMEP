using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KacperStudennyLab1
{
    public class Store
    {
        // Służy do procentowego zwiększania kosztu rozbudowania budynku względem poprzedniego poziomu budynku
        public readonly double increamentPercent = 1.4;
        // Początkowa wartość na starcie gry zasobów jakich potrzeba do rozbudowania budynku
        public readonly int startingResourcesNeededToBuild = 100;

        // Zasoby osady
        public Resources wood { get; set; }
        public People people { get; set; }
        public Resources steel { get; set; }
        public Resources soldiers { get; set; }
        public Gold gold { get; set; }

        public Store()
        {
            wood = new Resources();
            people = new People();
            steel = new Resources();
            soldiers = new Resources();
            gold = new Gold();
        }

        /// <summary>
        /// Sprawdza czy jest odpowiednia ilość zasobów (drewno, ludzie, jedzenie) potrzebnych do rozbudowania budynku
        /// </summary>
        /// <param name="resources"></param>
        /// <returns></returns>
        public Boolean IsEnoughResources(Resources resources)
        {
            // Oblicza ilość potrzebnych zasobów do rozbudowy budynku na następny poziom
            UInt64 neededResourceAmount = NeddedResourceAmount(resources);

            // Sprawdza czy wszystkich potrzebnych zasobów jest odpowienia ilość 
            if (wood.resourceAmount >= neededResourceAmount &&
                gold.resourceAmount >= neededResourceAmount &&
                steel.resourceAmount >= neededResourceAmount)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Zwraca ilość materiałów potrzebnych do rozbudowy budynku na tym poziomie
        /// </summary>
        /// <param name="resources"></param>
        /// <returns></returns>
        public UInt64 NeddedResourceAmount(Resources resources)
        {
            return Convert.ToUInt64(Math.Pow(increamentPercent, resources.buildingLevel) * startingResourcesNeededToBuild);
        }

        public void ProduceResources()
        {
            wood.ProduceResources();
            steel.ProduceResources();
            gold.ProduceResources(people);
        }

        public void TakeUsedResources(Resources resources)
        {
            wood.resourceAmount -= NeddedResourceAmount(resources);
            steel.resourceAmount-= NeddedResourceAmount(resources);
            gold.resourceAmount -= NeddedResourceAmount(resources);
        }
    }
}


