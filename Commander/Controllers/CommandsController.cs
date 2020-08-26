using System.Collections.Generic;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    //api/commands
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;
        private readonly ICommanderRepoMock _repositoryMock;

        //private readonly MockCommanderRepo _repo = new MockCommanderRepo();

        public CommandsController(ICommanderRepo repository, ICommanderRepoMock repositoryMock)
        {
            _repository = repository;
            _repositoryMock = repositoryMock;
        }

        //GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandsItems = _repository.GetAllCommands();
            return Ok(commandsItems);
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var commandObj = _repository.GetCommandById(id);
            return Ok(commandObj);
        }


        //GET api/commands
        [HttpGet("mock")]
        public ActionResult<IEnumerable<Command>> GetAllCommandsMock()
        {
            var commandsItems = _repositoryMock.GetAllCommandsMock();
            return Ok(commandsItems);
        }

        //GET api/commands/{id}
        [HttpGet("mock/{id}")]
        public ActionResult<Command> GetCommandByIdMock(int id)
        {
            var commandObj = _repositoryMock.GetCommandByIdMock(id);
            return Ok(commandObj);
        }

    }
}