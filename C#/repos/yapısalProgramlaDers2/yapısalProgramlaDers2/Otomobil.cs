using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yapısalProgramlaDers2
{
    class Otomobil
    {
        public string Marka { get; set; } 
        public string Model { get; set; }
        public string Plaka { get; set; }
        public bool TramerVarmı { get; set; }
        public bool Sıfırmı { get; set; }
        public int ModelYılı { get; set; }
        public double km { get; set; }
        public double Fiyat { get; set; }

        public Otomobil(string _Marka,string _Model)
        {
            this.Marka = _Marka;
            this.Model = _Model;
        }
        public Otomobil(string _Marka,string _Model,bool dogrumu)
        {
            if (dogrumu)  { this.Marka = _Marka; }
            else
            {
                this.Model = _Model;
            }
        }
        public Otomobil(string _marka)
        {
            Marka = _marka;
        }
        public Otomobil(string _model)
        {
            Model = _model;
        }
        public Otomobil()
        {
        }
        public Otomobil(string _Model,string _Marka,string _plaka,int _modelYılı,bool _tramerVarmı,bool _sıfırMı,double _km,double _Fİyat)
        {
            this.Model = _Model;
            this.Marka = _Marka;
            this.Plaka = _plaka;
            this.ModelYılı = _modelYılı;
            this.TramerVarmı = _tramerVarmı;
            this.Sıfırmı = _sıfırMı;
            this.km = _km;
            this.Fiyat = _Fİyat;
        }
        public  override string  ToString()
        {
            return $"ozellikler Model:{Model}";
        }    
        
    }
}
