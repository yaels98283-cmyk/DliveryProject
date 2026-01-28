using Delivery.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Delivery.Core.Services;
using DeliveryProject.Controllers;
using Delivery.Service;
using Delivery.Core.DTOs;
using DeliveryProject.Models;
using AutoMapper;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DeliveryProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliversController : ControllerBase
    {
        private readonly IDeliverService _deliverServ;
        private readonly IMapper _mapper;
        public DeliversController(IDeliverService deliverServ, IMapper mapper)
        {
            _deliverServ = deliverServ;
            _mapper = mapper;
        }
        // GET: api/<DeliversController>
        [HttpGet]
        public async Task<List<DeliversDTO>> Get()
        {
            var lst = await _deliverServ.GetDeliversAsync();
            var DTOlst = new List<DeliversDTO>();
            DTOlst = _mapper.Map<List<DeliversDTO>>(lst);
            return DTOlst;
        }

        // GET api/<DeliversController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var d = await _deliverServ.GetDeliverByIDAsync(id);
            var dDTO = _mapper.Map<DeliversDTO>(d);
            if (d == null)
            {
                return NotFound();
            }
            return Ok(dDTO);
        }

        // POST api/<DeliversController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] DeliversPostModel value)
        {
            var deliver = new Delivers { Name = value.Name, Address = value.Address, PhoneNumber = value.PhoneNumber, Email = value.Email };
            var d = await _deliverServ.GetDeliverByIDAsync(deliver.Id);
            if (d == null)
            {
                var del = await _deliverServ.AddDeliverAsync(deliver);
                return Ok(del);
            }
            return Conflict();

        }

        // PUT api/<DeliversController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] DeliversPostModel value)
        {
            var deliver = new Delivers { Name = value.Name, Address = value.Address, PhoneNumber = value.PhoneNumber, Email = value.Email };
            var d = await _deliverServ.GetDeliverByIDAsync(id);
            if (d == null)
            {
                return NotFound();

            }
            await _deliverServ.UpdateDeliverAsync(id, deliver);
            return Ok(d);
        }

        // DELETE api/<DeliversController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var d = await _deliverServ.GetDeliverByIDAsync(id);
            if (d == null)
            {
                BadRequest();
            }
            return NoContent();
        }
    }
}
