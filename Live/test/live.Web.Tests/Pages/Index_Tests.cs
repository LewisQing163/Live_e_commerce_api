using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace live.Pages
{
    public class Index_Tests : liveWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
