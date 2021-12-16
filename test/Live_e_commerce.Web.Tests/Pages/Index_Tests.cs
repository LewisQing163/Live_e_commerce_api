using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Live_e_commerce.Pages
{
    public class Index_Tests : Live_e_commerceWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
