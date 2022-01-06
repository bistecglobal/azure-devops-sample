using Xunit;

namespace api.tests
{
    public class ValuesControllerTests
    {
        [Fact]
        public void ShouldContainTwoElements()
        {
            var controller = new ValuesController();
            var results = controller.Get();
            Assert.Equal(2, results.Length);
        }

        [Fact]
        public void ShouldContainAzureDevOps()
        {
            var controller = new ValuesController();
            var results = controller.Get();
            Assert.Equal("Azure DevOps", results[0]);
        }

        [Fact]
        public void ShouldContainKubernetes()
        {
            var controller = new ValuesController();
            var results = controller.Get();
            Assert.Equal("Kubernetes", results[1]);
        }
    }
}