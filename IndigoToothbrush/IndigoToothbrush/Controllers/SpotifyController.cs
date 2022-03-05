using Microsoft.AspNetCore.Mvc;
using SpotifyAPI;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IndigoToothbrush.Controllers
{
    [Route("api/spotify")]
    [ApiController]
    public class SpotifyController : ControllerBase
    {
        // GET: api/<SpotifyController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SpotifyController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            int SL = StringLibrary.AmplifyValue(id);
            return SL.ToString();
        }

        // POST api/<SpotifyController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SpotifyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SpotifyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
