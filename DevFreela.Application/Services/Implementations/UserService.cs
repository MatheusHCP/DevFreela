using DevFreela.Application.Services.Interfaces;
using DevFreela.Infrastructure.Persistence.Repositories;
using DevFreela.Core.Entities;
using DevFreela.Application.ViewModels;

namespace DevFreela.Application.Services.Implementations
{
    public class UserService : IUserService
    {

        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
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

