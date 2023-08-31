using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace D2.net
{
    public class Televisore
    {
        private bool Stato { get; set; }
        private int Volume { get; set; }
        private int Canale { get; set; }
        private bool MuteMode { get; set; }
        public Televisore(bool s= false, int v, int c, bool m = false) 
        {
            this.Stato = s; 
            this.Volume = v;
            this.Canale = c;
            this.MuteMode = m;
        }
        public bool pulsanteAccensione() 
        {
            this.Stato = true; return this.Stato;
        }
        public int canaleSuccessivo()
        {
            this.Canale++; return this.Canale;
        }
        public int canalePrecedente()
        {
            this.Canale--; return this.Canale;
        }
        public int aumentoVolume ()
        {
            this.Volume++; return this.Volume;
        }
        public int abbassaVolume() 
        {
            this.Volume--; return this.Volume;
        }
        public int impostaCanale(int c)
        {
            this.Canale= c; return this.Canale;
        }
        public string printStatoTV()
        {
            return this.Stato.ToString() + this.Canale + this.Volume + this.MuteMode;
        }
        public bool pulsanteSilenzioso()
        {
            this.MuteMode = true; return this.MuteMode;
        }
    }
}
