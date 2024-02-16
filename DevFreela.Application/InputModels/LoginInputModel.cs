using System;

namespace DevFreela.Application.Services.Interfaces
{
	public interface LoginInputModel
	{
		public string Email{ get; set; }

        public string Password { get; set; }
    }
}

