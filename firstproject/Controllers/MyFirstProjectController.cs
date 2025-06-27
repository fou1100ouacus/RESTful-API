using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace firstproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyFirstProjectController : ControllerBase
    {
        [HttpGet]
        public string GetMyName()
        {
            return "My name is aya";
        }
        [HttpGet("n1,nk2")]
        public int sum(int n1,int n2)
        {
            return n1 + n2;

        }


    
    }
}
