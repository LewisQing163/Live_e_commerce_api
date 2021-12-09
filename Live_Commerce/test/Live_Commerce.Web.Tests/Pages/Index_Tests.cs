using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Live_Commerce.Pages
{
    public class Index_Tests : Live_CommerceWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
