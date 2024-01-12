using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Twitter.Business.Services.Interfaces;

namespace TwitFriday.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommitsController : ControllerBase
    {
        ICommentService _commentService {  get; set; }

        public CommitsController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_commentService.GetAll());
        }
    }
}
