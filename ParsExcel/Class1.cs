using Entity;
using Entity.enumi;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.IO;

namespace ParsExcel
{
    public class ExcelD : IDaParser
    {
        public ExcelD() { 
        }

        public void ReadExcelD()
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
            List<string> list = new List<string>();
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
                    municipalMovableEstate.RegistryNumber =  listJ[(int)Map1Code.RegistryNumber];
                    municipalMovableEstate.Name = listJ[(int)Map1Code.Name]; 

                    int result7;
                    if (int.TryParse(listJ[(int)Map1Code.BalanceCost], out result7))
                        municipalMovableEstate.BalanceCost = result7;
                    else
                        municipalMovableEstate.BalanceCost = 0m;

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
                    municipalMovableEstate.RightSubject = listJ[(int)Map1Code.RightSubject];
                    municipalMovableEstate.RightHolderFullName = listJ[(int)Map1Code.RightHolderFullName];
                    municipalMovableEstate.OKPOCode = listJ[(int)Map1Code.OKPOCode];
                    municipalMovableEstate.RightType = listJ[(int)Map1Code.RightType];
                    municipalMovableEstate.StockCompanyName = listJ[(int)Map1Code.StockCompanyName];
                    municipalMovableEstate.StockNumber = listJ[(int)Map1Code.StockNumber];
                    municipalMovableEstate.AuthorisedCapitalSize = listJ[(int)Map1Code.AuthorisedCapitalSize];
                    municipalMovableEstate.PartnershipName = listJ[(int)Map1Code.PartnershipName];
                    municipalMovableEstate.MateriallyResponsiblePerson = listJ[(int)Map1Code.MateriallyResponsiblePerson];
                    municipalMovableEstate.TransferredTo = listJ[(int)Map1Code.TransferredTo];

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

                    municipalMovableEstate.StructuralDepartment = listJ[(int)Map1Code.StructuralDepartment];
                    municipalMovableEstate.ResponsiblePerson = listJ[(int)Map1Code.ResponsiblePerson]; 
                    municipalMovableEstate.BalanceHolder = listJ[(int)Map1Code.BalanceHolder]; 
                    municipalMovableEstate.InventoryNumber = listJ[(int)Map1Code.InventoryNumber2].Length > 0 ? listJ[(int)Map1Code.InventoryNumber] + " " + listJ[(int)Map1Code.InventoryNumber2] : listJ[(int)Map1Code.InventoryNumber];
                    
                 
                    municipalMovableEstate.ObjectKind = listJ[(int)Map1Code.ObjectKind];
 
                    DateTime myDate2;
                    if (!DateTime.TryParse(listJ[(int)Map1Code.CommissioningDate], out myDate2))
                    {
                        municipalMovableEstate.CommissioningDate = myDate2;
                    }
                   // municipalMovableEstate.IsPublishingProhibited = listJ[(int)Map1Code.IsPublishingProhibited];
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
        }
    }
}
