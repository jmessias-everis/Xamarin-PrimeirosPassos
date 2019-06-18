using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LivrosView : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public LivrosView()
        {
            InitializeComponent();
            this.BindingContext = new ViewModel.LivrosViewModel();

            
        }
    }
}
