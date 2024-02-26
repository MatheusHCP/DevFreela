using System;
using AutoMapper;
using DevFreela.Application.ViewModels;
using DevFreela.Core.Entities;

namespace DevFreela.Application.Mapping
{
	public class UserProfile : Profile
	{
		public UserProfile()
		{
			CreateMap<User, UserModel>();
            CreateMap<UserModel, User>();
        }
	}
}

