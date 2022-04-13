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

        public Stationssuche Abfahrtsplansuche(string eingabestationsname, Stationssuche neuesuche)
        {
            try
            {
                var stationsobjekte = transport.GetStations(query: eingabestationsname);

                List<Station> stationen = stationsobjekte.StationList;

                foreach (Station bahnhof in stationen)
                {
                    if (bahnhof.Name.Equals(eingabestationsname))
                    {
                        neuesuche.stationname = bahnhof.Name;
                        neuesuche.stationId = bahnhof.Id;
                    }
                }

                StationBoardRoot stationsboard = transport.GetStationBoard(neuesuche.stationname, neuesuche.stationId);

                neuesuche.verbindungen = stationsboard;

                return neuesuche;
            }
            catch { return neuesuche; }
        }

        public Coordinate GetKoordinaten(string station)
        {
            var stationsobjekte = transport.GetStations(query: station);
            try
            {
                List<Station> stationen = stationsobjekte.StationList;

                foreach (Station bahnhof in stationen)//.Take(1))
                {
                    return bahnhof.Coordinate;
                }
            }
            catch { return null; }
            return null;
        }

        public StationBoardRoot getVerbindungen() { return verbindungen; }
    }
}
