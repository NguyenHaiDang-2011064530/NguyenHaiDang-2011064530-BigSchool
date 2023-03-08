using NguyenHaiDang_2011064530.Models;
using NguyenHaiDang_2011064530.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenHaiDang_2011064530.Controllers
{
    public class CouresController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
            public CouresController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Coures
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }
    }
}