namespace API.Tests
{
    using FluentAssertions;
    using Xunit;

    public class ValuesControllerTests
    {
        [Fact]
        public void DockerIntegration_UnitTest_ReturnsPassed()
        {
            // Arrange
            var testValue = false;

            // Assert
            testValue.Should().BeTrue();
        }
    }
}