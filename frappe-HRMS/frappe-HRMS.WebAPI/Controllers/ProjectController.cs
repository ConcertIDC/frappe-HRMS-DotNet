using frappe_HRMS.Domain.Claim;
using frappe_HRMS.Domain.Projects;
using frappe_HRMS.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace frappe_HRMS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController(IUnitOfWork unitOfWork) : ControllerBase
    {
        [HttpPost("CreateProject")]
        public async Task<ActionResult<Project>> CreateProject(Project project)
        {
            var result = await unitOfWork.Project.AddAsync(project);
            return result;
        }

        [HttpGet("GetAllProjects")]
        public async Task<ActionResult<List<Project>>> GetAllProjects()
        {
            var result = await unitOfWork.Project.GetAll();
            return Ok(result);
        }
        [HttpGet("GetProjectById")]
        public async Task<ActionResult<Project>> GetProjectById(int id)
        {
            try
            {
                var result = unitOfWork.Project.GetById(id);
                if (result == null)
                {
                    return NotFound($"Project with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("EditProject")]
        public async Task<ActionResult<Project>> EditProject(Project project)
        {
            var result = unitOfWork.Project.Update(project);
            await unitOfWork.Save();
            return result;
        }
        [HttpPost("CreateProjectTemplate")]
        public async Task<ActionResult<ProjectTemplate>> CreateProjectTemplate(ProjectTemplate projectTemplate)
        {
            var result = await unitOfWork.ProjectTemplate.AddAsync(projectTemplate);
            return result;
        }

        [HttpGet("GetAllProjectTemplates")]
        public async Task<ActionResult<List<ProjectTemplate>>> GetAllProjectTemplates()
        {
            var result = await unitOfWork.ProjectTemplate.GetAll();
            return Ok(result);
        }
        [HttpGet("GetProjectTemplateById")]
        public async Task<ActionResult<ProjectTemplate>> GetProjectTemplateById(int id)
        {
            try
            {
                var result = unitOfWork.ProjectTemplate.GetById(id);
                if (result == null)
                {
                    return NotFound($"ProjectTemplate with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("EditProjectTemplate")]
        public async Task<ActionResult<ProjectTemplate>> EditProjectTemplate(ProjectTemplate projectTemplate)
        {
            var result = unitOfWork.ProjectTemplate.Update(projectTemplate);
            await unitOfWork.Save();
            return result;
        }
        [HttpPost("CreateProjectType")]
        public async Task<ActionResult<ProjectType>> CreateProjectType(ProjectType projectType)
        {
            var result = await unitOfWork.ProjectType.AddAsync(projectType);
            return result;
        }

        [HttpGet("GetAllProjectTypes")]
        public async Task<ActionResult<List<ProjectType>>> GetAllProjectTypes()
        {
            var result = await unitOfWork.ProjectType.GetAll();
            return Ok(result);
        }
        [HttpGet("GetProjectTypeById")]
        public async Task<ActionResult<ProjectType>> GetProjectTypeById(int id)
        {
            try
            {
                var result = unitOfWork.ProjectType.GetById(id);
                if (result == null)
                {
                    return NotFound($"ProjectType with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("EditProjectType")]
        public async Task<ActionResult<ProjectType>> EditProjectType(ProjectType projectType)
        {
            var result = unitOfWork.ProjectType.Update(projectType);
            await unitOfWork.Save();
            return result;
        }
        [HttpPost("CreateTask")]
        public async Task<ActionResult<Domain.Projects.Task>> CreateTask(Domain.Projects.Task task)
        {
            var result = await unitOfWork.Task.AddAsync(task);
            return result;
        }

        [HttpGet("GetAllTasks")]
        public async Task<ActionResult<List<Domain.Projects.Task>>> GetAllTasks()
        {
            var result = await unitOfWork.Task.GetAll();
            return Ok(result);
        }
        [HttpGet("GetTaskById")]
        public async Task<ActionResult<Domain.Projects.Task>> GetTaskById(int id)
        {
            try
            {
                var result = unitOfWork.Task.GetById(id);
                if (result == null)
                {
                    return NotFound($"Project Task with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("EditTask")]
        public async Task<ActionResult<Domain.Projects.Task>> EditTask(Domain.Projects.Task task)
        {
            var result = unitOfWork.Task.Update(task);
            await unitOfWork.Save();
            return result;
        }
    }
}
