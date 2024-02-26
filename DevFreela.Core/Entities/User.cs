using System;
namespace DevFreela.Core.Entities
{
	public class User : BaseEntity
	{
        public User(string fullName, string email, DateTime birthDate, string password)
        {
			FullName = fullName;
			Email = email;
			BirthDate = birthDate;
			Active = true;
			CreatedAt = DateTime.Now;
			Password = password;
			
        }

		public User()
		{

		}

        public string FullName{ get; set; }

		public string Email{ get; set; }

		public DateTime BirthDate { get; set; }

		public DateTime CreatedAt{ get; set; }

		public string Password { get; set; }

		public bool Active{ get; set; }



		#region Navigations

		public ICollection<Project> Projects{ get; set; }

        public ICollection<UserSkill> UserSkills { get; set; }

        public ICollection<ProjectComment> ProjectComments { get; set; }


        #endregion


    }
}

