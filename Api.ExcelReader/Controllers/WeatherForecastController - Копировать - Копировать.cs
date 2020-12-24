﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using Syncfusion.XlsIO;
using System.IO;
using Entity;
using ParsExcel;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;


namespace Api.ExcelReader.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController3 : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        private readonly ExcelD2 _excelD2;
        private readonly ExcelD _excelD;
        private readonly ILogger<WeatherForecastController> _logger;
        private MunicipalMovableEstate municipalMovableEstateData;
        private MyDbContext _myDbContext;

        public WeatherForecastController3(ILogger<WeatherForecastController> logger, MyDbContext myDbContext, MunicipalMovableEstate MunicipalMovableEstate, ExcelD ExcelD, ExcelD2 ExcelD2)
        {
            _excelD2 = ExcelD2;
            _excelD = ExcelD;
            _logger = logger;
            _myDbContext = myDbContext;
            municipalMovableEstateData = MunicipalMovableEstate;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            //var aa = this._myDbContext.MunicipalMovableEstate.Where(x => x.BalanceCost > 0 || x.BalanceCost == 0).ToList();
            //aa[0].BalanceCost = 6969;
            //this._myDbContext.UpdateRange(aa);
            //this._myDbContext.SaveChanges();

            var municipalMovableEstateList2 = this._excelD2.ReadExcelD();

            foreach (var municipalMovableEstate in municipalMovableEstateList2)
            {
                    this._myDbContext.Add(municipalMovableEstate);
                    this._myDbContext.SaveChanges();
                
            }
            //this._myDbContext.AddRange(municipalMovableEstateList2);
            //this._myDbContext.SaveChanges();

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
