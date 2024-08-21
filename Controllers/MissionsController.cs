using FinalProjectAPI.Models.BaseModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProjectAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MissionsController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Update()
        {
            // רענון הסוכנים לכיוון המטרה, אם יש להם כזו
            
            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            // שליפת כל המשימות ממסד הנתונים
            
            return Ok();
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> MissionConfirmation([FromBody] MissionStatus status)
        {
            // המשתמש שולח עדכון סטטוס ובכל מאשר יציאה למשימה
            
            return Ok();
        }
    }
}
