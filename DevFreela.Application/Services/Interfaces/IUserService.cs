using System;
using DevFreela.Application.ViewModels;

namespace DevFreela.Application.Services.Interfaces
{
    public interface IUserService
    {
        void RegisterUser(NewUserInputModel inputmodel);
        UserModel GetUserById(int id);
    }
}
