using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OwinWebApi.Swashbuckle.Controllers
{
    public class ValueController : ApiController
    {
        // GET: api/Value
        /// <summary>
        /// Get All values.
        /// </summary>
        /// <returns>All values.</returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Value/5
        /// <summary>
        /// Get a value based on an ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A value.</returns>
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Value
        /// <summary>
        /// Insert a value.
        /// </summary>
        /// <param name="value">value to insert</param>
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Value/5
        /// <summary>
        /// Update a value.
        /// </summary>
        /// <param name="id">Id to find value.</param>
        /// <param name="value">value to update with.</param>
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Value/5
        /// <summary>
        /// Delete a value.
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
        }
    }
}
