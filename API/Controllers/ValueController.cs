using System.Collections.Generic;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ValueController : ControllerBase
  {
    [HttpGet]
    public IEnumerable<string> Values()
    {
      return new string[] { "value1", "value2" };
    }
  }
}