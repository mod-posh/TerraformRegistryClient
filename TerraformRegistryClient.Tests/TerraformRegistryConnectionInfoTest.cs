using ModPosh.TerraformRegistryClient;
using NUnit.Framework;

namespace TerraformRegistryClient.Tests
{
    [TestFixture]
    public class TerraformRegistryConnectionInfoTests
    {
        [Test]
        public void Constructor_ShouldUseDefaultBaseAddress_WhenBaseAddressIsNullOrEmpty()
        {
            // Act
            var connectionInfoNull = new TerraformRegistryConnectionInfo(null);
            var connectionInfoEmpty = new TerraformRegistryConnectionInfo("");

            // Assert
            Assert.That(connectionInfoNull.BaseAddress, Is.EqualTo("https://registry.terraform.io/v1/"));
            Assert.That(connectionInfoEmpty.BaseAddress, Is.EqualTo("https://registry.terraform.io/v1/"));
        }

        [Test]
        public void Constructor_ShouldInitializeBaseAddress_WhenValidAddressIsProvided()
        {
            // Arrange
            var baseAddress = "https://custom.url/v1/";

            // Act
            var connectionInfo = new TerraformRegistryConnectionInfo(baseAddress);

            // Assert
            Assert.That(connectionInfo.BaseAddress, Is.EqualTo(baseAddress));
        }

        [Test]
        public void DefaultConstructor_ShouldUseDefaultBaseAddress()
        {
            // Act
            var connectionInfo = new TerraformRegistryConnectionInfo();

            // Assert
            Assert.That(connectionInfo.BaseAddress, Is.EqualTo("https://registry.terraform.io/v1/"));
        }
    }
}
