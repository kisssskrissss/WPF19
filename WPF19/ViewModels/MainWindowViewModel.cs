using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF19
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        private int num;
        public int Num
        {
            get => num;
            set
            {
                num = value;
            }
        }
        private double num2;
        public double Num2
        {
            get => num2;
            set
            {
                num2 = value;
            }
        }
        public ICommand AddCommand { get; }
        private void OnAddCommandExecute (object p)
        {
            Num2 = Ariph.Add(Num);
        }
        private bool CanAddCommandExecuted(object p)
        {
            if (Num != 0) return true;
            else
                return false;
        }
        public MainWindowViewModel()
        {
            AddCommand = new RelayCommand(OnAddCommandExecute, CanAddCommandExecuted);
        }
    }
}
