using System;
namespace DevFreela.Core.Repositories
{
	public class UserSkill : BaseEntity
	{
		public UserSkill(int idUser, int idSkill)
		{
			IdUser = idUser;
			IdSkill = idSkill;
		}

		public UserSkill()
		{

		}

		public int IdUser{ get; set; }

		public int IdSkill { get; set; }


		#region Navigations

		public User User{ get; set; }

		public Skill Skill{ get; set; }

		#endregion
	}
}

