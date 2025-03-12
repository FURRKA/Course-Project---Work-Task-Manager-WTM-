﻿using AutoMapper;
using BLL.DTO;
using DAL.Entities;

namespace BLL.Profiles
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<Project, ProjectDTO>().ReverseMap();
            CreateMap<WorkTask, TaskDTO>().ReverseMap();
            CreateMap<Comment, CommentDTO>().ReverseMap();
            CreateMap<Tag, TagDTO>().ReverseMap();
        }
    }
}
