using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIEmployesSalary.Model.Exception
{
    //internal class ErrorHandlingMiddleware
    //{
    //}
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            //try
            //{
                await _next(context);
            //}
            //catch (Exception ex)
            //{
            //    // Loguear el error (opcional)
            //    context.Response.StatusCode = 500;
            //    context.Response.ContentType = "application/json";
            //    await context.Response.WriteAsync(new { Mensaje = "Ocurrió un error." }.ToString());
            //}
        }
    }
}
