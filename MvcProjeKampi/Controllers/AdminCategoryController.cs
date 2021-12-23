using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;

namespace MvcProjeKampi.Controllers
{
    public class AdminCategoryController : Controller
    {
        private CategoryManager _cm = new CategoryManager(new EfCategoryDal());
        // GET: AdminCategory
        public ActionResult Index()
        {
            var categoryValues = _cm.GetCategoryList();
            return View(categoryValues);
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category ct)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult result = categoryValidator.Validate(ct);
            if (result.IsValid)
            {
                _cm.Add(ct);
                RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();
        }

        public ActionResult DeleteCategory(int id)
        {
            var categoryValue = _cm.GetByID(id);
            _cm.Delete(categoryValue);
            return RedirectToAction("Index");
        }
    }
}