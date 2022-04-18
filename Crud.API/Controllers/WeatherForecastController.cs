using Core.Entidade;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Crud.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public List<Pessoa> GetAll()
        {
            return PessoasMock._pessoas;
        }
    }
}
