using AutoMapper;
using CoreWebAPI.Dtos;
using CoreWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebAPI.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            //Source -> Target
            CreateMap<Command, CommandReadDto>();//map operation para usar con el GET
            CreateMap<CommandCreateDto, Command>();//map operation para usar con el POST
            CreateMap<CommandUpdateDto, Command>();//map operation para usar con PUT
            CreateMap<Command, CommandUpdateDto>();//map operation para usar con PATCH
        }

    }
}
