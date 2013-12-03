
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
namespace Igooana.Demo {
  public class ViewModel {
    private readonly ObservableCollection<Profile> profiles;
    public ViewModel() {
      profiles = new ObservableCollection<Profile>();
    }
    public ObservableCollection<Profile> Profiles {
      get { return profiles; }
    }
    public string ProfileId { get; set; }
    public bool Authenticated { get; set; }

    public Visibility ProfilesVisibility {
      get {
        return Authenticated ? Visibility.Visible : Visibility.Collapsed;
      }
    }
  }
}
