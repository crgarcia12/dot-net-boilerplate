using System.Threading.Tasks;
using Contoso.Models.TokenAuth;
using Contoso.Web.Controllers;
using Shouldly;
using Xunit;

namespace Contoso.Web.Tests.Controllers
{
    public class HomeController_Tests: ContosoWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}