using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Moq;
using Moq.Protected;
using NUnit.Framework;
using ModPosh.TerraformRegistryClient;

namespace TerraformRegistryClient.Tests
{
    [TestFixture]
    public class ClientMethodTests
    {
        [Test]
        public async Task ListModulesAsync_ShouldReturnValidResponse_WhenApiReturnsSuccess()
        {
            // Arrange
            var connectionInfo = new TerraformRegistryConnectionInfo("https://registry.terraform.io/v1/");
            var mockHttpMessageHandler = new Mock<HttpMessageHandler>();

            mockHttpMessageHandler.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>()
                )
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent("{ \"modules\": [] }"),
                });

            var mockHttpClient = new HttpClient(mockHttpMessageHandler.Object)
            {
                BaseAddress = new Uri(connectionInfo.BaseAddress)
            };

            var mockHttpClientFactory = new Mock<IHttpClientFactory>();
            mockHttpClientFactory.Setup(x => x.CreateClient(It.IsAny<string>())).Returns(mockHttpClient);

            var client = new Client(connectionInfo, mockHttpClientFactory.Object);

            // Act
            var result = await client.ListModulesAsync("hashicorp");

            // Assert
            Assert.That(result, Is.Not.Null); // Ensure result is not null
            Assert.That(result.Modules.Count, Is.EqualTo(0)); // Equivalent to Assert.AreEqual(0, result.Modules.Count)

        }
    }
}
