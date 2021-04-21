using Abp.Dependency;
using GraphQL.Types;
using GraphQL.Utilities;
using Worldsys.LDI.Queries.Container;
using System;

namespace Worldsys.LDI.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IServiceProvider provider) :
            base(provider)
        {
            Query = provider.GetRequiredService<QueryContainer>();
        }
    }
}