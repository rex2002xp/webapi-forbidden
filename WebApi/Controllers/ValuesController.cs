using System.Collections.Generic;
using System.Web.Http;
using WebApi.HandlesMessageHttp;

namespace WebApi.Controllers
{
    [Authorize]
    [RoutePrefix("api/values")]
    public class ValuesController : ApiController
    {
        private List<string> data = new List<string>() { "Valor 1", "Valor 2" };

        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(data);
        }

        [CustomAuthorize(Roles = "Admin")]
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            data.RemoveAt(id);
            return Ok(data);
        }
    }
}
