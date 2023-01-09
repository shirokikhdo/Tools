using DemoWpfMvvm.Models;
using shirokikhdoStandard.Commands;
using shirokikhdoStandard.ViewModels.Base;
using System.Windows.Input;

namespace DemoWpfMvvm.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        private string _value;
        public string Value
        {
            get => _value;
            set => Set(ref _value, value);
        }

        public ICommand UpdateCmd { get; }

        private Data _model;

        internal MainViewModel()
        {
            _model = new Data();
            UpdateData();
            UpdateCmd = new RelayCommand(OnUpdateCmd);
        }

        private void UpdateData()
        {
            _model.Update();
            Value = _model.DateTime.ToString();
        }

        private void OnUpdateCmd(object p)
        {
            UpdateData();
        }
    }
}