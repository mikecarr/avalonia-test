using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Avalonia.Controls;
using System.Collections.ObjectModel;
using Avalonia.Collections;

namespace AvaloniaApplication3.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<string> FontItems { get; set; }

        public MainWindowViewModel()
        {
            FontItems = new ObservableCollection<string>
            {
                "Arial",
                "Calibri",
                "Times New Roman"
            };
        }
    }
}