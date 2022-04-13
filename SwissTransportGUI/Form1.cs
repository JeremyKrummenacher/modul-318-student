using SwissTransport.Core;
using SwissTransport.Models;
using System.Diagnostics;

namespace SwissTransportGUI
{
    public partial class MyTransportation : Form
    {
        public MyTransportation()
        {
            InitializeComponent();
            emailBtn.Enabled = false;
        }
        public ITransport transport = new Transport();
        public int anzeigeAnzahl = 4;
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

                foreach (Connection einzelneverbindung in verbindungrückgabliste.Take(anzeigeAnzahl))
                {
                    dataGridView1.Rows.Add(einzelneverbindung.From.Station.Name, einzelneverbindung.To.Station.Name, Convert.ToDateTime(einzelneverbindung.From.Departure).ToString("HH:mm"), Convert.ToDateTime(einzelneverbindung.To.Arrival).ToString("HH:mm"), einzelneverbindung.To.Platform);
                }
                emailBtn.Enabled = true;
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
            try
            {
                Station station = transport.GetStations(stationcomboBox.Text).StationList.First();
                Process.Start(new ProcessStartInfo { FileName = @"https://www.google.com/maps/search/?api=1&query=" + station.Coordinate.XCoordinate.ToString().Replace(",", ".") + "," + station.Coordinate.YCoordinate.ToString().Replace(",", "."), UseShellExecute = true });
            }
            catch { MessageBox.Show("keine Station gefunden"); }


        }

        private void emailBtn_Click(object sender, EventArgs e)
        {
            Email email = new Email();
            email.ShowDialog();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataIndexNo = dataGridView1.Rows[e.RowIndex].Index.ToString();
            string cellValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            MessageBox.Show("The row index = " + dataIndexNo.ToString() + " and the row data in second column is: "
                + cellValue.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void moreConnections_Click(object sender, EventArgs e)
        {
            int anzeige = anzeigeAnzahl + 4;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            Stationssuche neueSuche = new Stationssuche();
            string von = vonComboBox.Text;
            string nach = nachComboBox.Text;
            DateTime zeitDatum = dateTimePicker1.Value;
            DateTime uhrzeit = timePicker.Value;

            Connections verbindungenreturns = neueSuche.StationMehrVerbindungSuche(von, nach, zeitDatum, uhrzeit, anzeige);
            try
            {
                List<Connection> verbindungrückgabliste = verbindungenreturns.ConnectionList;

                foreach (Connection einzelneverbindung in verbindungrückgabliste)
                {
                    dataGridView1.Rows.Add(einzelneverbindung.From.Station.Name, einzelneverbindung.To.Station.Name, Convert.ToDateTime(einzelneverbindung.From.Departure).ToString("HH:mm"), Convert.ToDateTime(einzelneverbindung.To.Arrival).ToString("HH:mm"), einzelneverbindung.To.Platform);
                }
            }
            catch
            {
                MessageBox.Show("Keine Verbindung gefunden");
                return;
            }
        }
    }
}