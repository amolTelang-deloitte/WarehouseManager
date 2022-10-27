using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace IdentityServer.API.Filter
{
    public class ErrorHandlingFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var exception = context.Exception;
            var errorResult = "An error occured while processing your request";
            context.Result = new ObjectResult(errorResult)
            {
                StatusCode = 500
            };
            context.ExceptionHandled = true;
        }
    }
}
