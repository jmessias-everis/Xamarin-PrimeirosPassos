using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MVApp.Model
{
    public class Autor : INotifyPropertyChanged
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value;
                 this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(id)));
                //Null Operater(?) = verifica se o metodo é nullo, caso seja ele não executa o Invoke
            }
        }
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value;
                  this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(nome)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
