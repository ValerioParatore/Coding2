using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EsercizioExtra
{
    public class Appartamenti
    {
        public int Vani { get; set; }
        public bool terrazzoGiardino { get; set; }
        public string TipoAppartamento { get; set; }
        public int MetriQ { get; set; }
        public string Zona { get; set; }
        public Appartamenti() { }
        public Appartamenti(int vani, bool giardinoOterrazza, string tipoAppartamento, int metriQ, string zona)
        {
            Vani = vani;
            terrazzoGiardino = giardinoOterrazza;
            TipoAppartamento = tipoAppartamento;
            MetriQ = metriQ;
            Zona = zona;

        }



    }

}
