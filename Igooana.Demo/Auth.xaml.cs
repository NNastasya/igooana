using System;
using System.Windows;
using System.Windows.Navigation;

namespace Igooana.Demo {

  /// <summary>
  /// Interaction logic for Auth.xaml
  /// </summary>
  public partial class Auth : Window {

    private string clientId = "15132115543.apps.googleusercontent.com";
    private string clientSecret = "1n6lLaVJQplUpzDcbSQUhVO4";
    private Api api; 

    public Auth() {
      InitializeComponent();
      Loaded += OnLoaded;
    }

    public Api Api {
      get { return api; }
    }

    void OnLoaded(object sender, RoutedEventArgs e) {
      api = new Api(clientId, clientSecret);
      Browser.Navigate(api.AuthenticateUri);
    }

    private async void OnNavigating(object sender, NavigatingCancelEventArgs e) {
      if (await api.Authenticate(e.Uri)) {
        DialogResult = true;
        Close();
      }
    }
  }
}
