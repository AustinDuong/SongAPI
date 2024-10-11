using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SongAPI.Domain.Services;

using SongAPI.Domain.Models;
using Microsoft.AspNetCore.Authorization;

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

        [HttpGet("GetAllSongs")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
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

        [HttpGet("GetSong/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<Song>>> GetSong(int id)
        {
            try
            {
                var song = await _songService.GetSong(id);
                return new OkObjectResult(song);
            }
            catch (Exception ex)
            {
                {
                    _logger.LogError("Get Song with ID: " + id + " failed.", ex);
                    return NotFound();
                }
            }
        }

        [HttpPost("AddSong")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize] // Authentication Required for modifying Data
        public async Task<ActionResult> AddSong(Song song)
        {
            try
            {
                await _songService.AddSong(song);
                return CreatedAtAction(nameof(GetSong), new { id = song.Id }, song);
            }
            catch (Exception ex)
            {
                {
                    _logger.LogError("Add Song " + song + " failed.", ex);
                    return BadRequest();
                }
            }
        }

        [HttpPut("UpdateSong")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize] // Authentication Required for modifying Data
        public async Task<ActionResult> UpdateSong(Song updatedSong)
        {
            try
            {
                await _songService.UpdateSong(updatedSong);
                return Ok();
            }
            catch (Exception ex)
            {
                {
                    _logger.LogError("Update Song " + updatedSong + " failed.", ex);
                    return BadRequest();
                }
            }
        }

        [HttpDelete("DeleteSong")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize] // Authentication Required for modifying Data
        public async Task<ActionResult> DeleteSong(int id)
        {
            try
            {
                await _songService.DeleteSong(id);
                return Ok();
            }
            catch (Exception ex)
            {
                {
                    _logger.LogError("Delete Song with ID: " + id + " failed.", ex);
                    return BadRequest();
                }
            }
        }
    }
}
