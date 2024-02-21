using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Infrastructure.Persistence;

namespace DevFreela.Application.Services.Implementations
{
    public class UserService : IUserService
    {

        private readonly DevFreelaDbContext _dbContext;

        public UserService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void RegisterUser(NewUserInputModel inputmodel)
        {
            if(inputmodel.FullName.Length > 250)
            {
                throw new Exception("Nome excedeu o limite máximo de 250 caracteres.");
            }

        }
    }
}

