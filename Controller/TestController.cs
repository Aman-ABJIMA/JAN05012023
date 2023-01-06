using Microsoft.AspNetCore.Mvc;

namespace ConsoleApp2.NewFolder
{
    [ApiController]
    [Route("test/[action]")]
    public class TestController:ControllerBase
    {
        public string Get1()
        {
            return "Hello from Get1";
        }

        public string Get2()
        {
            return "Hello from Get2";
        }
    }
}
