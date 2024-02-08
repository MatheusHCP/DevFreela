using System;
namespace DevFreela.Core.Repositories
{
	public class Skill : BaseEntity
	{

		public Skill(string description)
		{
			Description = description;
			CreatedAt = DateTime.Now;
		}

		public string Description{ get; set; }

		public DateTime CreatedAt{ get; set; }


	}
}

