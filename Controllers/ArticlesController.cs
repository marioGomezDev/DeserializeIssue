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
    public class ArticlesController : JsonApiController<Article>
    {
        private IJsonApiContext jsonApiContext;
        private IResourceService<Article> resourceService;
        private TestDbContext dBContext;

        public ArticlesController(
            IJsonApiContext jsonApiContext,
            IResourceService<Article> resourceService,
            ILoggerFactory loggerFactory,
            TestDbContext dBContext)
            : base(jsonApiContext, resourceService, loggerFactory)
        {
            this.jsonApiContext = jsonApiContext;
            this.resourceService = resourceService;
            this.dBContext = dBContext;
        }

        public override async Task<IActionResult> PostAsync([FromBody] Article entity)
        {
            entity = await resourceService.CreateAsync(entity);

            return Created($"{HttpContext.Request.Path}/{entity.Id}", entity);
        }
    }
}