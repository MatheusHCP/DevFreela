using DevFreela.Application.Services.Interfaces;
using DevFreela.Infrastructure.Persistence.Repositories;
using DevFreela.Core.Entities;
using DevFreela.Application.ViewModels;
using AutoMapper;

namespace DevFreela.Application.Services.Implementations
{
    public class UserService : IUserService
    {

        private readonly UserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(UserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public UserModel GetUserById(int id)
        {
            var user = _userRepository.get(id);

            var userModel = _mapper.Map<UserModel>(user);

            return userModel;
        }

        public void RegisterUser(NewUserInputModel inputmodel)
        {
            if(inputmodel.FullName.Length > 250)
            {
                throw new Exception("Nome excedeu o limite máximo de 250 caracteres.");
            }

            if (inputmodel.Email.Length > 250)
            {
                throw new Exception("Email excedeu o limite máximo de 250 caracteres.");
            }

            var User = new User(inputmodel.FullName, inputmodel.Email, inputmodel.BirthDate);

            _userRepository.add(User);
        }
    }
}

