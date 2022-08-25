using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebPractica.Models;

namespace WebPractica.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly string cadenaSQL;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

      

        public HomeController(IConfiguration config)
        {
            cadenaSQL = config.GetConnectionString("DefaultConnection");
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult ExportarExcel()
        {
            DataTable TablaRegistros = new DataTable();


            using (var conexion = new SqlConnection(cadenaSQL))
            {
                conexion.Open();
                using (var adapter = new SqlDataAdapter())
                {

                    adapter.SelectCommand = new SqlCommand("sp_reporte_registros", conexion);
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                    adapter.Fill(TablaRegistros);
                }
            }

            using (var libro = new XLWorkbook())
            {
                TablaRegistros.TableName = "Registros";
                var hoja = libro.Worksheets.Add(TablaRegistros);
                hoja.ColumnsUsed().AdjustToContents();

                using (var memoria = new MemoryStream())
                {
                    libro.SaveAs(memoria);
                    var nombreExcel = string.Concat("Reporte Registros ", DateTime.Now.ToString(), ".xlsx");
                    return File(memoria.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nombreExcel);
                }
            }
        }
    
    }
}
