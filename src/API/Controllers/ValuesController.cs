namespace PetProjects.MtsManagementApi.API.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;

    [ApiVersion("1")]
    [Route("v{version:apiVersion}/values")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        [MapToApiVersion("1")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [MapToApiVersion("1")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        [MapToApiVersion("1")]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        [MapToApiVersion("1")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        [MapToApiVersion("1")]
        public void Delete(int id)
        {
        }
    }
}
