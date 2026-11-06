using Microsoft.AspNetCore.Mvc;

namespace TaskManagementApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyTaskController : ControllerBase
    {
        [HttpGet("")]
        public IActionResult GetTasks()
        {
            return Ok();
        }

        [HttpPost("")]
        public IActionResult CreateTask([FromBody] TaskProps task)
        {
            return CreatedAtAction(nameof(GetTasks), new { id = task.ID }, task);
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateTask(int id, [FromBody] TaskProps task)
        {
            if (id != task.ID)
            {
                return BadRequest();
            }

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteTask(int id)
        {
            return NoContent();
        }
    }
}