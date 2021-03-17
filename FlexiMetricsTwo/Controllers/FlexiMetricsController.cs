using FlexiMetricsTwo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


/*
Scaffold-DbContext "Server=.\SQLExpress;Database=FlexiMetrics;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Force

What if never re-scaffold for user tables. Instead all reads and writes take place through stored procs and dynamic sql/C#. 
Additionally this would allow multiple users within the database to have private and shared tables
*/
namespace FlexiMetricsTwo.Controllers
{
    public class FlexiMetricsController : Controller
    {
        private readonly FlexiMetricsContext _context;

        public FlexiMetricsController(FlexiMetricsContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<MasterSchema> TableSummary = _context.MasterSchemas.Where(x => x.FacingType == "TableName" 
                                                                             && x.Active == true).ToList();
            return View(TableSummary);
        }
        public IActionResult TablesUnderConstruction()
        {
            //Table Names can be found by ChangeTypeIDs of 1 (AddTable)
            List<ChangeRequest> TableNames = _context.ChangeRequests.Where(x => x.ChangeTypeId == 1).ToList();
            return View(TableNames);
        }
        [HttpGet]
        public IActionResult EditUCTableName(int Id)
        {
            ChangeRequest TableToEdit = _context.ChangeRequests.Where(x => x.ChangeRequestId == Id).First();
            return View(TableToEdit);
        }
        [HttpPost]
        public IActionResult EditUCTableName(ChangeRequest EditedTable)
        {
            ChangeRequest TableToEdit = _context.ChangeRequests.Where(x => x.ChangeRequestId == EditedTable.ChangeRequestId).First();
            if (ModelState.IsValid)
            {
                TableToEdit.NewValue = EditedTable.NewValue;
                _context.Entry(TableToEdit).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
            }
            return RedirectToAction("TablesUnderConstruction");

        }
        [HttpGet]
        public IActionResult AddUCTable()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddUCTable(ChangeRequest NewTable)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Error");
            }
            _context.ChangeRequests.Add(NewTable);
            _context.SaveChanges();
            return RedirectToAction("TablesUnderConstruction");
        }
        public IActionResult AddUCTableColumn(ChangeRequest NewColumn)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Error");
            }
            _context.ChangeRequests.Add(NewColumn);
            _context.SaveChanges();

            return Redirect ("ViewUCTableToEdit?Id=" + NewColumn.ParentId); 
        }
        public IActionResult ViewUCTableToEdit(int Id)
        {
            List<ChangeRequest> TableToEdit = _context.ChangeRequests.Where(x => x.ChangeRequestId == Id 
                                                                              || x.ParentId == Id).ToList();
            return View(TableToEdit);
        }
        [HttpGet]
        public IActionResult EditUCTableColumn(int Id)
        {
            ChangeRequest ColumnToEdit = _context.ChangeRequests.Where(x => x.ChangeRequestId == Id).First();
            var ParentTableId = ColumnToEdit.ParentId;
            ChangeRequest ColumnParent = _context.ChangeRequests.Where(x => x.ChangeRequestId == ParentTableId).First();

            List<ChangeRequest> ToEdit = new List<ChangeRequest>()
            {
                ColumnToEdit,
                ColumnParent
            };
            
            return View(ToEdit);
        }
        [HttpPost]
        public IActionResult EditUCTableColumn(ChangeRequest Modified)
        {
            ChangeRequest ColumnToEdit = _context.ChangeRequests.Where(x => x.ChangeRequestId == Modified.ChangeRequestId).FirstOrDefault(); 
            if (ModelState.IsValid)
            {
                ColumnToEdit.NewValue = Modified.NewValue;
                ColumnToEdit.ValueType = Modified.ValueType;

                _context.Entry(ColumnToEdit).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.Update(ColumnToEdit);
                _context.SaveChanges();
            }
            
            return Redirect("ViewUCTableToEdit?Id=" + Modified.ParentId); 
        }
        public IActionResult ConfirmDeleteUCTableColumn(int Id)
        {
            ChangeRequest ColumnToDelete = _context.ChangeRequests.Where(x => x.ChangeRequestId == Id).First();
            var ParentTableId = ColumnToDelete.ParentId;
            ChangeRequest ColumnParent = _context.ChangeRequests.Where(x => x.ChangeRequestId == ParentTableId).First();

            List<ChangeRequest> ToDelete = new List<ChangeRequest>()
            {
                ColumnToDelete,
                ColumnParent
            };

            return View(ToDelete);
        }
        public IActionResult DeleteUCTableColumn(int Id, int TableId)
        {
            ChangeRequest ColumnToDelete = _context.ChangeRequests.Where(x => x.ChangeRequestId == Id).FirstOrDefault(); 
            _context.ChangeRequests.Remove(ColumnToDelete);
            _context.SaveChanges();
            return Redirect("ViewUCTableToEdit?Id=" + TableId); 
        }
        public IActionResult ConfirmDeleteUCTable(int Id)
        {
            List<ChangeRequest> TableToDelete = _context.ChangeRequests.Where(x => x.ChangeRequestId == Id 
                                                                                || x.ParentId == Id).ToList();
            return View(TableToDelete);
        }
        public IActionResult DeleteUCTable(int Id)
        {
            //ChangeRequests related to tables have ChangeIDs 1 (Add Table) and 4 (Add Column)
            List<ChangeRequest> UnderConstruction = _context.ChangeRequests.Where(x => x.ChangeRequestId == Id 
                                                                                    || x.ParentId == Id).ToList();
            foreach (var item in UnderConstruction)
            {
                _context.ChangeRequests.Remove(item);
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
 
        public IActionResult ConfirmAddDBTable(int Id)
        {
            List<ChangeRequest> TableToAdd = _context.ChangeRequests.Where(x => x.ChangeRequestId == Id 
                                                                             || x.ParentId == Id).ToList();
            return View(TableToAdd);
        }
        public IActionResult AddDBTable (int Id)
        {
            FormattableString sql = $"EXEC ApplyChangeRequests @ChangeRequestID ={Id}";
            _context.Database.ExecuteSqlInterpolated(sql);

            return RedirectToAction("Index");
        }

        public IActionResult TabulaRasa(int Mode)
        {
            FormattableString sql = $"EXEC TabulaRasa @Mode ={Mode}";
            _context.Database.ExecuteSqlInterpolated(sql);

            return RedirectToAction("Index");
        }

    }
}
