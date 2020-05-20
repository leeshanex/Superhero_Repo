using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Superhero_Proj.Data;
using Superhero_Proj.Models;

namespace Superhero_Proj.Controllers
{
    public class SuperheroController : Controller
    {
        ApplicationDbContext context;
        public SuperheroController(ApplicationDbContext applicationDbContext) 
        {
            context = applicationDbContext;
        }
        // GET: Superhero
        public ActionResult Index()
        {
            var heroes = context.Superheroes;
            return View(heroes);
        }

        // GET: Superhero/Details/5
        public ActionResult Details(int id)
        {
            var publicID = context.Superheroes.Where(s => s.Id == id).FirstOrDefault();
            return View(publicID);
        }

        // GET: Superhero/Create
        public ActionResult Create()
        {
            var heroCreation = context.Superheroes.Where(s => s.Id >= 0).FirstOrDefault();
            return View(heroCreation);
        }

        // POST: Superhero/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(include: "Id,SuperheroName,AlterEgoName,PrimaryAbility,SecondaryAbility,Catchphrase")] Superhero superhero)
        {
            try
            {
                // TODO: Add insert logic here
                context.Superheroes.Add(superhero);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superhero/Edit/5
        public ActionResult Edit(int id)
        {
            var heroId = context.Superheroes.Where(s => s.Id == id).FirstOrDefault();
            //foreach(Superhero superhero in context.Superheroes)
            //{
            //    if(superhero.ID == id)
            //    {
            //        return View(superhero);
            //    }
            //}
            return View(heroId);
        }

        // POST: Superhero/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Superhero superhero)
        {
            try
            {
                // TODO: Add update logic here
                context.Superheroes.Update(superhero);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superhero/Delete/5
        public ActionResult Delete(int id)
        {
            var heroId = context.Superheroes.Where(s => s.Id == id).FirstOrDefault();
            return View(heroId);
        }

        // POST: Superhero/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Superhero superhero)
        {
            try
            {
                context.Remove(superhero);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}