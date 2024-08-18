using System;
using System.Net.Http;
using Moq;
using NUnit.Framework;
using ModPosh.TerraformRegistryClient;

namespace TerraformRegistryClient.Tests
{
    [TestFixture]
    public class ClientTests
    {
        [Test]
        public void Client_ShouldInitializeHttpClient_WithValidConnectionInfo()
        {
            // Arrange
            var connectionInfo = new TerraformRegistryConnectionInfo("https://registry.terraform.io/v1/");
            var mockHttpClientFactory = new Mock<IHttpClientFactory>();
            var mockHttpClient = new HttpClient();
            mockHttpClientFactory.Setup(x => x.CreateClient(It.IsAny<string>())).Returns(mockHttpClient);

            var client = new Client(connectionInfo, mockHttpClientFactory.Object);

            // Act & Assert
            Assert.That(client.httpClient, Is.Not.Null); // Check if HttpClient is accessible and not null
        }
    }
}
