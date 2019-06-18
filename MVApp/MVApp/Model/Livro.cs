using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MVApp.Model
{
    public class Livro : INotifyPropertyChanged //aciona o evento de notificar caso seja alterado alguma variável.
    {
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(id))); 
                //Null Operater(?) = verifica se o metodo é nullo, caso seja ele não executa o Invoke
            }
        }

        private string titulo;
        public string Titulo {
            get { return titulo; }
            set {
                titulo = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(titulo)));
            }
        }

        private Autor autor;
        public Autor Autor
        {
            get { return autor; }
            set {
                autor = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(autor)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
