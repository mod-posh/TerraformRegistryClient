using ModPosh.TerraformRegistryClient;
using NUnit.Framework;

namespace TerraformRegistryClient.Tests
{
    [TestFixture]
    public class TerraformRegistryConnectionInfoTests
    {
        [Test]
        public void Constructor_ShouldThrowException_WhenBaseAddressIsNull()
        {
            // Arrange, Act & Assert
            Assert.Throws<ArgumentNullException>(() => new TerraformRegistryConnectionInfo(null));
        }

        [Test]
        public void Constructor_ShouldInitializeBaseAddress_WhenValidAddressIsProvided()
        {
            // Arrange
            var baseAddress = "https://registry.terraform.io/v1/";

            // Act
            var connectionInfo = new TerraformRegistryConnectionInfo(baseAddress);

            // Assert
            Assert.That(connectionInfo.BaseAddress, Is.EqualTo(baseAddress)); // Corrected assertion
        }
    }
}