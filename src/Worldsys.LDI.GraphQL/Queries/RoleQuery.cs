using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Authorization;
using GraphQL;
using GraphQL.Types;
using Microsoft.EntityFrameworkCore;
using Worldsys.LDI.Authorization;
using Worldsys.LDI.Authorization.Roles;
using Worldsys.LDI.Core.Base;
using Worldsys.LDI.Core.Extensions;
using Worldsys.LDI.Dto;
using Worldsys.LDI.Types;

namespace Worldsys.LDI.Queries
{
    public class RoleQuery : LDIQueryBase<ListGraphType<RoleType>, List<RoleDto>>
    {
        private readonly RoleManager _roleManager;

        public static class Args
        {
            public const string Id = "id";
            public const string TenantId = "tenantId";
            public const string Name = "name";
        }

        public RoleQuery(RoleManager roleManager)
            : base("roles", new Dictionary<string, Type>
                {
                    {Args.Id, typeof(IdGraphType)},
                    {Args.TenantId, typeof(IntGraphType)},
                    {Args.Name, typeof(StringGraphType)}
                }
            )
        {
            _roleManager = roleManager;
        }

        [AbpAuthorize(AppPermissions.Pages_Administration_Roles)]
        public override async Task<List<RoleDto>> Resolve(IResolveFieldContext context)
        {
            var query = _roleManager.Roles.AsNoTracking();

            context
                .ContainsArgument<int>(Args.Id, id => query = query.Where(r => r.Id == id))
                .ContainsArgument<string>(Args.TenantId, name => query = query.Where(r => r.Name == name))
                .ContainsArgument<int?>(Args.Name, tenantId => query = query.Where(r => r.TenantId == tenantId.Value));

            return await ProjectToListAsync<RoleDto>(query);
        }
    }
}
