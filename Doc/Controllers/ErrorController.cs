using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Doc.CL04Core.CLCoreShared.ModelViewls;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Doc.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [ApiController]         
    public class ErrorController : ControllerBase
    {
        [Route("error")]
        public ErrorResponse Error()
        {
            var contexto = HttpContext.Features.Get<IExceptionHandlerFeature>();
            var expetion = contexto?.Error;
            
            Response.StatusCode = 500;
            var idErro = Activity.Current?.Id ?? HttpContext?.TraceIdentifier;
            return new ErrorResponse(idErro);
        }

    }
}