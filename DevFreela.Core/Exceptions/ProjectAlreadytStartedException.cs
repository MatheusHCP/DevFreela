using System;
namespace DevFreela.Core.Exceptions
{
	public class ProjectAlreadytStartedException : Exception
	{
		// o base ele vai utilizar o construtor da interface PAI do projeto que no caso é o Exception.
		public ProjectAlreadytStartedException() : base("Project is already in started status")
		{

		}
	}
}

