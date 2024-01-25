using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppVezhba
{
    public class Utils
    {
        public static List<DateTime> najdiDenoviOdSedmicaPoDen(DateTime dt)
        {
            List<DateTime> ishod = new List<DateTime>();
            int dowInt = dt.DayOfWeek - DayOfWeek.Monday;
            int denoviZaDodavanje;

            for (int i = Konstanti.SEDMICA_FAKTOR; i >= 0; i -= 1)
            {
                if (dowInt == -1)
                {
                    denoviZaDodavanje = -i;
                }
                else
                {
                    denoviZaDodavanje = -dowInt - i + Konstanti.SEDMICA_FAKTOR;
                }

                ishod.Add(dt.AddDays(denoviZaDodavanje));
            }

            return ishod;
        }

        public static string prevtoriBrojVoTekstDenOdSedmica(int dowInt)
        {
            return Enum.GetName(typeof(DayOfWeek), dowInt);
        }

        public static DayOfWeek prevtoriBrojVoDenOdSedmica(int dowInt)
        {
            return (DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(dowInt);
        }

        public static int brojNaSedmiciVoGodina(int year)
        {
            int ishod = -1;

            try
            {
                CultureInfo cultureInfo = new CultureInfo(Konstanti.KULTURA_MK);
                Calendar mtCalendar = cultureInfo.Calendar;

                CalendarWeekRule calendarWeekRule = cultureInfo.DateTimeFormat.CalendarWeekRule;
                DayOfWeek firstDayOfWeek = cultureInfo.DateTimeFormat.FirstDayOfWeek;

                DateTime LastDay = new System.DateTime(year, 12, 31);
                ishod = mtCalendar.GetWeekOfYear(LastDay, calendarWeekRule, firstDayOfWeek);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return ishod;
        }

        public static int redenBrojNaSedmicaVoGodina(DateTime datum)
        {
            int ishod = -1;

            try
            {
                CultureInfo cultureInfo = new CultureInfo(Konstanti.KULTURA_MK);
                Calendar mtCalendar = cultureInfo.Calendar;

                CalendarWeekRule calendarWeekRule = cultureInfo.DateTimeFormat.CalendarWeekRule;
                DayOfWeek firstDayOfWeek = cultureInfo.DateTimeFormat.FirstDayOfWeek;

                ishod = mtCalendar.GetWeekOfYear(datum, calendarWeekRule, firstDayOfWeek);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return ishod;
        }

        public static ObservableCollection<OdrabotenoVremePoZadacha> napolniListaIzborZaOdrabotenoVreme()
        {
            ObservableCollection<OdrabotenoVremePoZadacha>  ListaIzborZaOdrabotenoVreme = new ObservableCollection<OdrabotenoVremePoZadacha>();

            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(-1, 0.0f, "Време"));

            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(0, 0.5f));

            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(1, 1f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(2, 1.5f));

            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(3, 2f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(4, 2.5f));

            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(5, 3f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(6, 3.5f));

            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(7, 4f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(8, 4.5f));

            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(9, 5f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(10, 5.5f));

            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(11, 6f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(12, 6.5f));

            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(13, 7f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(14, 7.5f));

            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(15, 8f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(16, 8.5f));

            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(17, 9f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(18, 9.5f));

            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(19, 10f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(20, 10.5f));

            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(21, 11f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(22, 11.5f));

            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(23, 12f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(24, 12.5f));

            return ListaIzborZaOdrabotenoVreme;
        }

        public static ObservableCollection<OdrabotenoVremePoZadacha> napolniListaIzborZaOdrabotenoVremeSedmica()
        {
            ObservableCollection<OdrabotenoVremePoZadacha> ListaIzborZaOdrabotenoVreme = new ObservableCollection<OdrabotenoVremePoZadacha>();

            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(0, 0f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(0, 0.5f));

            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(1, 1f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(2, 1.5f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(3, 2f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(4, 3f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(5, 4f));

            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(6, 5f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(7, 6f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(8, 7f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(9, 8f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(10, 9f));

            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(11, 10f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(12, 11f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(13, 12f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(14, 13f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(15, 14f));

            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(16, 15f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(17, 16f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(18, 17f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(19, 18f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(20, 19f));

            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(21, 20f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(22, 21f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(23, 22f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(24, 23f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(25, 24f));

            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(26, 25f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(27, 26f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(28, 27f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(29, 28f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(30, 29f));

            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(31, 30f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(32, 31f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(33, 32f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(34, 33f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(35, 34f));

            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(36, 35f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(37, 36f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(38, 37f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(39, 38f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(40, 39f));

            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(41, 40f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(42, 41f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(43, 42f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(44, 43f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(45, 44f));

            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(46, 45f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(47, 46f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(48, 47f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(49, 48f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(50, 49f));

            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(51, 50f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(52, 51f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(53, 52f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(54, 53f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(55, 54f));

            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(56, 55f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(57, 56f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(58, 57f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(59, 58f));
            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(60, 59f));

            ListaIzborZaOdrabotenoVreme.Add(new OdrabotenoVremePoZadacha(61, 60f));

            return ListaIzborZaOdrabotenoVreme;
        }

        public static bool DozvoliVnesNaVremePoSedmica(DateTime IzbranPonedelnik, DateTime Denes)
        {
            return IzbranPonedelnik.DayOfYear - najdiDenoviOdSedmicaPoDen(Denes)[0].DayOfYear > 7
                ? false 
                : true;
        }
    }
}
