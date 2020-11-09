using DeserializeIssue.Models;
using JsonApiDotNetCore.Configuration;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using Microsoft.Extensions.Logging;

namespace DeserializeIssue.Controllers
{
    //[Route("api/[controller]")]
    public class PersonsController : JsonApiController<Person>
    {
        public PersonsController(IJsonApiOptions options, ILoggerFactory loggerFactory, IResourceService<Person, int> resourceService) 
            : base(options, loggerFactory, resourceService)
        {
        }
    }
}