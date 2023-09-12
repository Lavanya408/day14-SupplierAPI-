using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        //[HttpGet]
        //public string Get() 
        //{
        // return "Hello";
        //}
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(new string[] { "Hello", "Hi", "Welcome", "Bye" });
        }
        [HttpGet("GetById")]
        public ActionResult GetAnother(int idx)
        {
            return Ok(new string[] { "Hello", "Hi", "Welcome", "Bye" }[idx]);
        }
        [HttpPost]
        public ActionResult Lavanya(string name)
        {
            if (name.Length > 3)
                return Ok(name);
            return BadRequest();
        }
        [HttpPut]
        public ActionResult Hindu(student student)
        {
            if (student.Id == 101)
            {
                student.Name = "laav";
                return Ok(student);
            }

            return BadRequest();
        }
        [HttpDelete]
        public ActionResult siva(int id)
        {
            if (id == 101)
                return Ok();
            return Ok();
        }

        public class student
        {

            public int Id { get; set; }


            public string Name { get; set; }
        }
    }



}