using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
 using Syncfusion.XlsIO;
using System.IO;

namespace Api.ExcelReader.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController2 : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController2(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            ExcelEngine excelEngine = new ExcelEngine();

            //Instantiate the Excel application object
            IApplication application = excelEngine.Excel;

            //Assigns default application version
            application.DefaultVersion = ExcelVersion.Excel2013;

            //A existing workbook is opened.              
            string basePath = @"C:\12\123.xlsx";
            FileStream sampleFile = new FileStream(basePath, FileMode.Open);

            IWorkbook workbook = application.Workbooks.Open(sampleFile);

            //Access first worksheet from the workbook.
            IWorksheet worksheet = workbook.Worksheets[0];

            //Set Text in cell A3.
            worksheet.Range["A3"].Text = "Hello World";
            var a = worksheet.Rows[0].Cells[0].Value2;
            List<string> list = new List<string>();
            Dictionary<int, List<string>> countries = new Dictionary<int,  List<string>>();
      
            var i = 0;
            for(i = 0 ; i < worksheet.Rows.Length; i ++ )
            {
                var j = 0;
                var listJ = new List<string>();
                for (j = 0; j < worksheet.Rows[i].Cells.Length; j++)
                {
                    listJ.Add(worksheet.Rows[i].Cells[j].Value);
                }
                countries.Add(i, listJ);
            }

            //var a2 = worksheet.Rows[0].Cells[0].Value;
            var a22 = worksheet.Rows[1].Cells[4].Value;
            //Defining the ContentType for excel file.
            string ContentType = "Application/msexcel";

            //Define the file name.
            string fileName = "Output.xlsx";

            //Creating stream object.
            MemoryStream stream = new MemoryStream();

            //Saving the workbook to stream in XLSX format
            workbook.SaveAs(stream);

            stream.Position = 0;

            //Closing the workbook.
            workbook.Close();

            //Dispose the Excel engine
            excelEngine.Dispose();

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
