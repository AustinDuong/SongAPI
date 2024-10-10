using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SongAPI.Domain.Services;

using SongAPI.Domain.Models;

namespace SongAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        private readonly ISongService _songService;
        private readonly ILogger<SongController> _logger;

        public SongController(ISongService songService, ILogger<SongController> logger)
        {
            _songService = songService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<Song>>> GetAllSongs()
        {
            try
            {
                var songs = await _songService.GetAllSongs();
                return new OkObjectResult(songs);
            }
            catch (Exception ex)
            {
                {
                    _logger.LogError("Get All Songs failed.", ex);
                    return NotFound();
                }
            }
        }
    }
}
