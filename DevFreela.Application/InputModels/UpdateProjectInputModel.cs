using System;
namespace DevFreela.Application.ViewModels
{
	public class UpdateProjectInputModel
	{
        public int Id { get; set; }

        public required string Title { get; set; }

        public required string Description { get; set; }

        public decimal TotalCost { get; set; }
    }
}

