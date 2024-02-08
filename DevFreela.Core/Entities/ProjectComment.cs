using System;
namespace DevFreela.Core.Repositories
{
	public class ProjectComment : BaseEntity
	{
		public ProjectComment(string content, int idproject, int iduser)
		{
			Content = content;
			IdProject = idproject;
			IdUser = iduser;

			CreatedAt = DateTime.Now;
		}

		public string Content { get; set; }

		public int IdProject{ get; set; }

		public int IdUser { get; set; }

		public DateTime CreatedAt { get; set; }
	}
}

