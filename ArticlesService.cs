using DeserializeIssue.Models;
using JsonApiDotNetCore.Data;
using JsonApiDotNetCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeserializeIssue
{
    public class ArticlesService : EntityResourceService<Article>
    {
        public ArticlesService(
            IJsonApiContext jsonApiContext,
            IEntityRepository<Article> repository)
        : base(jsonApiContext, repository)
        {
        }

        public override async Task<Article> CreateAsync(Article entity)
        {
            // call the base implementation which uses Entity Framework
            var newEntity = await base.CreateAsync(entity);

            return newEntity;
        }
    }
}
