using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppVezhba
{
    public class OdrabotenoVremePoZadacha:Notifier
    {
        public int id;
        public float vrednost;

        private string _textLabel;
        public string TextLabel
        {
            get
            {
                return _textLabel;
            }
            set
            {
                _textLabel = value;
                OnPropertyChanged("TextLabel");
            }
        }

        public OdrabotenoVremePoZadacha(int id, float vrednost, string label = "")
        {
            this.id = id;
            this.vrednost = vrednost;

            if (label != String.Empty)
            {
                TextLabel = label;
            }
            else
            {
                TextLabel = vrednost.ToString();
            }

        }
    }
}
