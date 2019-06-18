using MVApp.Model;

namespace MVApp.ViewModel
{
    public interface IObservableCollection<T>
    {
        object Count { get; set; }

        void Add(Livro livro);
    }
}