using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecordAPI.Models.Domain_Models;
using RecordAPI.Models.View_Models;
using RecordAPI.Services;

namespace RecordAPI.Controllers
{
    [Route("api/[controller]/records")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IRecord _service;

        public ValuesController(IRecord service)
        {
            _service = service;
        }

        // GET api/values/records/ascending
        [HttpGet("ascending")]
        public async Task<IEnumerable<Record>> GetRecordsAscending()
        {
            return await _service.GetAllRecordsAscending();
        }

        // GET api/values/records/descending
        [HttpGet("descending")]
        public async Task<IEnumerable<Record>> GetRecordsDescending()
        {
            return await _service.GetAllRecordsDescending();
        }

        // GET api/values/records/id
        [HttpGet("{id}")]
        public async Task<Record> Get(int id)
        {
            return await _service.GetRecordById(id);
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody] Record record)
        {
            if (!ModelState.IsValid)
                return BadRequest("What a bad request. Perhaps a validation error?");
            else
                _service.CreateRecord(record);
                return Ok();
        }

        [HttpGet("owner")]
        public async Task<IActionResult> GetByOwner([FromBody] User user)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            else
            {
                var data = await _service.GetRecordsByOwner(user.FirstName + " " + user.LastName);
                return Ok(data);
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
