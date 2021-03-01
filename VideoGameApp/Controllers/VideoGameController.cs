using Microsoft.AspNetCore.Mvc;
using VideoGameApp.Dtos;
using VideoGameApp.Services;

namespace VideoGameApp.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class VideoGameController : ControllerBase {
        private readonly IVideoGameService videoGameService;

        public VideoGameController(IVideoGameService videoGameService) {
            this.videoGameService = videoGameService;
        }

        [HttpGet]
        public IActionResult Get() {
            var videoGameDtos = videoGameService.GetVideoGames();
            return Ok(videoGameDtos);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id) {
            var videoGameDtos = videoGameService.GetVideoGame(id);
            return Ok(videoGameDtos);
        }

        [HttpPut]
        public IActionResult UpdateVideoGame([FromBody] VideoGameDto videoGame) {
            videoGameService.UpdateVideoGames(videoGame);
            return Ok();
        }
    }
}