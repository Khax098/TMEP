using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KacperStudennyLab1
{
    public partial class FormBuilding : Form
    {
        public Store store;
        public Resources resource;
        public Gold gold;

        public FormBuilding()
        {
            InitializeComponentDefault();
            labelValueIncome.Text = "";
            labelBuildingLvl.Text = "";
        }

        public FormBuilding(Store storeGiven, Resources resourcesGiven)
        {
            InitializeComponentDefault();
            store = storeGiven;
            resource = resourcesGiven;
            labelValueIncome.Text = "";
            labelBuildingLvl.Text = "";
            //LabelResourcesStatus.Text = Convert.ToString(resource.resourceAmount) + "/"
            //    + Convert.ToString(resource.resourceAmount * resource.buildingLevel);
        }

        public FormBuilding(Store storeGiven, Gold resourcesGiven)
        {
            InitializeComponentDefault();
            store = storeGiven;
            gold = resourcesGiven;
            labelValueIncome.Text = "";
            labelBuildingLvl.Text = "";
            //LabelResourcesStatus.Text = Convert.ToString(resource.resourceAmount) + "/"
            //    + Convert.ToString(resource.resourceAmount * resource.buildingLevel);
        }

        private void LabelResourcesStatus_Click(object sender, EventArgs e)
        {

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonIncrement_Click(object sender, EventArgs e)
        {
            if (store.IsEnoughResources(resource))
            {
                store.TakeUsedResources(resource);
                resource.AddBuildingLevel();
            }
            else
                MessageBox.Show("Niewystarczająca ilość zasobów");
        }

        private void FormBuilding_Load(object sender, EventArgs e)
        {
            timerFPS.Interval = 200;
            timerFPS.Start();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void LabelValueIncome_Click(object sender, EventArgs e)
        {

        }

        private void TimerFPS_Tick_1(object sender, EventArgs e)
        {
            labelValueIncome.Text = Convert.ToString(resource.buildingLevel*50);
            labelBuildingLvl.Text = Convert.ToString(resource.buildingLevel);
        }
    }
}
