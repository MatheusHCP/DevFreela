using System;
using DevFreela.Core.Enums;

namespace DevFreela.Core.Entities
{
	public class Project : BaseEntity
	{
        public Project(string title, string description, int idclient, int idfreelancer, decimal totalcost)
        {
            Title = title;
            Description = description;
            IdClient = idclient;
            IdFreeLancer = idfreelancer;
            TotalCost = totalcost;

            CreatedAt = DateTime.Now;
            Status = ProjectStatusEnum.Created;
            
        
        }

		public Project()
		{

        }

		public string Title{ get; set; }

		public string Description { get; set; }

		public decimal TotalCost{ get; set; }

		public DateTime CreatedAt{ get; set; }

		public DateTime? StartedAt{ get; set; }

		public DateTime? FinishedAt{ get; set; }

		public ProjectStatusEnum Status { get; set; }

        #region Foreign Key

        public int IdClient { get; set; }

        public int IdFreeLancer { get; set; }

		#endregion

		#region Navigations

		public User User{ get; set; }

		public ICollection<ProjectComment> ProjectComments{ get; set; }

		#endregion

		public void Cancel()
		{
			if (Status == ProjectStatusEnum.InProgress)
			{
				Status = ProjectStatusEnum.Cancelled;
			}
		}

		public void Finish()
		{
			if(Status == ProjectStatusEnum.InProgress)
			{
				Status = ProjectStatusEnum.Finished;
			}
		}

		public void Start()
		{
			if(Status == ProjectStatusEnum.Created)
			{
				Status = ProjectStatusEnum.InProgress;
				StartedAt = DateTime.Now;
			}
		}

		public void Update(string title, string description, decimal totalCost)
		{
			Title = title;
			Description = description;
			TotalCost = totalCost;

		}

	}
}

