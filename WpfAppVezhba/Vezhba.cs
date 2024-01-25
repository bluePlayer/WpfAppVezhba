using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppVezhba
{
    // https://learn.microsoft.com/en-us/dotnet/desktop/wpf/controls/calendar-styles-and-templates?view=netframeworkdesktop-4.8
    // https://www.codeproject.com/Tips/547627/Highlight-dates-on-a-WPF-Calendar
    // https://stackoverflow.com/questions/18025382/wpf-change-calendar-day-title-foreground-color
    // https://stackoverflow.com/questions/28244258/programmatically-setting-back-color-to-specific-days-in-a-calender-for-windows-a
    // https://stackoverflow.com/questions/15875443/getting-date-using-day-of-the-week
    // https://stackoverflow.com/questions/25419101/get-the-day-of-a-week-from-integer-value-of-the-day
    // https://techbrij.com/convert-integer-day-of-week-dotnet
    // https://learn.microsoft.com/en-us/dotnet/standard/base-types/how-to-extract-the-day-of-the-week-from-a-specific-date

    // https://stackoverflow.com/questions/5018953/wpf-calendar-customize-the-control-to-show-calendar-week-numbers
    // https://wpf-tutorial.com/misc-controls/the-calendar-control/
    // https://learn.microsoft.com/en-us/archive/msdn-magazine/2009/may/customizing-the-new-wpf-calendar-controls
    // https://help.syncfusion.com/wpf/calendar/restrict-date-selection
    public class Vezhba: Notifier
    {
        CultureInfo myCI = new CultureInfo(Konstanti.KULTURA_MK);

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

        private DateTime _izbranPonedelnik;
        public DateTime IzbranPonedelnik
        {
            get
            {
                return _izbranPonedelnik;
            }
            set
            {
                _izbranPonedelnik = value;
                OnPropertyChanged("IzbranPonedelnik");
            }
        }

        private DateTime _displayDate;
        public DateTime DisplayDate
        {
            get
            {
                return _displayDate;
            }
            set
            {
                _displayDate = value;
                OnPropertyChanged("DisplayDate");
            }
        }

        

        private string _rbrNedelaVoGodina;
        public string RbrNedelaVoGodina
        {
            get
            {
                return _rbrNedelaVoGodina;
            }
            set
            {
                _rbrNedelaVoGodina = value;
                OnPropertyChanged("RbrNedelaVoGodina");
            }
        }

        private int _brojSedmiciVoGodina;
        public int BrojSedmiciVoGodina
        {
            get
            {
                return _brojSedmiciVoGodina;
            }
            set
            {
                _brojSedmiciVoGodina = value;
                OnPropertyChanged("BrojSedmiciVoGodina");
            }
        }

        private ObservableCollection<DateTime> _sedmica;
        public ObservableCollection<DateTime> Sedmica
        {
            get
            {
                return _sedmica;
            }

            set
            {
                _sedmica = value;
                OnPropertyChanged("Sedmica");   
            }
        }

        private ObservableCollection<Sedmica> _mesecPoSedmici;
        public ObservableCollection<Sedmica> MesecPoSedmici
        {
            get
            {
                return _mesecPoSedmici;
            }

            set
            {
                _mesecPoSedmici = value;
                OnPropertyChanged("MesecPoSedmici");
            }
        }

        private Sedmica _izbranaSedmica;
        public Sedmica IzbranaSedmica
        {
            get
            {
                return _izbranaSedmica;
            }

            set
            {
                _izbranaSedmica = value;
                OnPropertyChanged("IzbranaSedmica");
            }
        }
        
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
        
        public Vezhba()
        {
            Denes = DateTime.Today;
            BojaVreme = System.Windows.Media.Brushes.LightGray;
            // TODO da se ovozmozhi menuvanje godina. 
            BrojSedmiciVoGodina = Utils.brojNaSedmiciVoGodina(DateTime.Now.Year);
            IzbranPonedelnik = Utils.najdiDenoviOdSedmicaPoDen(Denes)[0];
            Sedmica = new ObservableCollection<DateTime>();
            MesecPoSedmici = new ObservableCollection<Sedmica>();
            DisplayDate = DateTime.Today;
            
            Console.WriteLine("vladence -----------------" + DateTime.Today.ToString(myCI));
            Console.WriteLine("vladence -----------------" + DateTime.Today.ToString(Konstanti.DEN_MESEC_GODINA_FORMAT_2));


            method1();
            method2();
            method9(Denes);

            //ListaIzborZaOdrabotenoVreme = Utils.napolniListaIzborZaOdrabotenoVreme();
            //OdrabotenoVreme = ListaIzborZaOdrabotenoVreme[0];
            tekovnaSedmica();
        }

        
        public void method1()
        {
            // Gets the Calendar instance associated with a CultureInfo.
            Calendar myCal = myCI.Calendar;


            // Gets the DTFI properties required by GetWeekOfYear.
            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;

            // Displays the number of the current week relative to the beginning of the year.
            Console.WriteLine("The CalendarWeekRule used for the " + Konstanti.KULTURA_MK + " culture is {0}.", myCWR);
            Console.WriteLine("The FirstDayOfWeek used for the " + Konstanti.KULTURA_MK + " culture is {0}.", myFirstDOW);
            Console.WriteLine("Therefore, the current week is Week {0} of the current year.", myCal.GetWeekOfYear(DateTime.Now, myCWR, myFirstDOW));

            // Displays the total number of weeks in the current year.
            DateTime LastDay = new System.DateTime(DateTime.Now.Year, 12, 31);
            Console.WriteLine("There are {0} weeks in the current year ({1}).", myCal.GetWeekOfYear(LastDay, myCWR, myFirstDOW), LastDay.Year);

            /*
            This code produces the following output.  Results vary depending on the system date.

            The CalendarWeekRule used for the en-US culture is FirstDay.
            The FirstDayOfWeek used for the en-US culture is Sunday.
            Therefore, the current week is Week 1 of the current year.
            There are 53 weeks in the current year (2001).

            */
        }

        public void method2()
        {
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            DateTime date1 = new DateTime(2011, 1, 1);
            Calendar cal = dfi.Calendar;

            Console.WriteLine("{0:d}: Week {1} ({2})", date1,
                              cal.GetWeekOfYear(date1, dfi.CalendarWeekRule,
                                                dfi.FirstDayOfWeek),
                              cal.ToString().Substring(cal.ToString().LastIndexOf(".") + 1));
        }

        public void method3()
        {
            CultureInfo myCI = new CultureInfo(Konstanti.KULTURA_MK);
            DateTime startOfWeek = DateTime.Today.AddDays(
                (int)myCI.DateTimeFormat.FirstDayOfWeek -
                (int)DateTime.Today.DayOfWeek);

            string result = string.Join("," + Environment.NewLine, Enumerable
                          .Range(0, 7)
                          .Select(i => startOfWeek
                             .AddDays(i)
                             .ToString(Konstanti.DEN_MESEC_GODINA_FORMAT)));

            Console.WriteLine(result);
        }

        public void method4()
        {
            var today = DateTime.Now.Date; // This can be any date.

            Console.WriteLine(today.DayOfWeek);

            var day = (int)today.DayOfWeek; //Number of the day in week. (0 - Sunday, 1 - Monday... and so On)

            Console.WriteLine(day);

            const int totalDaysOfWeek = 7; // Number of days in a week stays constant.

            for (var i = -day; i < -day + totalDaysOfWeek; i++)
            {
                Console.WriteLine(today.AddDays(i).Date);
            }
        }

        public void method5(System.Windows.Controls.Calendar calendar, int p)
        {
            DayOfWeek Day = DateTime.Now.DayOfWeek;
            int Days = Day - DayOfWeek.Monday + p; //here you can set your Week Start Day
            Console.WriteLine("Days: " + Days);

            DateTime WeekStartDate = DateTime.Now.AddDays(-Days);
            DateTime WeekEndDate1 = WeekStartDate.AddDays(1);
            DateTime WeekEndDate2 = WeekStartDate.AddDays(2);
            DateTime WeekEndDate3 = WeekStartDate.AddDays(3);
            DateTime WeekEndDate4 = WeekStartDate.AddDays(4);
            DateTime WeekEndDate5 = WeekStartDate.AddDays(5);
            DateTime WeekEndDate6 = WeekStartDate.AddDays(6);
            
            Console.WriteLine(WeekStartDate);
            //Console.WriteLine(WeekEndDate1);
            //Console.WriteLine(WeekEndDate2);
            //Console.WriteLine(WeekEndDate3);
            //Console.WriteLine(WeekEndDate4);
            //Console.WriteLine(WeekEndDate5);
            //Console.WriteLine(WeekEndDate6);

            DayOfWeek prevWeek = WeekStartDate.DayOfWeek - 1;
            int Days1 = prevWeek - DayOfWeek.Monday;

            Console.WriteLine(DateTime.Now.AddDays(-(int)prevWeek));

            calendar.SelectedDates.AddRange(
                WeekStartDate, WeekEndDate6);
        }

        public void method6()
        {
            int godina = 1970;

            for (int i = godina; i <= DateTime.Now.Year; i += 1)
            {
                Console.WriteLine("There are {0} weeks in the current year ({1}).", i, Utils.brojNaSedmiciVoGodina(i));
            }
        }

        public void method7(System.Windows.Controls.Calendar calendar, int p)
        {
            DayOfWeek Day = DateTime.Now.DayOfWeek;
            Console.WriteLine("Todays is: " + Day);

            int Days = Day - DayOfWeek.Monday; //here you can set your Week Start Day
            Console.WriteLine("Days: " + Days);

            int DaysP = Days + p;
            Console.WriteLine("Days + p => {0} = {1} + {2} => {3}", DaysP, Days, p, DateTime.Now.AddDays(DaysP));

            //DateTime WeekStartDate = DateTime.Now.AddDays(-Days);
            //Console.WriteLine(WeekStartDate);
        }

        public void method8(DateTime dt)
        {
            //DateTime dt = new DateTime(2023, 11, 27);
            Console.WriteLine("Datumot: {0} se naogja vo {1} - ta nedela od {2} godina. ", dt, Utils.redenBrojNaSedmicaVoGodina(dt), dt.Year);
            int dowInt = dt.DayOfWeek - DayOfWeek.Sunday;
            DayOfWeek dow = Utils.prevtoriBrojVoDenOdSedmica(dowInt);
            Console.WriteLine("wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww: " + dowInt + ", " + Utils.prevtoriBrojVoTekstDenOdSedmica(dowInt));
        }

        public void method9(DateTime dt)
        {
            List<DateTime> sedmica = Utils.najdiDenoviOdSedmicaPoDen(dt);
            
            Sedmica.Clear();

            foreach (DateTime den in sedmica)
            {
                Console.WriteLine("denot " + dt.Date + ", pripagja na sedmica: " + den);
                Sedmica.Add(den);
            }

            MesecPoSedmici.Clear();
            IzbranaSedmica = new Sedmica(sedmica);
            IzbranPonedelnik = IzbranaSedmica.Ponedelnik.Datum;
            MesecPoSedmici.Add(IzbranaSedmica);

            RbrNedelaVoGodina = Utils.redenBrojNaSedmicaVoGodina(IzbranPonedelnik).ToString() + " / " + Utils.brojNaSedmiciVoGodina(IzbranPonedelnik.Year);
        }

        public void prethodnaSedmica()
        {
            MesecPoSedmici.Clear();
            
            DateTime pretPonedelnik2 = IzbranPonedelnik.AddDays(2 * -Konstanti.SEDMICA_FAKTOR);
            Sedmica sedmica2 = new Sedmica(Utils.najdiDenoviOdSedmicaPoDen(pretPonedelnik2));
            sedmica2.Godina = pretPonedelnik2.Year;
            MesecPoSedmici.Add(sedmica2);

            DateTime pretPonedelnik1 = IzbranPonedelnik.AddDays(-Konstanti.SEDMICA_FAKTOR);
            Sedmica sedmica1 = new Sedmica(Utils.najdiDenoviOdSedmicaPoDen(pretPonedelnik1));
            sedmica1.Godina = pretPonedelnik1.Year;
            MesecPoSedmici.Add(sedmica1);

            IzbranaSedmica = sedmica1;
            IzbranPonedelnik = sedmica1.Ponedelnik.Datum;

            DateTime sledenPonedelnik1 = IzbranPonedelnik.AddDays(Konstanti.SEDMICA_FAKTOR + 1);
            Sedmica slednaSedmica1 = new Sedmica(Utils.najdiDenoviOdSedmicaPoDen(sledenPonedelnik1));
            slednaSedmica1.Godina = sledenPonedelnik1.Year;
            MesecPoSedmici.Add(slednaSedmica1);
            
            RbrNedelaVoGodina = "Седмица " + Utils.redenBrojNaSedmicaVoGodina(IzbranPonedelnik).ToString() + " од " + Utils.brojNaSedmiciVoGodina(IzbranPonedelnik.Year) + " во " + IzbranPonedelnik.Year;
        }

        public void tekovnaSedmica()
        {
            MesecPoSedmici.Clear();

            DateTime pretPonedelnik1 = IzbranPonedelnik.AddDays(-Konstanti.SEDMICA_FAKTOR);
            Sedmica sedmica1 = new Sedmica(Utils.najdiDenoviOdSedmicaPoDen(pretPonedelnik1));
            sedmica1.Godina = pretPonedelnik1.Year;
            MesecPoSedmici.Add(sedmica1);

            IzbranaSedmica = new Sedmica(Utils.najdiDenoviOdSedmicaPoDen(IzbranPonedelnik));
            IzbranaSedmica.Godina = IzbranPonedelnik.Year;
            MesecPoSedmici.Add(IzbranaSedmica);

            DateTime sledenPonedelnik1 = IzbranPonedelnik.AddDays(Konstanti.SEDMICA_FAKTOR + 1);
            Sedmica slednaSedmica1 = new Sedmica(Utils.najdiDenoviOdSedmicaPoDen(sledenPonedelnik1));
            slednaSedmica1.Godina = sledenPonedelnik1.Year;
            MesecPoSedmici.Add(slednaSedmica1);

            RbrNedelaVoGodina = "Седмица " + Utils.redenBrojNaSedmicaVoGodina(IzbranPonedelnik).ToString() + " од " + Utils.brojNaSedmiciVoGodina(IzbranPonedelnik.Year) + " во " + IzbranPonedelnik.Year;
        }

        public void slednaSedmica()
        {
            MesecPoSedmici.Clear();
            
            Sedmica tekovnaSedmica1 = new Sedmica(Utils.najdiDenoviOdSedmicaPoDen(IzbranPonedelnik));
            tekovnaSedmica1.Godina = IzbranPonedelnik.Year;
            MesecPoSedmici.Add(tekovnaSedmica1);

            DateTime sledenPonedelnik1 = IzbranPonedelnik.AddDays(Konstanti.SEDMICA_FAKTOR + 1);
            Sedmica slednaSedmica1 = new Sedmica(Utils.najdiDenoviOdSedmicaPoDen(sledenPonedelnik1));
            slednaSedmica1.Godina = sledenPonedelnik1.Year;
            MesecPoSedmici.Add(slednaSedmica1);

            IzbranaSedmica = slednaSedmica1;
            IzbranPonedelnik = slednaSedmica1.Ponedelnik.Datum;
            IzbranaSedmica.Godina = IzbranPonedelnik.Year;

            DateTime sledenPonedelnik2 = IzbranPonedelnik.AddDays(Konstanti.SEDMICA_FAKTOR + 1);
            Sedmica slednaSedmica2 = new Sedmica(Utils.najdiDenoviOdSedmicaPoDen(sledenPonedelnik2));
            slednaSedmica2.Godina = sledenPonedelnik2.Year;
            MesecPoSedmici.Add(slednaSedmica2);
            
            RbrNedelaVoGodina = "Седмица " + Utils.redenBrojNaSedmicaVoGodina(IzbranPonedelnik).ToString() + " од " + Utils.brojNaSedmiciVoGodina(IzbranPonedelnik.Year) + " во " + IzbranPonedelnik.Year;
        }
    }
}
