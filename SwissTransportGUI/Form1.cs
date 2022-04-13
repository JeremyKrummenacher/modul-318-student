using SwissTransport.Core;
using SwissTransport.Models;

namespace SwissTransportGUI
{
    public partial class MyTransportation : Form
    {
        public MyTransportation()
        {
            InitializeComponent();
        }
        public ITransport transport = new Transport();


        private void MyTransportation_Load(object sender, EventArgs e)
        {
            this.timePicker.CustomFormat = "hh:mm";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.ShowUpDown = true;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            Stationssuche neueSuche = new Stationssuche();
            string von = vonComboBox.Text;
            string nach = nachComboBox.Text;
            DateTime zeitDatum = dateTimePicker1.Value;
            DateTime uhrzeit = timePicker.Value;

            Connections verbindungenreturns = neueSuche.StationVerbindungSuche(von, nach, zeitDatum, uhrzeit);
            try
            {
                List<Connection> verbindungrückgabliste = verbindungenreturns.ConnectionList;

                foreach (Connection einzelneverbindung in verbindungrückgabliste.Take(4))
                {
                    dataGridView1.Rows.Add(einzelneverbindung.From.Station.Name, einzelneverbindung.To.Station.Name, Convert.ToDateTime(einzelneverbindung.From.Departure).ToString("HH:mm"), Convert.ToDateTime(einzelneverbindung.To.Arrival).ToString("HH:mm"),einzelneverbindung.To.Delay, einzelneverbindung.To.Platform);
                }
            }
            catch
            {
                MessageBox.Show("Keine Verbindung gefunden");
                return;
            }
        }

        private void Vorschlage(object sender, EventArgs e)
        {
            try
            {
                vonComboBox.Items.Clear();

                Stationssuche neuesuche = new Stationssuche();

                List<Station> sucheresultat = neuesuche.Vorschlaege(vonComboBox.Text);
                try
                {
                    foreach (Station station in sucheresultat)
                    {
                        vonComboBox.Items.Add(station.Name);
                    }
                }
                catch { }
                vonComboBox.Focus();
                vonComboBox.SelectionStart = vonComboBox.Text.Length;
            }
            catch { return; }
        }

        private void VorschlageStation(object sender, EventArgs e)
        {
            try
            {
                stationcomboBox.Items.Clear();

                Stationssuche neuesuche = new Stationssuche();

                List<Station> sucheresultat = neuesuche.Vorschlaege(stationcomboBox.Text);
                try
                {
                    foreach (Station station in sucheresultat)
                    {
                        stationcomboBox.Items.Add(station.Name);
                    }
                }
                catch { }
                stationcomboBox.Focus();
                stationcomboBox.SelectionStart = stationcomboBox.Text.Length;
            }
            catch { return; }
        }

        private void VoerschlaegeNach(object sender, EventArgs e)
        {
            try
            {
                nachComboBox.Items.Clear();

                Stationssuche neuesuche = new Stationssuche();

                List<Station> sucheresultat = neuesuche.Vorschlaege(nachComboBox.Text);
                try
                {
                    foreach (Station station in sucheresultat)
                    {
                        nachComboBox.Items.Add(station.Name);
                    }
                }
                catch { }
                nachComboBox.Focus();
                nachComboBox.SelectionStart = nachComboBox.Text.Length;
            }
            catch { return; }
        }

        private void abfahrtensuchen_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            Stationssuche neueSuche = new Stationssuche();
            Stationssuche suchResultat = neueSuche.Abfahrtsplansuche(stationcomboBox.Text, neueSuche);

            try
            {
                StationBoardRoot alleVerbindungen = suchResultat.getVerbindungen();
                List<StationBoard> verbindungsliste = alleVerbindungen.Entries;

                foreach (StationBoard Ausgehendeverbindung in verbindungsliste)
                {
                    dataGridView2.Rows.Add(Ausgehendeverbindung.To, Ausgehendeverbindung.Category + Ausgehendeverbindung.Number, Ausgehendeverbindung.Operator);
                }
            }
            catch
            {
                MessageBox.Show("Keine Resultate gefunden!");
                return;
            }

        }

        private void aufkarteBtn_Click(object sender, EventArgs e)
        {
            Karte karte = new Karte(stationcomboBox.Text);
            karte.ShowDialog();
        }
    }
}