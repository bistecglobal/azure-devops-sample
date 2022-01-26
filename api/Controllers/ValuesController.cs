using Microsoft.AspNetCore.Mvc;

namespace api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public string[] Get()
        {
            return new string [] { "Azure DevOps", "Kubernetes" };
        }

        public bool duplicateCode1(int z){
            var x = 4;
            var y = x < 5;
            return y == true;
        }

        public bool duplicateCode2(int z){
            var x = 4;
            var y = x < 5;
            return y == true;
        }

        private string bad_name_variable { get; set; }
    }
}
