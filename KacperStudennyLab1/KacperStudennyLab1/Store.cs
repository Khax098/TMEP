using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KacperStudennyLab1
{
    class Store
    {
        // Służy do procentowego zwiększania kosztu rozbudowania budynku względem poprzedniego poziomu budynku
        readonly double increamentPercent = 1.4;
        // Początkowa wartość na starcie gry zasobów jakich potrzeba do rozbudowania budynku
        readonly int startingResourcesNeededToBuild = 100;

        // Zasoby osady
        private Resources wood = new Resources();
        private Resources people = new Resources();
        private Resources food = new Resources();
        private Resources soldiers = new Resources();
        private Resources gold = new Resources();

        /// <summary>
        /// Sprawdza czy jest odpowiednia ilość zasobów (drewno, ludzie, jedzenie) potrzebnych do rozbudowania budynku
        /// </summary>
        /// <param name="resources"></param>
        /// <returns></returns>
        public Boolean IsEnoughResources(Resources resources)
        {
            // Oblicza ilość potrzebnych zasobów do rozbudowy budynku na następny poziom
            UInt64 neededResourceAmount = Convert.ToUInt64( Math.Pow( increamentPercent, resources.GetBuildingLevel())*startingResourcesNeededToBuild);

            // Sprawdza czy wszystkich potrzebnych zasobów jest odpowienia ilość 
            if(wood.GetResourceAmount() >= neededResourceAmount &&
                people.GetResourceAmount() >=neededResourceAmount &&
                food.GetResourceAmount() >=neededResourceAmount)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Produkuje jednocześnie wszystkie zasoby jakie wytwarzane są z czasem
        /// </summary>
        public void ProduceResources()
        {
            wood.ProduceResources();
            food.ProduceResources();
            people.ProduceResources();
            gold.ProduceResources();
        }

        /// <summary>
        /// Zwraca obiekt Resources przetrzymujący obiekt związany z zasobem drewna
        /// </summary>
        /// <returns></returns>
        public Resources GetWood()
        {
            return wood;
        }

        /// <summary>
        /// Zwraca obiekt Resources przetrzymujący obiekt związany z zasobem ludzi
        /// </summary>
        /// <returns></returns>
        public Resources GetPeople()
        {
            return people;
        }

        /// <summary>
        /// Zwraca obiekt Resources przetrzymujący obiekt związany z zasobem jedzenia
        /// </summary>
        /// <returns></returns>
        public Resources GetFood()
        {
            return food;
        }

        /// <summary>
        /// Zwraca obiekt Resources przetrzymujący obiekt związany z zasobem żołnierzy
        /// </summary>
        /// <returns></returns>
        public Resources GetSoldiers()
        {
            return soldiers;
        }

        /// <summary>
        /// Zwraca obiekt Resources przetrzymujący obiekt związany z zasobem złota
        /// </summary>
        /// <returns></returns>
        public Resources GetGold()
        {
            return gold;
        }
    }
}
