using MantenimientoDeEquipos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MantenimientoDeEquipos.Controllers.Controladores
{
    public class TipoComputadorController : Controller
    {
        // GET: TipoComputador
        public ActionResult Index()
        {
            List<Models.Dto.TipoComputador> ListTipoComputadores;

            using (var context = new InventarioContext())
            {
                ListTipoComputadores = (from Tc in context.TipoComputador
                                        select new Models.Dto.TipoComputador()
                                        { 
                                            Id_TipoComputador = Tc.Id_Tipo_Computador,
                                            tipoComputador = Tc.TipoComputador1

                                        
                                        
                                        }).ToList();


            }

            return View(ListTipoComputadores);
        }

        // GET: TipoComputador/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TipoComputador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoComputador/Create
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

        // GET: TipoComputador/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TipoComputador/Edit/5
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

        // GET: TipoComputador/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TipoComputador/Delete/5
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
