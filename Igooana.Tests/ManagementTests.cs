using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Igooana.Tests {
  [TestClass]
  public class ManagementTests {
    [TestMethod]
    public async void ItCreatesNewApiInstanceWithConstructor() {
      //TODO: Move this ugly mess to embedded resource
      string response = @"
        { ""items"" : [ { ""accountId"" : ""29000446"",
        ""childLink"" : { ""href"" : ""https://www.googleapis.com/analytics/v3/management/accounts/29000446/webproperties/UA-29000446-1/profiles/55921002/goals"",
            ""type"" : ""analytics#goals""
          },
        ""created"" : ""2012-02-07T08:16:57.483Z"",
        ""currency"" : ""USD"",
        ""eCommerceTracking"" : false,
        ""id"" : ""55921002"",
        ""internalWebPropertyId"" : ""54947842"",
        ""kind"" : ""analytics#profile"",
        ""name"" : ""g.raphael-radar"",
        ""parentLink"" : { ""href"" : ""https://www.googleapis.com/analytics/v3/management/accounts/29000446/webproperties/UA-29000446-1"",
            ""type"" : ""analytics#webproperty""
          },
        ""permissions"" : { ""effective"" : [ ""COLLABORATE"",
                ""EDIT"",
                ""MANAGE_USERS"",
                ""READ_AND_ANALYZE""
              ] },
        ""selfLink"" : ""https://www.googleapis.com/analytics/v3/management/accounts/29000446/webproperties/UA-29000446-1/profiles/55921002"",
        ""timezone"" : ""America/Los_Angeles"",
        ""type"" : ""WEB"",
        ""updated"" : ""2012-02-07T10:14:09.721Z"",
        ""webPropertyId"" : ""UA-29000446-1"",
        ""websiteUrl"" : ""http://valve.github.com/g.raphael-radar/example""
      },
      { ""accountId"" : ""42202458"",
        ""childLink"" : { ""href"" : ""https://www.googleapis.com/analytics/v3/management/accounts/42202458/webproperties/UA-42202458-1/profiles/74167085/goals"",
            ""type"" : ""analytics#goals""
          },
        ""created"" : ""2013-07-03T10:58:56.064Z"",
        ""currency"" : ""USD"",
        ""eCommerceTracking"" : false,
        ""id"" : ""74167085"",
        ""internalWebPropertyId"" : ""71880883"",
        ""kind"" : ""analytics#profile"",
        ""name"" : ""All Web Site Data"",
        ""parentLink"" : { ""href"" : ""https://www.googleapis.com/analytics/v3/management/accounts/42202458/webproperties/UA-42202458-1"",
            ""type"" : ""analytics#webproperty""
          },
        ""permissions"" : { ""effective"" : [ ""COLLABORATE"",
                ""EDIT"",
                ""MANAGE_USERS"",
                ""READ_AND_ANALYZE""
              ] },
        ""selfLink"" : ""https://www.googleapis.com/analytics/v3/management/accounts/42202458/webproperties/UA-42202458-1/profiles/74167085"",
        ""timezone"" : ""Europe/Moscow"",
        ""type"" : ""WEB"",
        ""updated"" : ""2013-07-03T10:58:56.064Z"",
        ""webPropertyId"" : ""UA-42202458-1"",
        ""websiteUrl"" : ""http://valve.github.io""
                }
              ],
            ""itemsPerPage"" : 1000,
            ""kind"" : ""analytics#profiles"",
            ""startIndex"" : 1,
            ""totalResults"" : 2,
            ""username"" : ""iamvalentin@gmail.com""
          }
      ";
      var connection = Substitute.For<IConnection>();
      connection.GetStringAsync(Arg.Any<Uri>(), Arg.Any<string>())
        .Returns(new Task<string>(() => response));
      var api = new Api(connection, new Auth("fake", "fake"));
      var profiles = await api.Management.GetProfilesAsync();
      Assert.IsNotNull(profiles);
      Assert.IsInstanceOfType(profiles, typeof(IEnumerable<Profile>));
    }
  }
}
