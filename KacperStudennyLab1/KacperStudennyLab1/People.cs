using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KacperStudennyLab1
{
    public class People
    {
        public double workSpeedMultiplyer { get; set; }
        // Obecny Poziom budynku
        public uint buildingLevel { get; set; }
        // Obecna ilość surowców
        public uint peopleAmount { get; set; }
        //Nie pracujący obecnie
        public uint peopleAvailableToWork { get; set; }

        public People()
        {
            workSpeedMultiplyer = 0.1;
            buildingLevel = 1;
            peopleAmount = 50;
            peopleAvailableToWork = peopleAmount;
        }

        public double SpeedUpWork(int workersAmount)
        {
            return (workSpeedMultiplyer * workersAmount) + 1;
        }

        public void AddBuildingLevel()
        {
            uint newPeoplePerLevel = 30;
            ++buildingLevel;
            peopleAmount += newPeoplePerLevel;
        }

        public void AssignToWork(uint workersAmount)
        {
            if (workersAmount <= peopleAvailableToWork)
                peopleAvailableToWork -= workersAmount;
        }

    }
}
