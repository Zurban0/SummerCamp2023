namespace PruebaControladorVariableCambia
{
    using System;
    using System.ComponentModel;

    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();
            myClass.PropertyChanged += MyClass_PropertyChanged;

            // Modifica el valor de la propiedad, y se disparará el evento.
            myClass.MyStringProperty = "Nuevo valor";
        }

        private static void MyClass_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "MyStringProperty")
            {
                Console.WriteLine("La propiedad MyStringProperty ha cambiado.");
            }
        }
    }

    class MyClass : INotifyPropertyChanged
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