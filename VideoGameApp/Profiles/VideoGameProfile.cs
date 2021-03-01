using AutoMapper;
using VideoGameApp.Dtos;
using VideoGameApp.Entities;

namespace VideoGameApp.Profiles {

    public class VideoGameProfile : Profile {

        public VideoGameProfile() {
            CreateMap<VideoGame, VideoGameDto>();
            CreateMap<VideoGameDto, VideoGame>();
        }
    }
}