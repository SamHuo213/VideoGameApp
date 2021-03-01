using System.Collections.Generic;
using VideoGameApp.Dtos;

namespace VideoGameApp.Services {

    public interface IVideoGameService {

        public IEnumerable<VideoGameDto> GetVideoGames();

        public VideoGameDto GetVideoGame(int id);

        public void UpdateVideoGames(VideoGameDto videoGameDto);
    }
}