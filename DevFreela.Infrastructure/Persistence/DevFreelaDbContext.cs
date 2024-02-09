using System;
using DevFreela.Core.Repositories;

namespace DevFreela.Infrastructure.Persistence
{
	public class DevFreelaDbContext
	{

		public DevFreelaDbContext()
		{
			Projects = new List<Project>
			{
				new Project("Meu Projecto ASPNET Core 1", "Minha Descricao de Projecto 1", 1, 1, 10000),
				new Project("Meu Projecto ASPNET Core 2", "Minha Descricao de Projecto 2", 1, 1, 20000),
				new Project("Meu Projecto ASPNET Core 3", "Minha Descricao de Projecto 3", 1, 1, 30000)
			};

			Users = new List<User> {
				new User("Matheus Pereira", "teste@teste.com", new DateTime(1998,10,10)),
				new User("Robernilson Levis", "teste2@teste.com", new DateTime(2002,08,05)),
				new User("John Do", "teste3@teste.com", new DateTime(1958,05,02))
			};

			Skills = new List<Skill>
			{
				new Skill(".NET Core"),
                new Skill("C#"),
                new Skill("MySQL")
            };
		}

		public List<Project> Projects { get; set; }

		public List<User> Users{ get; set; }

		public List<Skill> Skills{ get; set; }

        public List<ProjectComment> ProjectComments { get; set; }
    }
}

