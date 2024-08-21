using FinalProjectAPI.Data;
using FinalProjectAPI.Models.AuxiliaryModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProjectAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TargetsController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        public TargetsController(AppDbContext db)
        {
            _dbContext = db;
        }
        
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateTarget target)
        {
            // כאן צריך להכניס לוגיקה שמייצרת מטרה במסד הנתונים ומחזירה את המזהה שנוצר

            // אח"כ צריך לחשב מחדש את הצעות המשימות

            return Created("", new { Id = "234"}); // בינתיים יש פה מספר לדוגמא
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            // כאן צריך להשיג א רשימת כל המטרות הקיימות

            return Ok();  // להחזיר כאן את אובייקט הרשימה
        }

        [HttpPut]
        [Route("{id}/pin")]
        public async Task<IActionResult> Pin([FromBody] Location location)
        {
            // לוגיקה שקובעת מטרה שזה עתה נוצרה ונותנת לה נקודות על הצירים
            
            return Ok();
        }

        [HttpPut]
        [Route("{id}/move")]
        public async Task<IActionResult> Move([FromBody] Direction direction)
        {
            // לוגיקה שמעדכנת את המיקום לפי המזהה שנשלח

            return Ok();
        }
    }
}
