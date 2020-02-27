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
    public class StudentsController : JsonApiController<Student>
    {
        private IJsonApiContext jsonApiContext;
        private IResourceService<Student> resourceService;
        private TestDbContext dBContext;

        public StudentsController(
            IJsonApiContext jsonApiContext,
            IResourceService<Student> resourceService,
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