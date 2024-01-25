using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppVezhba
{
    public class DenOdSedmica:Notifier
    {
        private int _id;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }

        private int _den;
        public int Den
        {
            get
            {
                return _den;
            }
            set
            {
                _den = value;
                OnPropertyChanged("Den");
            }
        }

        private DateTime _datum;
        public DateTime Datum
        {
            get
            {
                return _datum;
            }
            set
            {
                _datum = value;
                OnPropertyChanged("Datum");
            }
        }

        private DayOfWeek _dow;
        public DayOfWeek Dow
        {
            get
            {
                return _dow;
            }
            set
            {
                _dow = value;
                OnPropertyChanged("Dow");
            }
        }

        private OdrabotenoVremePoZadacha _odrabotenoVreme;
        public OdrabotenoVremePoZadacha OdrabotenoVreme
        {
            get
            {
                return _odrabotenoVreme;
            }
            set
            {
                _odrabotenoVreme = value;
                OnPropertyChanged("OdrabotenoVreme");
            }
        }

        /**
         * Odraboteno vreme vo chasovi
         */
        private ObservableCollection<OdrabotenoVremePoZadacha> _listaIzborZaOdrabotenoVreme;
        public ObservableCollection<OdrabotenoVremePoZadacha> ListaIzborZaOdrabotenoVreme
        {
            get
            {
                return _listaIzborZaOdrabotenoVreme;
            }
            set
            {
                _listaIzborZaOdrabotenoVreme = value;
                OnPropertyChanged("ListaIzborZaOdrabotenoVreme");
            }
        }

        public DenOdSedmica(int id, DateTime datum)
        {
            Id = id;
            Datum = datum;
            Den = datum.Day;
            Dow = datum.DayOfWeek;
            ListaIzborZaOdrabotenoVreme = Utils.napolniListaIzborZaOdrabotenoVreme();
            OdrabotenoVreme = ListaIzborZaOdrabotenoVreme[0];
        }
    }
}
