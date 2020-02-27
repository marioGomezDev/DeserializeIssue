using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeserializeIssue.Models;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Data;
using JsonApiDotNetCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DeserializeIssue.Controllers
{
    [Route("api/[controller]")]
    public class PersonsController : JsonApiController<Person>
    {
        private IJsonApiContext jsonApiContext;
        private IResourceService<Person> resourceService;
        private TestDbContext dBContext;

        public PersonsController(
            IJsonApiContext jsonApiContext,
            IResourceService<Person> resourceService,
            ILoggerFactory loggerFactory,
            TestDbContext dBContext)
            : base(jsonApiContext, resourceService, loggerFactory)
        {
            this.jsonApiContext = jsonApiContext;
            this.resourceService = resourceService;
            this.dBContext = dBContext;
        }
    }
}