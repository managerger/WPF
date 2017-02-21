using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ViewModel.Infrastructure.Concrete
{
    public class Notifier : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Notifier()
        {
            this.PropertyChanged += (_, __) => { };
        }

        protected void OnPropertyChanged([CallerMemberName]string prop = null)
        {
            this.PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}