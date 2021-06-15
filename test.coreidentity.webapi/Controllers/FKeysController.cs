using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.coreidentity.core.Interfaces;

namespace test.coreidentity.webapi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    public class FKeysController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        public readonly IFKeysRepository fKeysRepository;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fKeysRepository"></param>
        public FKeysController(IFKeysRepository fKeysRepository)
        {
            this.fKeysRepository = fKeysRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost("add")]
        [ProducesResponseType(typeof(string), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddRecordsToTablesN()
        {
            await fKeysRepository.CreateData();
            return StatusCode(StatusCodes.Status204NoContent);
        }
    }
}
