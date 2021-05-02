using Mantenimiento.Helpers;
using Mantenimiento.Models;
using Mantenimiento.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Mantenimiento.Areas.Mantenimiento.Controllers
{
    [Area("Mantenimiento")]
    public class MantenimientoApiController : Controller
    {
        private static readonly HttpClient client = new HttpClient();
        private readonly AppSettings _appSettings;
        public MantenimientoApiController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        #region Vistas
        public IActionResult MantenimientoIndex()
        {
            return View();
        }

        public async Task<PartialViewResult> CrudBaseForm(int? id)
        {
            client.DefaultRequestHeaders.Clear();
            if (id != 0 && id != null)
            {
                var response = await client.GetAsync(_appSettings.ApiUri + "mantenimiento/getcrudbase/?id=" + id);

                string result = await response.Content.ReadAsStringAsync();
                var modelindb = JsonConvert.DeserializeObject<CrudBaseDTO>(result);

                return PartialView("_CrudBaseForm", modelindb);
            }

            return PartialView("_CrudBaseForm", new CrudBaseDTO());
        }

        public async Task<PartialViewResult> DetalleCrudBase(int id)
        {
            client.DefaultRequestHeaders.Clear();
            var response = await client.GetAsync(_appSettings.ApiUri + "mantenimiento/getcrudbase/?id=" + id);

            string result = await response.Content.ReadAsStringAsync();
            var modelindb = JsonConvert.DeserializeObject<CrudBaseDTO>(result);

            return PartialView("_DetalleCrudBase", modelindb);
        }
        #endregion

        #region Datos
        public async Task<JsonResult> GetCrudBases()
        {
            try
            {
                client.DefaultRequestHeaders.Clear();

                var response = await client.GetAsync(_appSettings.ApiUri + "mantenimiento/getcrudbases");

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<List<CrudBaseDTO>>(result);
                    return Json(new { data = data });
                }
                else
                {
                    return Json(new { data = new ResponseModel { result = false, message = response.StatusCode.ToString() } });
                }
            }
            catch (Exception e)
            {
                return Json(new { data = new ResponseModel { result = false, message = e.ToString() } });
            }
        }

        public async Task<JsonResult> Guardar(CrudBaseDTO model)
        {
            try
            {
                string content = JsonConvert.SerializeObject(model);
                HttpContent httpContent = new StringContent(content, Encoding.UTF8, "application/json");

                var result = await client.PostAsync(_appSettings.ApiUri + "mantenimiento/guardar", httpContent);
                string response = await result.Content.ReadAsStringAsync();

                ResponseModel respuesta = JsonConvert.DeserializeObject<ResponseModel>(response);

                return Json(respuesta);
            }
            catch (Exception ex)
            {
                return Json(new ResponseModel() { result = false, message = ex.ToString() });
            }
        }

        public async Task<JsonResult> Eliminar(int id)
        {
            try
            {
                var result = await client.GetAsync(_appSettings.ApiUri + "mantenimiento/eliminar/?id=" + id);

                string response = await result.Content.ReadAsStringAsync();
                ResponseModel respuesta = JsonConvert.DeserializeObject<ResponseModel>(response);

                return Json(respuesta);
            }
            catch (Exception ex)
            {
                return Json(new ResponseModel() { result = false, message = ex.ToString() });
            }
        }

        #endregion
    }
}
