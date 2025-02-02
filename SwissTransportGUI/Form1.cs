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
            btnVerbindungAnzeigen.Enabled = true;
            emailBtn.Enabled = false;
            aufkarteBtn.Enabled = false;
            moreConnections.Enabled = false;
            this.MinimumSize = new Size(870, 300);
            
        }
        public ITransport transport = new Transport();
        public int anzeigeAnzahl = 4;
        List<Connection> emailList = new List<Connection>();
        private void MyTransportation_Load(object sender, EventArgs e)
        {
            this.timePicker.CustomFormat = "hh:mm";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.ShowUpDown = true;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnVerbindungenAnzeigen_Click(object sender, EventArgs e)
        {
            if (vonComboBox.Text != "" && nachComboBox.Text != "")
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
                    List<Connection> verbindungrueckgabliste = verbindungenreturns.ConnectionList;

                    foreach (Connection einzelneverbindung in verbindungrueckgabliste.Take(anzeigeAnzahl))
                    {
                        dataGridView1.Rows.Add(einzelneverbindung.From.Station.Name, einzelneverbindung.To.Station.Name, Convert.ToDateTime(einzelneverbindung.From.Departure).ToString("HH:mm"), Convert.ToDateTime(einzelneverbindung.To.Arrival).ToString("HH:mm"), einzelneverbindung.To.Platform);
                    }
                    emailBtn.Enabled = true;
                    emailList = verbindungrueckgabliste;
                    moreConnections.Enabled = true;

                }
                catch
                {
                    MessageBox.Show("Keine Verbindung gefunden");
                    return;
                }
            }
            else { MessageBox.Show("inkorrekte Eingabe"); }
            
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
                /*if (vonComboBox.DroppedDown == false)
                {
                    vonComboBox.DroppedDown = true;
                }*/
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
            if(stationcomboBox.Text != "")
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
                    aufkarteBtn.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Keine Resultate gefunden!");
                    return;
                }
            }
            else { MessageBox.Show("inkorrekte Eingabe"); }
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
            string emailBody = "";

            foreach (Connection verbindungrueckgabliste in emailList)
            {
                string row = verbindungrueckgabliste.From.Station.Name + "|" + verbindungrueckgabliste.To.Station.Name + "|" + Convert.ToDateTime(verbindungrueckgabliste.From.Departure).ToString("HH:mm") + "/";
                emailBody += row;
            }
            Email email = new Email(emailBody);
            email.ShowDialog();
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
                List<Connection> verbindungr�ckgabliste = verbindungenreturns.ConnectionList;

                foreach (Connection einzelneverbindung in verbindungr�ckgabliste)
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView3.Rows.Clear();
                List<Station> stations = transport.GetNearestStations().StationList;

                foreach (Station station in stations)
                {
                    dataGridView3.Rows.Add(station.Name, station.Distance + "m");
                }
            }
            catch
            {
                MessageBox.Show("Nearest Station Finder", "Error while trying to fetch nearest stations");
            }
        }
    }
}