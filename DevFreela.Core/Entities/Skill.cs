using System;
namespace DevFreela.Core.Repositories
{
	public class Skill : BaseEntity
	{

		public Skill()
		{

		}

		public string Description{ get; set; }

		public DateTime CreatedAt{ get; set; }


	}
}

