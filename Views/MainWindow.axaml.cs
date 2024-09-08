using Avalonia.Controls;
using Avalonia.Media;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AvaloniaApplication3.ViewModels;
using Avalonia.Markup.Xaml;


namespace AvaloniaApplication3.Views;
public partial class MainWindow : Window
{
    public ObservableCollection<string> FontItems { get; set; }

    public MainWindow() 
    {
        
        
        DataContext = new MainWindowViewModel(); // Ensure ViewModel is set

        InitializeComponent();

    }
    private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }


}
