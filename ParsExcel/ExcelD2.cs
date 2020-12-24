using Entity;
using Entity.enumi;
using Microsoft.Extensions.Logging;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ParsExcel
{
    public class ExcelD2 : IDaParser
    {

        private readonly ILogger<ExcelD> _logger;
        private MunicipalMovableEstate municipalMovableEstateData;
        private MyDbContext _myDbContext;

        public ExcelD2(ILogger<ExcelD> logger, MyDbContext myDbContext, MunicipalMovableEstate MunicipalMovableEstate)
        {
            _logger = logger;
            _myDbContext = myDbContext;
            municipalMovableEstateData = MunicipalMovableEstate;
        }

        public List<MunicipalImmovableEstate> ReadExcelD()
        {
            ExcelEngine excelEngine = new ExcelEngine();

            //Instantiate the Excel application object
            IApplication application = excelEngine.Excel;

            //Assigns default application version
            application.DefaultVersion = ExcelVersion.Excel2013;

            string basePath = @"C:\12\333.xlsx";
            FileStream sampleFile = new FileStream(basePath, FileMode.Open);

            IWorkbook workbook = application.Workbooks.Open(sampleFile);

            //Access first worksheet from the workbook.
            IWorksheet worksheet = workbook.Worksheets[0];

            var a = worksheet.Rows[0].Cells[0].Value2;
            List<MunicipalImmovableEstate> municipalMovableEstateList = new List<MunicipalImmovableEstate>();
            Dictionary<int, List<string>> countries = new Dictionary<int, List<string>>();

            var i = 2;
            for (i = 2; i < worksheet.Rows.Length; i++)
            {
                var j = 0;
                var listJ = new List<string>();
                for (j = 0; j < worksheet.Rows[i].Cells.Length; j++)
                {
                    listJ.Add(worksheet.Rows[i].Cells[j].Value);
                }

                MunicipalImmovableEstate municipalMovableEstate = new MunicipalImmovableEstate();
                {
                    municipalMovableEstate.Name = listJ[(int)Immovable.Name].Length > 499 ? listJ[(int)Immovable.Name].Substring(0, 497) : listJ[(int)Immovable.Name];

                    int result7;
                    if (int.TryParse(listJ[(int)Immovable.BalanceCost], out result7))
                        municipalMovableEstate.BalanceCost = result7;
                    else
                        municipalMovableEstate.BalanceCost = 0m;
                    municipalMovableEstate.RegistryNumber = listJ[(int)Immovable.RegistryNumber] + i + DateTime.Now + municipalMovableEstate.BalanceCost;
                    decimal result8;
                    if (decimal.TryParse(listJ[(int)Immovable.ResidualCost], out result8))
                        municipalMovableEstate.ResidualCost = result8;
                    else
                        municipalMovableEstate.ResidualCost = 0m;

                    DateTime myDate10;
                    if (DateTime.TryParse(listJ[(int)Immovable.CreationTerminationRightDate], out myDate10))
                    {
                        municipalMovableEstate.CreationTerminationRightDate = myDate10;
                    }
                    municipalMovableEstate.CreationTerminationRightReason = listJ[(int)Immovable.CreationTerminationRightReason].Length > 499 ? listJ[(int)Immovable.CreationTerminationRightReason].Substring(0, 499) : listJ[(int)Immovable.CreationTerminationRightReason]; 
                    municipalMovableEstate.RightHolderFullName = listJ[(int)Immovable.RightHolderFullName].Length > 499 ? listJ[(int)Immovable.RightHolderFullName].Substring(0, 499) : listJ[(int)Immovable.RightHolderFullName];
 
                    municipalMovableEstate.OKPOCode = listJ[(int)Immovable.OKPOCode].Length > 10 ? listJ[(int)Immovable.OKPOCode].Substring(0, 9) : listJ[(int)Immovable.OKPOCode];
                   
                    int result10;
                    if (int.TryParse(listJ[(int)Immovable.EntryYear], out result10))
                        municipalMovableEstate.EntryYear = result10;
                    else
                        municipalMovableEstate.EntryYear = 0;

                    municipalMovableEstate.RestrictionInformation = listJ[(int)Immovable.RestrictionInformation].Length > 499 ? listJ[(int)Immovable.RestrictionInformation].Substring(0, 497) : listJ[(int)Immovable.RestrictionInformation];
                    municipalMovableEstate.ResponsiblePerson = listJ[(int)Immovable.ResponsiblePerson].Length > 50 ? listJ[(int)Immovable.ResponsiblePerson].Substring(0, 49) : listJ[(int)Immovable.ResponsiblePerson];
               
                        municipalMovableEstate.CadastralNumber = listJ[(int)Immovable.ResponsiblePerson];
                        municipalMovableEstate.CadastralNumber = municipalMovableEstate.CadastralNumber == string.Empty ? "/" + i : municipalMovableEstate.CadastralNumber;
                
                  
                    municipalMovableEstate.Category = listJ[(int)Immovable.Category].Length > 500 ? listJ[(int)Immovable.Category].Substring(0, 499) : listJ[(int)Immovable.Category];
                    municipalMovableEstate.Address = listJ[(int)Immovable.Address].Length > 500 ? listJ[(int)Immovable.Address].Substring(0, 499) : listJ[(int)Immovable.Address];
                    municipalMovableEstate.ObjectKind = listJ[(int)Immovable.ObjectKind].Length > 500 ? listJ[(int)Immovable.ObjectKind].Substring(0, 499) : listJ[(int)Immovable.ObjectKind];
                    municipalMovableEstate.PermittedUse = listJ[(int)Immovable.PermittedUse].Length > 500 ? listJ[(int)Immovable.PermittedUse].Substring(0, 499) : listJ[(int)Immovable.PermittedUse];

                    municipalMovableEstate.BalanceHolder = listJ[(int)Immovable.BalanceHolder].Length > 500 ? listJ[(int)Immovable.BalanceHolder].Substring(0, 499) : listJ[(int)Immovable.BalanceHolder];
                    
                    municipalMovableEstate.Category = "0";
                    municipalMovableEstate.PermittedUse = "0";
                    municipalMovableEstate.OperatorId = 65;
                    DateTime myDate11;
                    if (DateTime.TryParse(listJ[(int)Immovable.ResidualCostDeterminationDate], out myDate11))
                    {
                        municipalMovableEstate.ResidualCostDeterminationDate = myDate11;
                    }

                    decimal result6;
                    if (decimal.TryParse(listJ[(int)Immovable.RunningMeter], out result6))
                        municipalMovableEstate.RunningMeter = result6;
                    else
                        municipalMovableEstate.RunningMeter = 0m;

                    decimal result71;
                    if (decimal.TryParse(listJ[(int)Immovable.TotalArea], out result71))
                        municipalMovableEstate.TotalArea = result71;
                    else
                        municipalMovableEstate.TotalArea = 0m;


                    decimal result81;
                    if (decimal.TryParse(listJ[(int)Immovable.UsefulArea], out result81))
                        municipalMovableEstate.UsefulArea = result81;
                    else
                        municipalMovableEstate.UsefulArea = 0m;

                    decimal result9;
                    if (decimal.TryParse(listJ[(int)Immovable.AttachedRoomsNumber], out result9))
                        municipalMovableEstate.AttachedRoomsNumber = result9;
                    else
                        municipalMovableEstate.AttachedRoomsNumber = 0m;

                    decimal result25;
                    if (decimal.TryParse(listJ[(int)Immovable.InitialCost], out result25))
                        municipalMovableEstate.InitialCost = result25;
                    else
                        municipalMovableEstate.InitialCost = 0m;

                    decimal result14;
                    if (decimal.TryParse(listJ[(int)Immovable.ResidualCost], out result14))
                        municipalMovableEstate.ResidualCost = result14;
                    else
                        municipalMovableEstate.ResidualCost = 0m;

                    decimal result19;
                    if (decimal.TryParse(listJ[(int)Immovable.AmortizationSum], out result19))
                        municipalMovableEstate.AmortizationSum = result19;
                    else
                        municipalMovableEstate.AmortizationSum = 0;

                    municipalMovableEstate.StructuralDepartment = listJ[(int)Immovable.StructuralDepartment].Length > 500 ? listJ[(int)Immovable.StructuralDepartment].Substring(0, 499) : listJ[(int)Immovable.StructuralDepartment];
                    municipalMovableEstate.ResponsiblePerson = listJ[(int)Immovable.ResponsiblePerson].Length > 500 ? listJ[(int)Immovable.ResponsiblePerson].Substring(0, 499) : listJ[(int)Immovable.ResponsiblePerson];
                    municipalMovableEstate.BalanceHolder = listJ[(int)Immovable.BalanceHolder].Length > 500 ? listJ[(int)Immovable.BalanceHolder].Substring(0, 499) : listJ[(int)Immovable.BalanceHolder];
                    municipalMovableEstate.InventoryNumber =  listJ[(int)Immovable.InventoryNumber];


                    municipalMovableEstate.ObjectKind = listJ[(int)Immovable.ObjectKind].Length > 100 ? listJ[(int)Immovable.ObjectKind].Substring(0, 99) : listJ[(int)Immovable.ObjectKind];

                    DateTime myDate2;
                    if (!DateTime.TryParse(listJ[(int)Immovable.CreationTerminationRightDate], out myDate2))
                    {
                        municipalMovableEstate.CreationTerminationRightDate = myDate2;
                    }
                
                }
                if (municipalMovableEstate.BalanceCost != 0 || municipalMovableEstate.OKPOCode != "" || municipalMovableEstate.Name != "")
                {
                    municipalMovableEstateList.Add(municipalMovableEstate);
                }
               
            }

            //Closing the workbook.
            workbook.Close();

            //Dispose the Excel engine
            excelEngine.Dispose();
            return municipalMovableEstateList;
        }
    }
}
