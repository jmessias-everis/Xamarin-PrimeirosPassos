using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace MVApp.ViewModel
{
    public class LivrosViewModel
    {
        public ICommand CarregarCommand { get; set; }

        public ObservableCollection<Model.Livro> Livros { get; set; }

        public LivrosViewModel()
        {
            Livros = new ObservableCollection<Model.Livro>();
            Livros.Add(new Model.Livro { Id = 1, Titulo = "Primeiro Livro" });
            

            CarregarCommand = new Xamarin.Forms.Command(() => {
                Livros.Add(new Model.Livro { Id = 1, Titulo = $"Livro {Livros.Count}" });
            });
        }
    }
}
