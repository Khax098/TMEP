using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KacperStudennyLab1
{
    public partial class FormMain : Form
    {

        FormEvent formEvent;
        FormBuilding formBuild;
        // Zasoby Osady
        Store store = new Store();
        // Licznik dni do przybycia wikingów
        int daysCounter = 400;
        // Klasa umożliwiająca puszczenie muzyki
        System.Media.SoundPlayer soundPlayer;


        public FormMain()
        {
            InitializeComponent();
            //soundPlayer = new System.Media.SoundPlayer(Path.Combine(Environment.CurrentDirectory, @"Music\", fileName
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Startuje timer
            timerGame.Start();
            //soundPlayer.Play(); PlayLooping
        }

        /// <summary>
        /// Obrazek bydynku, po kliknieciu którego można go rozbudować w środku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxWoodcutter_Click(object sender, EventArgs e)
        {
            
            // Cała metoda jest do przebudowania: MA wyświetlać FORM z rozbudową placówki
            // store.GetWood().SetBuildingLevel();
            // labelTestWood.Text = Convert.ToString(store.GetWood().GetBuildingLevel());
            FormBuilding formBuilding = new FormBuilding();
            //formBuilding;
            formBuilding.ShowDialog();

        }

        private void LabelTestWood_Click(object sender, EventArgs e)
        {

        }

        private void TimerGame_Tick(object sender, EventArgs e)
        {
            // Długość jednego dnia w grze
            timerGame.Interval = 2000;
            // Zwiększa licznik przeżytych dni w grze
            ++daysCounter;
            // Produkowanie zasobów po upływie dnia
            store.ProduceResources();

            // Aktualizowanie tabel z danym o ilości surowców
            // Dopisać dla reszty zasobów
            labelWood.Text = Convert.ToString(store.GetWood().GetResourceAmount());


        }
    }
}
