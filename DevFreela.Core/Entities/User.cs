using System;
namespace DevFreela.Core.Repositories
{
	public class User : BaseEntity
	{
        public User(string fullName, string email, DateTime birthDate)
        {
			FullName = fullName;
			Email = email;
			BirthDate = birthDate;
			Active = true;
			CreatedAt = DateTime.Now;
			Skills = new List<UserSkill>();
            OwnerProjects = new List<Project>();
            FreelanceProjects = new List<Project>();
        }

        public string FullName{ get; set; }

		public string Email{ get; set; }

		public DateTime BirthDate { get; set; }

		public DateTime CreatedAt{ get; set; }

		public bool Active{ get; set; }

		public List<UserSkill> Skills { get; set; }

        public List<Project> OwnerProjects { get; set; }

        public List<Project> FreelanceProjects { get; set; }


	}
}

