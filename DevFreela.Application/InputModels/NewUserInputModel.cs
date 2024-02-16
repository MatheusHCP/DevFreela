using System;

namespace DevFreela.Application.Services.Interfaces
{
	public interface NewUserInputModel
	{
		public string FullName{ get; set; }

		public string Email{ get; set; }

		public DateTime BirthDate{ get; set; }
	}
}

