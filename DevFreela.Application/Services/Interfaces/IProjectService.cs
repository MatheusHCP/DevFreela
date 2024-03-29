﻿using System;
using DevFreela.Application.ViewModels;

namespace DevFreela.Application.Services.Interfaces
{
	public interface IProjectService
	{
		List<ProjectViewModel> GetAll(string query);

		ProjectDetailsViewModel GetById(int id);

		int Create(NewProjectInputModel inputModelProject);

		void Update(UpdateProjectInputModel inputModel);

		void CreateComment(CreateCommentInputModel inputModel);

		void Delete(int id);

		void Start(int id);

		void Finish(int id);
	}
}

