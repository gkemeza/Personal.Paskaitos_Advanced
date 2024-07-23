using System.ComponentModel;

namespace Paskaita12_Delegates
{
    // norime pamatyti jog Age pasikeite (observability)
    // pabandyti perdaryti be interface!
    // event?
    // toks observability leidzia atsinaujinti puslapio info (nepaspaudus refresh)!
    // 20.35+ paaiskino
    internal class Person : INotifyPropertyChanged
    {
        private string name;

        public event PropertyChangedEventHandler? PropertyChanged;

        public delegate string NameChangedDelegate(string name);

        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public int Age { get; set; }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
