using MantenimientoDeEquipos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MantenimientoDeEquipos.Controllers.Controladores
{
    public class MantenimientoController : Controller
    {
        // GET: Mantenimiento
        public ActionResult Index()
        {

            List<Models.Dto.Mantenimiento> listMantenimiento;

            using (var context = new InventarioContext())
            {
                listMantenimiento = (from M in context.Mantenimiento
                                     join nc in context.Computador on M.Id_Computador equals nc.Id_Computador
                                     select new Models.Dto.Mantenimiento() 
                                     {
                                        Id_Mantenimiento = M.Id_Mantenimiento,
                                        NombreComputador = nc.Serial,
                                        UltimoMantenimiento = M.UltimoMantenimiento,
                                        ProximoMantenimiento = M.ProximoMantenimiento,
                                        Observaciones = M.Observaciones
                                     
                                     }).ToList();

            }

            return View(listMantenimiento);
        }

        // GET: Mantenimiento/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Mantenimiento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mantenimiento/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mantenimiento/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Mantenimiento/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mantenimiento/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Mantenimiento/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
