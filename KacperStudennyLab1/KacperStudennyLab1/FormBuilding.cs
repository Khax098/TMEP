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
        private Store store;
        private Resources resource;
        public FormBuilding()
        {
            InitializeComponent();
        }

        public FormBuilding(Store storeGiven)
        {
            //InitializeComponent();
            store = storeGiven;
        }

        private void LabelResourcesStatus_Click(object sender, EventArgs e)
        {
            //LabelResourcesStatus.Text = Convert.ToString(resources.GetResourceAmount());
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonIncrement_Click(object sender, EventArgs e)
        {
            //if()
        }

        private void FormBuilding_Load(object sender, EventArgs e)
        {

        }
    }
}
