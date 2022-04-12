using SwissTransport.Models;

namespace SwissTransportGUI
{
    public partial class MyTransportation : Form
    {
        public MyTransportation()
        {
            InitializeComponent();
        }

        private void MyTransportation_Load(object sender, EventArgs e)
        {
            this.timePicker.CustomFormat = "hh:mm";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.ShowUpDown = true;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                    dataGridView1.Rows.Add(einzelneverbindung.From.Station.Name, einzelneverbindung.To.Station.Name, Convert.ToDateTime(einzelneverbindung.From.Departure).ToString("MM-dd HH:mm"), Convert.ToDateTime(einzelneverbindung.To.Arrival).ToString("MM-dd HH:mm"), einzelneverbindung.To.Platform);
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
    }
}