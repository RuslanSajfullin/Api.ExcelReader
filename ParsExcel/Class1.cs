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
                    municipalMovableEstate.Name = listJ[3];

                    int result7;
                    if (int.TryParse(listJ[7], out result7))
                        municipalMovableEstate.BalanceCost = result7;
                    else
                        municipalMovableEstate.BalanceCost = 0m;

                    decimal result9;
                    if (decimal.TryParse(listJ[9], out result9))
                        municipalMovableEstate.ResidualCost = result9;
                    else
                        municipalMovableEstate.ResidualCost = 0m;

                    DateTime myDate10;
                    if (DateTime.TryParse(listJ[10], out myDate10))
                    {
                        municipalMovableEstate.CreationTerminationRightDate = myDate10;
                    }
                    municipalMovableEstate.CreationTerminationRightReasonDocumentDetails = listJ[11];
                    municipalMovableEstate.RightSubject = listJ[12];
                    municipalMovableEstate.RightHolderFullName = listJ[13];
                    municipalMovableEstate.OKPOCode = listJ[14];
                    municipalMovableEstate.RightType = listJ[15];
                    //municipalMovableEstate.StockCompanyName =
                    //municipalMovableEstate.StockNumber =
                    //municipalMovableEstate.NominalStockCost =
                    //municipalMovableEstate.AuthorisedCapitalSize =
                    //municipalMovableEstate.PartnershipName =
                    //municipalMovableEstate.MateriallyResponsiblePerson =
                    //municipalMovableEstate.TransferredTo =
                    //municipalMovableEstate.ResidualCost =
                    //municipalMovableEstate.ResidualCostDeterminationDate =
                    decimal result19;
                    if (decimal.TryParse(listJ[19], out result19))
                        municipalMovableEstate.AmortizationPercent = result19;
                    else
                        municipalMovableEstate.AmortizationPercent = 0;

                    municipalMovableEstate.StructuralDepartment = listJ[20];
                    municipalMovableEstate.ResponsiblePerson = listJ[21];
                    municipalMovableEstate.BalanceHolder = listJ[22];
                    municipalMovableEstate.InventoryNumber = listJ[24];
                    decimal result25;
                    if (decimal.TryParse(listJ[25], out result25))
                        municipalMovableEstate.AmortizationPercent = result25;
                    else
                        municipalMovableEstate.AmortizationPercent = 0;

                    //municipalMovableEstate.ObjectKind =
                    //municipalMovableEstate.Category =
                    //municipalMovableEstate.PermittedUse =
                    DateTime myDate2;
                    if (!DateTime.TryParse(listJ[10], out myDate2))
                    {
                        municipalMovableEstate.CommissioningDate = myDate2;
                    }
                    //municipalMovableEstate.IsPublishingProhibited =
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
