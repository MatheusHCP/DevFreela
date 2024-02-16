using System;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
	[Route("api/projects")]
	public class ProjectsController : ControllerBase
	{

		private readonly IProjectService _projectService;

		public ProjectsController(IProjectService projectService)
		{
			_projectService = projectService;
		}

		// api/projects

		[HttpGet]
		public IActionResult GetAll(string query)
		{

			var projects = _projectService.GetAll(query);
			
			return Ok(projects);
		}

		// api/projects/1

        [HttpGet("{Id}")]
        public IActionResult GetById(int Id)
        {

            var project = _projectService.GetById(Id);

			if (project == null)
				return NoContent();

            return Ok(project);
        }

		[HttpPost]
		public IActionResult Post([FromBody] NewProjectInputModel inputModel)
		{
			if(inputModel.Title.Length > 20)
			{
				return BadRequest();
			}

			var id = _projectService.Create(inputModel);

			return CreatedAtAction(nameof(GetById), new {id}, inputModel);
		}

        [HttpPut]
        public IActionResult Put([FromBody] UpdateProjectInputModel updateProject)
		{

            if (updateProject.Title.Length > 20)
            {
                return BadRequest();
            }

            _projectService.Update(updateProject);

            return Ok();
		}

		
		[HttpDelete]
		public IActionResult Delete(int id)
		{
			_projectService.Delete(id);

			return Ok();
		}

		[HttpPost("{id}/comments")]
		public IActionResult PostComment (int id, [FromBody] CreateCommentInputModel inputModel)
		{
			_projectService.CreateComment(inputModel);

			return Ok();
		}

		[HttpPut("{id}/start")]
		public IActionResult Start(int Id)
		{
			_projectService.Start(Id);

			return Ok();
		}

		[HttpPut("{id}/finish")]
		public IActionResult Finish(int id)
		{
			_projectService.Finish(id);

			return Ok();
		}
    }
}

