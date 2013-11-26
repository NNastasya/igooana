using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Igooana.Demo {

  /// <summary>
  /// Interaction logic for Auth.xaml
  /// </summary>
  public partial class Auth : Window {

    private string clientId = "15132115543.apps.googleusercontent.com";
    private string clientSecret = "1n6lLaVJQplUpzDcbSQUhVO4";
    private Action<String> authContinueCallback;

    public Auth() {
      InitializeComponent();
      Loaded += OnLoaded;
    }

    void OnLoaded(object sender, RoutedEventArgs e) {
      authContinueCallback = Api.Authenticate(clientId, clientSecret, uri => Browser.Navigate(uri));
    }
    private void OnNavigating(object sender, NavigatingCancelEventArgs e) {
      if (e.Uri.Host == "localhost") {
        string queryString = e.Uri.Query.ToString();
        if (queryString.Contains("access_denied")) {
          MessageBox.Show("You must allow access in order to use Google Analytics");
        }
        else {
          string authCode = queryString.Substring(queryString.IndexOf("code=") + 5);
          authContinueCallback(authCode);
        }
      }
    }

    private void OnNavigated(object sender, NavigationEventArgs e) {
    }

  }
}
