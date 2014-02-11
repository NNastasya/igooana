using System.Collections.ObjectModel;
using System.Windows;
using Igooana.Demo.Extensions;
using System;

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

    private async void Button_Click(object sender, RoutedEventArgs e) {
      try {

        var query = Query
          .For(74167085, DateTime.Now.AddDays(-31), DateTime.Now)
          .WithMetrics(Metric.Visits)
          .WithDimensions(Dimension.PageTracking.PagePath);
        var result = await api.Execute(query);
      }
      catch (ConnectionException ex) {
        MessageBox.Show(ex.DetailedMessage);
      }
    }
  }
}
