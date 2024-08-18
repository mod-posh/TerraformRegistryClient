using ModPosh.TerraformRegistryClient;
using NUnit.Framework;

namespace TerraformRegistryClient.Tests
{
    [TestFixture]
    public class TerraformRegistryConnectionInfoTests
    {
        [Test]
        public void Constructor_ShouldUseDefaultBaseAddress_WhenBaseAddressIsNull()
        {
            // Arrange
            var expectedDefaultAddress = "https://registry.terraform.io/v1/";

            // Act
            var connectionInfo = new TerraformRegistryConnectionInfo(null);

            // Assert
            Assert.That(connectionInfo.BaseAddress, Is.EqualTo(expectedDefaultAddress));
        }

        [Test]
        public void Constructor_ShouldInitializeBaseAddress_WhenValidAddressIsProvided()
        {
            // Arrange
            var baseAddress = "https://custom.registry.url/v1/";

            // Act
            var connectionInfo = new TerraformRegistryConnectionInfo(baseAddress);

            // Assert
            Assert.That(connectionInfo.BaseAddress, Is.EqualTo(baseAddress));
        }

        [Test]
        public void Constructor_ShouldInitializeWithDefaultBaseAddress_WhenNoAddressIsProvided()
        {
            // Arrange
            var expectedDefaultAddress = "https://registry.terraform.io/v1/";

            // Act
            var connectionInfo = new TerraformRegistryConnectionInfo();

            // Assert
            Assert.That(connectionInfo.BaseAddress, Is.EqualTo(expectedDefaultAddress));
        }
    }
}
