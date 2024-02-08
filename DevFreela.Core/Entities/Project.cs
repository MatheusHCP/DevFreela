using System;
using DevFreela.Core.Enums;

namespace DevFreela.Core.Repositories
{
	public class Project : BaseEntity
	{
		public Project(string title, string description, int idclient, int idfreelancer, decimal totalcost)
		{
			Title = title;
			Description = description;
			idClient = idclient;
			idFreeLancer = idfreelancer;
			TotalCost = totalcost;

			CreatedAt = DateTime.Now;
			Status = ProjectStatusEnum.Created;
			Comments = new List<ProjectComment>();


		}

		public string Title{ get; set; }

		public string Description { get; set; }

		public int idClient{ get; set; }

		public int idFreeLancer{ get; set; }

		public decimal TotalCost{ get; set; }

		public DateTime CreatedAt{ get; set; }

		public DateTime? StartedAt{ get; set; }

		public DateTime? FinishedAt{ get; set; }

		public ProjectStatusEnum Status { get; set; }

		public List<ProjectComment> Comments{ get; set; }



	}
}

