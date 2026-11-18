using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InventarioEquiposFase3N.Models
{
    public class Departamento : INotifyPropertyChanged
    {




        private string _codigo = string.Empty;
        public string Codigo
        {
            get => _codigo;
            set
            {
                if (_codigo != value)
                {
                    _codigo = value;
                    OnPropertyChanged(nameof(Codigo));
                }
            }
        }


        private string _nombre = string.Empty;
        public string Nombre
        {
            get => _nombre;
            set
            {
                if (_nombre != value)
                {
                    _nombre = value;
                    OnPropertyChanged(nameof(Nombre));
                }
            }
        }
       
        public void Validar()
        {
            if (string.IsNullOrWhiteSpace(Codigo))
                throw new ArgumentException("Ingrese el código del departamento.");
            if (string.IsNullOrWhiteSpace(Nombre))
                throw new ArgumentException("Ingrese el nombre del departamento.");
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
    }
}
