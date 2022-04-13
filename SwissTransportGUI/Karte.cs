using SwissTransport.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransportGUI
{
    public partial class Karte : Form
    {
        public Karte(string stationkombobox)
        {
            InitializeComponent();
            station = stationkombobox;
        }
        private string station;
        private double xKo;
        private double yKo;


        public void SetKoordinaten(Coordinate value)
        {
            try
            {
                xKo = (double)value.XCoordinate;
                yKo = (double)value.YCoordinate;

            }
            catch
            {
                MessageBox.Show("Falsche eingabe");
                return;
            }
        }
        private void Karte_Load(object sender, EventArgs e)
        {
            Stationssuche neuesuche = new Stationssuche();
            SetKoordinaten(neuesuche.GetKoordinaten(station));
            

        }
    }
}
