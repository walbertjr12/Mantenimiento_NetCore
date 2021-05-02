using Mantenimiento.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Mantenimiento.Areas.Empleados.Controllers
{
    [Area("Empleados")]
    public class EmpleadoController : Controller
    {
        private static readonly HttpClient client = new HttpClient();
        private readonly AppSettings _appSettings;
        public EmpleadoController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        public IActionResult EmpleadoIndex()
        {
            return View();
        }
    }
}
