using NSubstitute;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Igooana.Tests {
  public class ManagementTests {
    [Fact]
    public void ItReturnsProfiles() {
      var json = Resources.ManagementProfilesJson;
      var connection = Substitute.For<IConnection>();
      connection.GetStringAsync(Arg.Any<Uri>(), Arg.Any<string>())
        .Returns(Task.FromResult(json));
      var management = new Management(connection, null);
      var profiles = management.GetProfilesAsync().Result;
      Assert.NotNull(profiles);
      Assert.IsAssignableFrom<IEnumerable<Profile>>(profiles);
    }
  }
}
