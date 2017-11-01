namespace PetProjects.MtsManagementApi.API.Tests
{
    using FluentAssertions;
    using Xunit;

    public class ValuesControllerTests
    {
        [Fact]
        public void DockerIntegration_UnitTest_ReturnsPassed()
        {
            // Arrange
            var testValue = true;

            // Assert
            testValue.Should().BeTrue();
        }
    }
}