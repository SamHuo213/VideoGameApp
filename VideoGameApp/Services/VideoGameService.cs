using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using VideoGameApp.Context;
using VideoGameApp.Dtos;
using VideoGameApp.Entities;

namespace VideoGameApp.Services {

    public class VideoGameService : IVideoGameService {
        private readonly IMapper mapper;
        private readonly ApplicationDbContext applicationDbContext;

        public VideoGameService(IMapper mapper, ApplicationDbContext applicationDbContext) {
            this.mapper = mapper;
            this.applicationDbContext = applicationDbContext;
        }

        public IEnumerable<VideoGameDto> GetVideoGames() {
            return mapper.Map<IEnumerable<VideoGameDto>>(applicationDbContext.VideoGames);
        }

        public VideoGameDto GetVideoGame(int id) {
            var videoGames = applicationDbContext.VideoGames.Where(x => x.Id == id);
            return mapper.Map<VideoGameDto>(videoGames.FirstOrDefault());
        }

        public void UpdateVideoGames(VideoGameDto videoGameDto) {
            var videoGameExist = applicationDbContext.VideoGames.Any(x => x.Id == videoGameDto.Id);
            if ( !videoGameExist ) {
                return;
            }

            applicationDbContext
                .VideoGames
                .Update(mapper.Map<VideoGame>(videoGameDto));

            applicationDbContext.SaveChanges();
        }
    }
}