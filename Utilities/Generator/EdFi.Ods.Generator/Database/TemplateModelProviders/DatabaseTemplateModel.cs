using System.Collections.Generic;
using EdFi.Ods.Common.Models.Dynamic;

namespace EdFi.Ods.Generator.Database.TemplateModelProviders
{
    public class DatabaseTemplateModel : DynamicModelBase
    {
        public IEnumerable<SchemaInfo> Schemas { get; set; }

        public IEnumerable<Table> Tables { get; set; }
    }
}