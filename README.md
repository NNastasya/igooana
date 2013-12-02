igooana
=======

Google Analytics API for modern C#.

The goal of this library is to create a modern, fully asynchronous Google Analytics API for C# 5.
All potentially long operations are `async/await` methods.

## Usage

Before you start, make sure you have your Google Analytics `clientId` and `clientSecret` credentials. If you don't, first [https://cloud.google.com/console#/project](get it from Google).

### Authentication

Using the api requires authenticating via web browser. If you're using Xaml (WPF or Silverlight applications), the code might look like:

```

<Grid>
  <WebBrowser Name="Browser" Navigating="OnNavigating" />
</Grid>

```

Code behind:

```

void OnLoaded(object sender, RoutedEventArgs e) {
  // assuming you already have clientId and clientSecret
  api = new Api(clientId, clientSecret);
  Browser.Navigate(api.AuthenticateUri);
}

private async void OnNavigating(object sender, NavigatingCancelEventArgs e) {
  if (await api.Authenticate(e.Uri)) {
    // You've authenticated at this point
  }
}

```

At this point you have the authenticated api reference and can start calling methods on it.

### Management 

`Api` class offers `Management` property which you can use to access Management API operations.

#### Profiles

```

  var profiles = await api.Management.GetProfilesAsync();
  
```

This is a work in progress, PRs are welcome :)

All code is MIT licensed

_Valentin Vasilyev, 2013_
