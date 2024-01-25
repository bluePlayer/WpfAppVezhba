using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppVezhba
{
    public class Sedmica:Notifier
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
        // TODO bi trebalo da bide nekakov status kod, ba bojata da se odreduva od nego.
        private System.Windows.Media.Brush _bojaVreme;
        public System.Windows.Media.Brush BojaVreme
        {
            get
            {
                return _bojaVreme;
            }
            set
            {
                _bojaVreme = value;
                OnPropertyChanged("BojaVreme");
            }
        }

        public int RbrSedmicaVoGodina
        {
            get
            {
                return Utils.redenBrojNaSedmicaVoGodina(Ponedelnik.Datum);
            }
        }

        public string RbrSedmicaVoGodinaTxt
        {
            get
            {
                return RbrSedmicaVoGodina.ToString() + " / " + Utils.brojNaSedmiciVoGodina(Godina);
            }
        }

        private int _godina;
        public int Godina
        {
            get
            {
                return _godina;
            }
            set
            {
                _godina = value;
                OnPropertyChanged("Godina");
            }
        }

        private string _mesec;
        public string Mesec
        {
            get
            {
                return _mesec;
            }
            set
            {
                _mesec = value;
                OnPropertyChanged("Mesec");
            }
        }

        private bool _dozvolenVnes;
        public bool DozvolenVnes
        {
            get
            {
                return _dozvolenVnes;
            }
            set
            {
                _dozvolenVnes = value;
                OnPropertyChanged("DozvolenVnes");
            }
        }

        private DateTime _denes;
        public DateTime Denes
        {
            get
            {
                return _denes;
            }
            set
            {
                _denes = value;
                OnPropertyChanged("Denes");
            }
        }

        private DenOdSedmica _ponedelnik;
        public DenOdSedmica Ponedelnik
        {
            get
            {
                return _ponedelnik;
            }
            set
            {
                _ponedelnik = value;
                OnPropertyChanged("Ponedelnik");
            }
        }

        private DenOdSedmica _vtornik;
        public DenOdSedmica Vtornik
        {
            get
            {
                return _vtornik;
            }
            set
            {
                _vtornik = value;
                OnPropertyChanged("Vtornik");
            }
        }

        private DenOdSedmica _sreda;
        public DenOdSedmica Sreda
        {
            get
            {
                return _sreda;
            }
            set
            {
                _sreda = value;
                OnPropertyChanged("Sreda");
            }
        }

        private DenOdSedmica _chetvrtok;
        public DenOdSedmica Chetvrtok
        {
            get
            {
                return _chetvrtok;
            }
            set
            {
                _chetvrtok = value;
                OnPropertyChanged("Chetvrtok");
            }
        }

        private DenOdSedmica _petok;
        public DenOdSedmica Petok
        {
            get
            {
                return _petok;
            }
            set
            {
                _petok = value;
                OnPropertyChanged("Petok");
            }
        }

        private DenOdSedmica _sabota;
        public DenOdSedmica Sabota
        {
            get
            {
                return _sabota;
            }
            set
            {
                _sabota = value;
                OnPropertyChanged("Sabota");
            }
        }

        private DenOdSedmica _nedela;
        public DenOdSedmica Nedela
        {
            get
            {
                return _nedela;
            }
            set
            {
                _nedela = value;
                OnPropertyChanged("Nedela");
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

        private ObservableCollection<OdrabotenoVremePoZadacha> _listaIzborZaOdrabotenoVremeSedmica;
        public ObservableCollection<OdrabotenoVremePoZadacha> ListaIzborZaOdrabotenoVremeSedmica
        {
            get
            {
                return _listaIzborZaOdrabotenoVremeSedmica;
            }
            set
            {
                _listaIzborZaOdrabotenoVremeSedmica = value;
                OnPropertyChanged("ListaIzborZaOdrabotenoVremeSedmica");
            }
        }

        private OdrabotenoVremePoZadacha _odrabotenoVremeSedmica;
        public OdrabotenoVremePoZadacha OdrabotenoVremeSedmica
        {
            get
            {
                return _odrabotenoVremeSedmica;
            }
            set
            {
                _odrabotenoVremeSedmica = value;
                OnPropertyChanged("OdrabotenoVremeSedmica");
            }
        }

        public Sedmica(
            DenOdSedmica pon, 
            DenOdSedmica vto, 
            DenOdSedmica sre, 
            DenOdSedmica chet, 
            DenOdSedmica pet, 
            DenOdSedmica sab, 
            DenOdSedmica ned)
        {
            Ponedelnik = pon;
            Vtornik = vto;
            Sreda = sre;
            Chetvrtok = chet;
            Petok = pet;
            Sabota = sab;
            Nedela = ned;

            Denes = DateTime.Today;
            DozvolenVnes = Utils.DozvoliVnesNaVremePoSedmica(Ponedelnik.Datum, Denes);
            BojaVreme = System.Windows.Media.Brushes.LightGray;

            ListaIzborZaOdrabotenoVremeSedmica = Utils.napolniListaIzborZaOdrabotenoVremeSedmica();
            OdrabotenoVremeSedmica = ListaIzborZaOdrabotenoVremeSedmica[0];

            Mesec = Ponedelnik.Datum.ToString(Konstanti.MESEC_GODINA_FORMAT);
        }

        public Sedmica(
            DateTime pon,
            DateTime vto,
            DateTime sre,
            DateTime chet,
            DateTime pet,
            DateTime sab,
            DateTime ned)
        {
            Ponedelnik = new DenOdSedmica(0, pon);
            Vtornik = new DenOdSedmica(1, vto);
            Sreda = new DenOdSedmica(2, sre);
            Chetvrtok = new DenOdSedmica(3, chet);
            Petok = new DenOdSedmica(4, pet);
            Sabota = new DenOdSedmica(5, sab);
            Nedela = new DenOdSedmica(6, ned);

            Denes = DateTime.Today;
            DozvolenVnes = Utils.DozvoliVnesNaVremePoSedmica(Ponedelnik.Datum, Denes);
            BojaVreme = System.Windows.Media.Brushes.LightGray;

            ListaIzborZaOdrabotenoVremeSedmica = Utils.napolniListaIzborZaOdrabotenoVremeSedmica();
            OdrabotenoVremeSedmica = ListaIzborZaOdrabotenoVremeSedmica[0];

            Mesec = Ponedelnik.Datum.ToString(Konstanti.MESEC_GODINA_FORMAT);
        }

        public Sedmica(List<DateTime> sdm)
        {
            Ponedelnik = new DenOdSedmica(0, sdm[0]);
            Vtornik = new DenOdSedmica(1, sdm[1]);
            Sreda = new DenOdSedmica(2, sdm[2]);
            Chetvrtok = new DenOdSedmica(3, sdm[3]);
            Petok = new DenOdSedmica(4, sdm[4]);
            Sabota = new DenOdSedmica(5, sdm[5]);
            Nedela = new DenOdSedmica(6, sdm[6]);

            Denes = DateTime.Today;
            DozvolenVnes = Utils.DozvoliVnesNaVremePoSedmica(Ponedelnik.Datum, Denes);
            BojaVreme = System.Windows.Media.Brushes.LightGray;

            ListaIzborZaOdrabotenoVremeSedmica = Utils.napolniListaIzborZaOdrabotenoVremeSedmica();
            OdrabotenoVremeSedmica = ListaIzborZaOdrabotenoVremeSedmica[0];

            Mesec = Ponedelnik.Datum.ToString(Konstanti.MESEC_GODINA_FORMAT);
        }

        public Sedmica()
        {
            Denes = DateTime.Today;
            DozvolenVnes = Utils.DozvoliVnesNaVremePoSedmica(Ponedelnik.Datum, Denes);

            ListaIzborZaOdrabotenoVremeSedmica = Utils.napolniListaIzborZaOdrabotenoVremeSedmica();
            OdrabotenoVremeSedmica = ListaIzborZaOdrabotenoVremeSedmica[0];

            Mesec = Ponedelnik.Datum.ToString(Konstanti.MESEC_GODINA_FORMAT);
        }

        public void SoberiOdrabotenoVreme()
        {
            OdrabotenoVreme =
                new OdrabotenoVremePoZadacha(
                    0,
                    Ponedelnik.OdrabotenoVreme.vrednost +
                    Vtornik.OdrabotenoVreme.vrednost +
                    Sreda.OdrabotenoVreme.vrednost +
                    Chetvrtok.OdrabotenoVreme.vrednost + 
                    Petok.OdrabotenoVreme.vrednost + 
                    Sabota.OdrabotenoVreme.vrednost + 
                    Nedela.OdrabotenoVreme.vrednost);

            if(OdrabotenoVreme.vrednost == 0)
                BojaVreme = System.Windows.Media.Brushes.Coral;

            if (OdrabotenoVreme.vrednost > 0 && OdrabotenoVreme.vrednost < 40)
                BojaVreme = System.Windows.Media.Brushes.Orange;

            if (OdrabotenoVreme.vrednost >= 40 && OdrabotenoVreme.vrednost < 60)
                BojaVreme = System.Windows.Media.Brushes.Green;

            if (OdrabotenoVreme.vrednost >= 60)
                BojaVreme = System.Windows.Media.Brushes.LightBlue;
        }
    }
}
