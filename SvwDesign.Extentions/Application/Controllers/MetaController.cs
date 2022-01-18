using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace SvwDesign.Extensions.Controllers
{
    public class MetaController : ApiControllerBase
    {
        [HttpGet("/info")]
        public ActionResult<string> Info()
        {
            var assembly = typeof(DependencyInjection).Assembly;

            var creationDate = System.IO.File.GetCreationTime(assembly.Location);
            var version = FileVersionInfo.GetVersionInfo(assembly.Location).ProductVersion;

            return Ok($"Version: {version}, Last Updated: {creationDate}");
        }
    }
}
