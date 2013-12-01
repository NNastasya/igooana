using System.Windows;

namespace Igooana.Demo {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window {
    private Api api;
    public MainWindow() {
      InitializeComponent();
    }

    private async void OnAuthenticate(object sender, RoutedEventArgs e) {
      var auth = new Auth();
      if (auth.ShowDialog().GetValueOrDefault()) {
        api = auth.Api;
        var profiles = await api.Management.GetProfilesAsync();
      }
    }
  }
}
