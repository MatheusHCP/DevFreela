using System;

namespace DevFreela.Application.ViewModels
{
	public class NewUserInputModel
	{
		public required string FullName{ get; set; }

		public required string Email{ get; set; }

		public DateTime BirthDate{ get; set; }
	}
}

