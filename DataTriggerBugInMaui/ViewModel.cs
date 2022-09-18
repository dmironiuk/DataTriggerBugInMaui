using System;
using System.ComponentModel;

namespace DataTriggerBugInMaui
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool _isCurrentMonth;
        public bool IsCurrentMonth
        {
            get => _isCurrentMonth;
            set
            {
                _isCurrentMonth = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsCurrentMonth)));
            }
        }

        private bool _isPast;
        public bool IsPast
        {
            get => _isPast;
            set
            {
                _isPast = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsPast)));
            }
        }

        public ViewModel()
        {
        }

        public void OnSwitchBoth()
        {
            IsCurrentMonth = !IsCurrentMonth;
            IsPast = !IsPast;
        }
    }
}

