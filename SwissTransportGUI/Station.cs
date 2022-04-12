using SwissTransport;
using SwissTransport.Core;
using SwissTransport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissTransportGUI
{
    class Stationssuche
    {
        private ITransport transport = new Transport();
        private string stationname;
        private string stationId;
        private StationBoardRoot verbindungen;

        public Connections StationVerbindungSuche(string von, string nach, DateTime datum, DateTime uhrzeit)
        {
            string datumstring = datum.ToString("yyyy-MM-dd");
            string zeitstring = uhrzeit.ToString("HH:mm");
            Connections verbindungen = transport.GetConnections(von, nach, datumstring, zeitstring);
            return verbindungen;
        }
        public List<Station> Vorschlaege(string texteingabe)
        {
            try
            {
                var stationsobjekte = transport.GetStations(query: texteingabe);

                List<Station> stationenvorschlaege = stationsobjekte.StationList;

                return stationenvorschlaege;
            }
            catch { return null; }
        }
    }
}
