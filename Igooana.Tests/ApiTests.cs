using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Igooana.Tests {
  [TestClass]
  public class ApiTests {
    [TestMethod]
    public void ItCreatesNewApiInstanceWithConstructor() {
      var api = new Api("fake", "fake");
      Assert.IsNotNull(api);
    }
  }
}
