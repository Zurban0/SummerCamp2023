using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesEventos
{
    public class StringChange
    {
        private string myString;

        public string MyStringProperty
        {
            get { return myString; }
            set
            {
                if (myString != value)
                {
                    myString = value;
                    OnPropertyChanged("MyStringProperty");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
