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
        // Zasoby Osady
        public Store store { get; set; }
        // Licznik dni do przybycia wikingów
        public int daysCounter { get; set; }
        // Klasa umożliwiająca puszczenie muzyki
        //System.Media.SoundPlayer soundPlayer;


        public FormMain()
        {
            InitializeComponent();
            //PictureBoxWoodcutter.Parent = ImageBackground;
            //PictureBoxWoodcutter.BackColor = Color.Transparent;
            //PictureBoxWoodcutter.Location = (,);
            //soundPlayer = new System.Media.SoundPlayer(Path.Combine(Environment.CurrentDirectory, @"Music\", fileName
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Długość jednego dnia w grze
            timerGame.Interval = 2000;
            // Szybkość odświerzania obrazu
            timerFPS.Interval = 200;
            // Startuje timery
            timerFPS.Start();
            timerGame.Start();

            // Tworzę zawartość wszystkich surowców w magazynie
            store = new Store();

            // Dni do przybycia wikingów
            daysCounter = 400;
            //soundPlayer.Play(); PlayLooping
        }

        /// <summary>
        /// Obrazek bydynku, po kliknieciu którego można go rozbudować w środku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxWoodcutter_Click(object sender, EventArgs e)
        {
            FormBuilding formBuilding = new FormBuilding(store, store.wood);
            formBuilding.ShowDialog();
        }

        private void UpdateResourceLabels()
        {
            labelWood.Text = Convert.ToString(store.wood.resourceAmount);
            labelSteel.Text = Convert.ToString(store.steel.resourceAmount);
            labelPeople.Text = Convert.ToString(store.people.resourceAmount);
            labelSoldiers.Text = Convert.ToString(store.soldiers.resourceAmount);
            labelGold.Text = Convert.ToString(store.gold.resourceAmount);
        }

        private void TimerGame_Tick(object sender, EventArgs e)
        {
            // Zmniejszanie licznik dni do przybycia wikingów
            --daysCounter;

            // Produkowanie zasobów po upływie dnia
            store.ProduceResources();
            // Aktualizowanie tabel z danym o ilości surowców
        }

        private void TimerFPS_Tick(object sender, EventArgs e)
        {
            UpdateResourceLabels();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxCastle_Click(object sender, EventArgs e)
        {
            FormBuilding formBuilding = new FormBuilding(store, store.gold);
            formBuilding.ShowDialog();
        }
    }
}
