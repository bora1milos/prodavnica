using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Description;
using Swashbuckle.Swagger;

namespace UpraviteljPodataka.App_Start
{
    public class AuthorizationOperationFilter : IOperationFilter
    {
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            if (operation.parameters == null)
            {
                operation.parameters = new List<Parameter>();
            }

            operation.parameters.Add(
                new Parameter
                {
                    type = "string",
                    name = "Authorization",
                    required = false,
                    description = "access token",
                    @in = "header"
                });
        }
    }
}