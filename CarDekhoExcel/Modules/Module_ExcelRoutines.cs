using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Extensions.Rafiq;
using System.Windows.Forms;
using CarDekhoExcel.Models;
using System.Windows.Forms.ComponentModel.Com2Interop;

namespace CarDekhoExcel
{
    partial class frmDekho
    {
        List<DekhoModel> listDekhoCars;
        private async Task LoadDataSource()
        {
            await UpdateConsole("Loading Data Source...");

            Excel.Application xlApp = new Excel.Application();
            //xlApp.Visible = true;

            Excel.Workbooks workbooks = xlApp.Workbooks;
            Excel.Workbook workbook = workbooks.Open("C:\\Users\\yasmi\\Desktop\\Sampah botak\\CAR DETAILS FROM CAR DEKHO.csv");
            Excel.Worksheet worksheet = workbook.Sheets[1];

            int numOfColumns = await "I".GetColumnFromAlphabet();

            List<List<object>> theDataSet = new List<List<object>>();

            await UpdateConsole("Extracting columns...");

            for (int i = await "A".GetColumnFromAlphabet(); i <= await "I".GetColumnFromAlphabet(); i++)
            {
                await UpdateProgressBar(i, numOfColumns, true);

                object[,] theColumn = worksheet.Columns[i].Value;

                List<object> theColumnFlat = theColumn
                    .Flatten<object>()
                    .ToList();

                theDataSet.Add(theColumnFlat);
            }

            await UpdateProgressBar(0, 1, false);

            int theLastRow = theDataSet[0]
                .FindIndex(x => x == null);

            listDekhoCars = new List<DekhoModel>();

            await UpdateConsole("Deserializing data...");

            for (int i = 1; i < theLastRow; i++)
            {
                await UpdateProgressBar(i, theLastRow, true);

                DekhoModel dekho = new DekhoModel()
                {
                    Brand = theDataSet[0][i]?.ToString() ?? "",
                    Model = theDataSet[1][i]?.ToString() ?? "",
                    Year = int.Parse(theDataSet[2][i]?.ToString() ?? "0"),
                    SellingPrice = (double)theDataSet[3][i],
                    DrivenKM = (double)theDataSet[4][i],
                    Fuel = theDataSet[5][i]?.ToString() ?? "",
                    SellerType = theDataSet[6][i]?.ToString() ?? "",
                    Transmission = theDataSet[7][i]?.ToString() ?? "",
                    Owner = theDataSet[8][i]?.ToString() ?? "",
                };

                listDekhoCars.Add(dekho);
            }

            await UpdateProgressBar(0, 1, false);

            workbook.Close(SaveChanges: false);
            xlApp.Quit();

            await UpdateConsole("Data Source loaded!!!");

            Marshal.ReleaseComObject(worksheet);
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(workbooks);
            Marshal.ReleaseComObject(xlApp);
        }

        private async Task ReturnFiltered()
        {
            await UpdateConsole("Filtering Data...");

            List<object> filtered_dekho = 


        }
    }
}
