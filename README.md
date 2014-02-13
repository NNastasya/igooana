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

```c#
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

```c#
  var profiles = await api.Management.GetProfilesAsync();
```

### Reporting

`Api` class offers a `Execute` method which accepts a `Query` and executes it.
Constructing a `Query` is typesafe and fun. 
Let's say you'd like to view a number of visits and pageviews by browser for last month.

```c#
try {
  int profileId = GetProfileId(); // this might use Api.Management to get all your profiles.
  var query = Query
    .For(profileId, DateTime.Now.AddDays(-31), DateTime.Now)
    .WithMetrics(Metric.Visits + Metric.PageViews)
    .WithDimensions(Dimension.Browser);
  Result result = await api.Execute(query);
  foreach(var row in result.Values){
    Console.WriteLine("I had {0} visits with {1} pageviews on {2} browser", row.Visits, row.PageViews, row.Browser);
  }
}
catch (ConnectionException ex) {
  MessageBox.Show(ex.DetailedMessage);
}
```

What does `Api#Execute` return? 
It's a `Igooana.Result` object, which has `Values` properties - an `IEnumerable<dynamic>`.
Using `dynamic` allows you to have a collection of objects with all the properties you've queried with metrics and dimensions.

Moreover, all properties have their respective CLR types, not strings Google Analytics returns.

#### Potential caveat when using silverlight/windows phone data binding to `result.Values`:

There currently is a bug related to it: http://connect.microsoft.com/VisualStudio/feedback/details/522119/databinding-to-dynamic-objects-is-broken

There are various workarounds listed on that issue page.


This is a work in progress, PRs are welcome :)

All code is MIT licensed

_Valentin Vasilyev, 2013_
