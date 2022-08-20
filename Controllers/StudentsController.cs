using System.Threading.Tasks;
using AspNetMediatr.Domain.Student.Command;
using AspNetMediatr.Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMediatr.Controllers
{
  [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IStudentRepository _studentRepository;
        public StudentsController(IMediator mediator, IStudentRepository studentRepository)
        {
            _mediator = mediator;
            _studentRepository = studentRepository;
        }
        [HttpPost]
        public async Task<IActionResult> Post(StudentCreateCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }
        [HttpPut]
        public async Task<IActionResult> Put(StudentUpdateCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var dto = new StudentDeleteCommand { Id = id };
            var result = await _mediator.Send(dto);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _studentRepository.GetAll();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _studentRepository.GetById(id);
            return Ok(result);
        }
    }
}