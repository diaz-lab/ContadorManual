using System.ComponentModel;

namespace ContadorManual.Maui.Models
{
    public class Contador : INotifyPropertyChanged
    {
        private int _conteo;
        private int _Incremento;

        public event PropertyChangedEventHandler? PropertyChanged;

        public int Conteo
        {
            get => _conteo;
            set
            {
                if (_conteo != value)
                {
                    _conteo = value;
                    OnPropertyChanged(nameof(Conteo));
                }
            }
        }

        public int Incremento
        {
            get => _Incremento;
            set
            {
                if (_Incremento != value)
                {
                    _Incremento = value;
                    OnPropertyChanged(nameof(Incremento));
                }
            }
        }



        public Contador()
        {
            Conteo = 0;
            _Incremento = 1;
        } 

        public void Contar()
        {
            Conteo = Conteo + _Incremento;
        }

        public void Reiniciar()
        {
            Conteo = 0;
        }

        private void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, 
                    new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
