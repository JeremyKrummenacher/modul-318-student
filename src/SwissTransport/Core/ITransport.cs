namespace SwissTransport.Core
{
    using System.Threading.Tasks;
    using SwissTransport.Models;

    public interface ITransport
    {
        Stations GetStations(string query);

        StationBoardRoot GetStationBoard(string station, string id);

        Connections GetConnections(string fromStation, string toStation, string Date, string time);

        Connections GetMoreConnections(string fromStation, string toStation, string Date, string time, int anzahl);
    }
}