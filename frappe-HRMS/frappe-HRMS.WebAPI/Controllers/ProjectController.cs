using frappe_HRMS.Domain.Projects;
using frappe_HRMS.Services.Interfaces.Projects;
using Microsoft.AspNetCore.Mvc;

namespace frappe_HRMS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController(IProjectService projectService,IProjectTemplateService projectTemplateService,
        ITaskService taskService,IProjectTypeService projectTypeService,IProjectUpdateService projectUpdateService) : ControllerBase
    {
        [HttpPost("CreateProject")]
        public async Task<ActionResult<Project>> CreateProject(Project project)
        {
            var result = await projectService.AddAsync(project);
            return result;
        }

        [HttpGet("GetAllProjects")]
        public async Task<ActionResult<List<Project>>> GetAllProjects()
        {
            var result = await projectService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetProjectById")]
        public async Task<ActionResult<Project>> GetProjectById(int id)
        {
            try
            {
                var result = projectService.GetById(id);
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
            var result = await projectService.Update(project);
            return result;
        }
        [HttpPost("CreateProjectTemplate")]
        public async Task<ActionResult<ProjectTemplate>> CreateProjectTemplate(ProjectTemplate projectTemplate)
        {
            var result = await projectTemplateService.AddAsync(projectTemplate);
            return result;
        }

        [HttpGet("GetAllProjectTemplates")]
        public async Task<ActionResult<List<ProjectTemplate>>> GetAllProjectTemplates()
        {
            var result = await projectTemplateService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetProjectTemplateById")]
        public async Task<ActionResult<ProjectTemplate>> GetProjectTemplateById(int id)
        {
            try
            {
                var result = projectTemplateService.GetById(id);
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
            var result = await projectTemplateService.Update(projectTemplate);
            return result;
        }
        [HttpPost("CreateProjectType")]
        public async Task<ActionResult<ProjectType>> CreateProjectType(ProjectType projectType)
        {
            var result = await projectTypeService.AddAsync(projectType);
            return result;
        }

        [HttpGet("GetAllProjectTypes")]
        public async Task<ActionResult<List<ProjectType>>> GetAllProjectTypes()
        {
            var result = await projectTypeService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetProjectTypeById")]
        public async Task<ActionResult<ProjectType>> GetProjectTypeById(int id)
        {
            try
            {
                var result = projectTypeService.GetById(id);
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
            var result = await projectTypeService.Update(projectType);
            return result;
        }
        [HttpPost("CreateTask")]
        public async Task<ActionResult<Domain.Projects.Task>> CreateTask(Domain.Projects.Task task)
        {
            var result = await taskService.AddAsync(task);
            return result;
        }

        [HttpGet("GetAllTasks")]
        public async Task<ActionResult<List<Domain.Projects.Task>>> GetAllTasks()
        {
            var result = await taskService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetTaskById")]
        public async Task<ActionResult<Domain.Projects.Task>> GetTaskById(int id)
        {
            try
            {
                var result = taskService.GetById(id);
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
            var result = await taskService.Update(task);
            return result;
        }
        [HttpPost("CreateProjectUpdate")]
        public async Task<ActionResult<ProjectUpdate>> CreateProjectUpdate(ProjectUpdate projectUpdate)
        {
            var result = await projectUpdateService.AddAsync(projectUpdate);
            return result;
        }

        [HttpGet("GetAllProjectUpdates")]
        public async Task<ActionResult<List<ProjectUpdate>>> GetAllProjectUpdates()
        {
            var result = await projectUpdateService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetProjectUpdateById")]
        public async Task<ActionResult<Project>> GetProjectUpdateById(int id)
        {
            try
            {
                var result = projectUpdateService.GetById(id);
                if (result == null)
                {
                    return NotFound($"Project Update with Id = {id} not found.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("EditProjectUpdate")]
        public async Task<ActionResult<ProjectUpdate>> EditProjectUpdate(ProjectUpdate projectUpdate)
        {
            var result = await projectUpdateService.Update(projectUpdate);
            return result;
        }
    }
}
