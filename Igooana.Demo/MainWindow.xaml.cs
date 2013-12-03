using System.Collections.ObjectModel;
using System.Windows;
using Igooana.Demo.Extensions;

namespace Igooana.Demo {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window {
    private Api api;
    private readonly ViewModel viewModel;
    public MainWindow() {
      InitializeComponent();
      viewModel = new ViewModel();
      DataContext = viewModel;
    }

    private async void OnAuthenticate(object sender, RoutedEventArgs e) {
      var auth = new Auth();
      if (auth.ShowDialog().GetValueOrDefault()) {
        api = auth.Api;
        viewModel.Authenticated = true;
        viewModel.Profiles.AddMany(await api.Management.GetProfilesAsync());
      }
    }
  }
}
