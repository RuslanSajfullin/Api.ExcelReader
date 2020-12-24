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
    public class ExcelD : IDaParser
    {

        private readonly ILogger<ExcelD> _logger;
        private MunicipalMovableEstate municipalMovableEstateData;
        private MyDbContext _myDbContext;

        public ExcelD(ILogger<ExcelD> logger, MyDbContext myDbContext, MunicipalMovableEstate MunicipalMovableEstate)
        {
            _logger = logger;
            _myDbContext = myDbContext;
            municipalMovableEstateData = MunicipalMovableEstate;
        }
      
        public List<MunicipalMovableEstate> ReadExcelD()
        {
            ExcelEngine excelEngine = new ExcelEngine();

            //Instantiate the Excel application object
            IApplication application = excelEngine.Excel;

            //Assigns default application version
            application.DefaultVersion = ExcelVersion.Excel2013;

            string basePath = @"C:\12\123.xlsx";
            FileStream sampleFile = new FileStream(basePath, FileMode.Open);

            IWorkbook workbook = application.Workbooks.Open(sampleFile);

            //Access first worksheet from the workbook.
            IWorksheet worksheet = workbook.Worksheets[0];

            var a = worksheet.Rows[0].Cells[0].Value2;
            List<MunicipalMovableEstate> municipalMovableEstateList = new List<MunicipalMovableEstate>();
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

                MunicipalMovableEstate municipalMovableEstate = new MunicipalMovableEstate();
                {
                    municipalMovableEstate.Name = listJ[(int)Map1Code.Name].Length > 500 ? listJ[(int)Map1Code.Name].Substring(0, 499) : listJ[(int)Map1Code.Name];

                    int result7;
                    if (int.TryParse(listJ[(int)Map1Code.BalanceCost], out result7))
                        municipalMovableEstate.BalanceCost = result7;
                    else
                        municipalMovableEstate.BalanceCost = 0m;
                    municipalMovableEstate.RegistryNumber = listJ[(int)Map1Code.RegistryNumber] + i +DateTime.Now + municipalMovableEstate.BalanceCost;
                    decimal result8;
                    if (decimal.TryParse(listJ[(int)Map1Code.ResidualCost], out result8))
                        municipalMovableEstate.ResidualCost = result8;
                    else
                        municipalMovableEstate.ResidualCost = 0m;

                    DateTime myDate10;
                    if (DateTime.TryParse(listJ[(int)Map1Code.CreationTerminationRightDate], out myDate10))
                    {
                        municipalMovableEstate.CreationTerminationRightDate = myDate10;
                    }
                    municipalMovableEstate.CreationTerminationRightReasonDocumentDetails = listJ[(int)Map1Code.CreationTerminationRightReasonDocumentDetails];
                    municipalMovableEstate.RightSubject = listJ[(int)Map1Code.RightSubject].Length > 500 ? listJ[(int)Map1Code.RightSubject].Substring(0, 499) : listJ[(int)Map1Code.RightSubject];
                    municipalMovableEstate.RightHolderFullName = listJ[(int)Map1Code.RightHolderFullName].Length > 500 ? listJ[(int)Map1Code.RightHolderFullName].Substring(0, 499) : listJ[(int)Map1Code.RightHolderFullName];
                    municipalMovableEstate.OKPOCode = listJ[(int)Map1Code.OKPOCode].Length > 10 ? listJ[(int)Map1Code.OKPOCode].Substring(0, 9) : listJ[(int)Map1Code.OKPOCode];
                    municipalMovableEstate.RightType = listJ[(int)Map1Code.RightType].Length > 100 ? listJ[(int)Map1Code.RightType].Substring(0, 99) : listJ[(int)Map1Code.RightType];
                    municipalMovableEstate.StockCompanyName = listJ[(int)Map1Code.StockCompanyName].Length > 500 ? listJ[(int)Map1Code.StockCompanyName].Substring(0, 497) : listJ[(int)Map1Code.StockCompanyName]; 
                    municipalMovableEstate.StockNumber = listJ[(int)Map1Code.StockNumber].Length > 50 ? listJ[(int)Map1Code.StockNumber].Substring(0, 49) : listJ[(int)Map1Code.StockNumber];
                    municipalMovableEstate.AuthorisedCapitalSize = listJ[(int)Map1Code.AuthorisedCapitalSize].Length > 500 ? listJ[(int)Map1Code.AuthorisedCapitalSize].Substring(0, 499) : listJ[(int)Map1Code.AuthorisedCapitalSize];
                    municipalMovableEstate.PartnershipName = listJ[(int)Map1Code.PartnershipName].Length > 500 ? listJ[(int)Map1Code.PartnershipName].Substring(0, 499) : listJ[(int)Map1Code.PartnershipName];
                    municipalMovableEstate.MateriallyResponsiblePerson = listJ[(int)Map1Code.MateriallyResponsiblePerson].Length > 500 ? listJ[(int)Map1Code.MateriallyResponsiblePerson].Substring(0, 499) : listJ[(int)Map1Code.MateriallyResponsiblePerson];
                    municipalMovableEstate.TransferredTo = listJ[(int)Map1Code.TransferredTo].Length > 500 ? listJ[(int)Map1Code.TransferredTo].Substring(0, 499) : listJ[(int)Map1Code.TransferredTo];
                    municipalMovableEstate.Category = "0"; 
                    municipalMovableEstate.PermittedUse = "0"; 
                    municipalMovableEstate.OperatorId = 65; 
                    DateTime myDate11;
                    if (DateTime.TryParse(listJ[(int)Map1Code.ResidualCostDeterminationDate], out myDate11))
                    {
                        municipalMovableEstate.ResidualCostDeterminationDate = myDate11;
                    }
                   
                    decimal result19;
                    if (decimal.TryParse(listJ[(int)Map1Code.AmortizationPercent], out result19))
                        municipalMovableEstate.AmortizationPercent = result19;
                    else
                        municipalMovableEstate.AmortizationPercent = 0;

                    municipalMovableEstate.StructuralDepartment = listJ[(int)Map1Code.StructuralDepartment].Length > 500 ? listJ[(int)Map1Code.StructuralDepartment].Substring(0, 499) : listJ[(int)Map1Code.StructuralDepartment];
                    municipalMovableEstate.ResponsiblePerson = listJ[(int)Map1Code.ResponsiblePerson].Length > 500 ? listJ[(int)Map1Code.ResponsiblePerson].Substring(0, 499) : listJ[(int)Map1Code.ResponsiblePerson];  
                    municipalMovableEstate.BalanceHolder = listJ[(int)Map1Code.BalanceHolder].Length > 500 ? listJ[(int)Map1Code.BalanceHolder].Substring(0, 499) : listJ[(int)Map1Code.BalanceHolder];
                    municipalMovableEstate.InventoryNumber = listJ[(int)Map1Code.InventoryNumber2].Length > 0 ? (listJ[(int)Map1Code.InventoryNumber] + " " + listJ[(int)Map1Code.InventoryNumber2]) : listJ[(int)Map1Code.InventoryNumber];
                    
                 
                    municipalMovableEstate.ObjectKind =  listJ[(int)Map1Code.ObjectKind].Length > 100 ? listJ[(int)Map1Code.ObjectKind].Substring(0, 99) : listJ[(int)Map1Code.ObjectKind];
 
                    DateTime myDate2;
                    if (!DateTime.TryParse(listJ[(int)Map1Code.CommissioningDate], out myDate2))
                    {
                        municipalMovableEstate.CommissioningDate = myDate2;
                    }
                    // municipalMovableEstate.IsPublishingProhibited = listJ[(int)Map1Code.IsPublishingProhibited];
                }

                municipalMovableEstateList.Add(municipalMovableEstate);
                //countries.Add(i, listJ);
            }

            //Closing the workbook.
            workbook.Close();

            //Dispose the Excel engine
            excelEngine.Dispose();
            return municipalMovableEstateList;
        }
    }
}
