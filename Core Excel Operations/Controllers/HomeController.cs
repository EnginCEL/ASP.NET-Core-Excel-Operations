using ClosedXML.Excel;
using Core_Excel_Operations.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Excel_Operations.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult ExportStaticPersonal()
        {
            using (var WorkBook = new XLWorkbook())
            {
                var sheet = WorkBook.Worksheets.Add("Personal List");
                sheet.Cell(1, 1).Value = "Personal ID";
                sheet.Cell(1, 1).Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.Red;
                sheet.Cell(1, 1).Style.Font.FontColor = ClosedXML.Excel.XLColor.White;
                sheet.Cell(1, 2).Value = "Personal Name";
                sheet.Cell(1, 2).Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.Red;
                sheet.Cell(1, 2).Style.Font.FontColor = ClosedXML.Excel.XLColor.White;
                sheet.Cell(1, 3).Value = "Personal SurName";
                sheet.Cell(1, 3).Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.Red;
                sheet.Cell(1, 3).Style.Font.FontColor = ClosedXML.Excel.XLColor.White;
                sheet.Cell(1, 4).Value = "Personal Mail";
                sheet.Cell(1, 4).Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.Red;
                sheet.Cell(1, 4).Style.Font.FontColor = ClosedXML.Excel.XLColor.White;
                var PersonalRowCount = 2;
                foreach (var item in GetPersonalList())
                {
                    sheet.Cell(PersonalRowCount, 1).Value = item.PersonalID;
                    sheet.Cell(PersonalRowCount, 2).Value = item.PersonalName;
                    sheet.Cell(PersonalRowCount, 3).Value = item.PersonalSurName;
                    sheet.Cell(PersonalRowCount, 4).Value = item.PersonalMail;

                    PersonalRowCount = PersonalRowCount + 1;

                }
                using (var stream = new MemoryStream())
                {
                    WorkBook.SaveAs(stream);
                    var Content = stream.ToArray();
                    return File(Content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "PersonalList.xlsx");
                }

            }

        }
        List<PersonalViewModel> GetPersonalList()
        {

            List<PersonalViewModel> pvm = new List<PersonalViewModel>();


            using (var connection = new Context())
            {
                pvm = connection.Personal.Select(x => new PersonalViewModel
                {
                    PersonalID = x.PersonalID,
                    PersonalMail = x.PersonalMail,
                    PersonalName = x.PersonalName,
                    PersonalSurName = x.PersonalSurName
                }).ToList();
            }
            return pvm;
        }
        public IActionResult PersonalListExcel()
        {

            return View();
        }


    }
}
