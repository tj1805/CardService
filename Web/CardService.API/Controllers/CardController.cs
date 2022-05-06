using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CardService.API.Controllers
{
    [ApiController]
    [Route("api/cards")]
    [Authorize]
    public class CardController : ControllerBase
    {
        public CardController()
        {

        }
        // get all cards  by user ID

        //public IActionResult GetUserCardById(Guid userId)
        //{

        //}
        // activate card by Id 

        // deactivate card by id 

        //pin reset on card encryp on Db
    }
}
