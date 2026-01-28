using Delivery.Core.Services;
using Delivery.Core.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Delivery.Core.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DeliveryProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipientsController : ControllerBase
    {
        private readonly IRecipientService _recipientServ;
        private readonly IMapper _mapper;

        public RecipientsController(IRecipientService recipientServ, IMapper mapper)
        {
            _recipientServ = recipientServ;
            _mapper = mapper;

        }


        // GET: api/<RecipientsController>
        [HttpGet]
        public async Task<List<RecipientsDTO>> Get()
        {
            var rList = await _recipientServ.GetRecipientsAsync();
            var DTOlst = new List<RecipientsDTO>();
            DTOlst = _mapper.Map<List<RecipientsDTO>>(rList);
            return DTOlst;
        }

        // GET api/<RecipientsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var r = await _recipientServ.GetRecipientByIDAsync(id);
            if (r == null)
            {
                return NotFound();
            }
            return Ok(r);
        }

        // POST api/<RecipientsController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Recipients value)
        {
            var recipient = new Recipients { Name = value.Name, Address = value.Address, PhoneNumber = value.PhoneNumber };
            var r = await _recipientServ.GetRecipientByIDAsync(value.Id);
            if (r == null)
            {
                var rec = await _recipientServ.AddRecipientAsync(value);
                return Ok(rec);
            }
            return Conflict();
        }

        // PUT api/<RecipientsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Recipients value)
        {
            var recipient = new Recipients { Name = value.Name, Address = value.Address, PhoneNumber = value.PhoneNumber };
            var r = await _recipientServ.GetRecipientByIDAsync(value.Id);
            if (r == null)
            {
                return BadRequest();

            }
            r.Email = recipient.Email;
            r.Name = recipient.Name;
            r.Address = recipient.Address;
            r.PhoneNumber = recipient.PhoneNumber;
            return Ok(r);
        }

        // DELETE api/<RecipientsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var r = await _recipientServ.GetRecipientByIDAsync(id);
            if (r == null)
            {
                BadRequest();
            }
            return NoContent();
        }
    }
}
