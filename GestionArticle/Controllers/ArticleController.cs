using GestionArticle.Models;
using GestionArticle.Services;
using GestionArticle.Tools;
using Microsoft.AspNetCore.Mvc;

namespace GestionArticle.Controllers
{
    public class ArticleController : Controller
    {
        DbService _service;

        public ArticleController()
        {
            _service = new DbService();
        }
        public IActionResult Index()
        {
            return View(_service.GetAll());
        }

        public IActionResult Details(int id)
        {
            return View(ArticleService.GetById(id));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ArticleForm form)
        {
            if (!ModelState.IsValid)
            {
                return View(form);
            }

            _service.Create(form.ToData());
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            ArticleService.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            return View(ArticleService.GetById(id).ToView());
        }
        [HttpPost]
        public IActionResult Edit(ArticleForm f)
        {
            if(!ModelState.IsValid) return View(f);

            ArticleService.Update(f.ToData());

            return RedirectToAction("Index");
        }
    }
}
