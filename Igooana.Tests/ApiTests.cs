
using Xunit;
namespace Igooana.Tests {
  public class ApiTests {
    [Fact]
    public void ItCreatesNewApiInstanceWithConstructor() {
      var api = new Api("fake", "fake");
      Assert.NotNull(api);
    }
  }
}
