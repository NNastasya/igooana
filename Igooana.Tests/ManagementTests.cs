using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Igooana.Tests {
  [TestClass]
  public class ManagementTests {
    [TestMethod]
    public void ItReturnsProfiles() {
      var json = Resources.ManagementProfilesJson;
      var connection = Substitute.For<IConnection>();
      connection.GetStringAsync(Arg.Any<Uri>(), Arg.Any<string>())
        .Returns(Task.FromResult(json));
      var management = new Management(connection, null);
      var profiles = management.GetProfilesAsync().Result;
      Assert.IsNotNull(profiles);
      Assert.IsInstanceOfType(profiles, typeof(IEnumerable<Profile>));
    }
  }
}
