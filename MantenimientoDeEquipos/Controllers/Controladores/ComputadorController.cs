using MantenimientoDeEquipos.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MantenimientoDeEquipos.Controllers.Controladores
{
    public class ComputadorController : Controller
    {
        // GET: Computador
        public ActionResult Index()
        {
            List<Models.Dto.Computador> listComputador;

            using (var InventarioContext = new InventarioContext())
            {
                listComputador = (from c in InventarioContext.Computador
                                  join f in InventarioContext.Funcionario on c.Id_Funcionario equals f.Id_Funcionario
                                  join tc in InventarioContext.TipoComputador on c.Id_Tipo_Computador equals tc.Id_Tipo_Computador
                                  select new Models.Dto.Computador() 
                                  { 
                                      Id_Computador = c.Id_Computador,
                                      Serial = c.Serial,
                                      nombreFuncionario = f.NombreCompleto,
                                      Ciudad = c.Ciudad,
                                      Marca = c.Marca,
                                      TipoComputador = tc.TipoComputador1,
                                      Modelo = c.Modelo,
                                      Procesador = c.Procesador,
                                      MemoriaRam = c.Memoria_Ram,
                                      DiscoDuro = c.Disco_Duro,
                                      SistemaOperativo = c.Sistema_Operativo,
                                      Estado = c.Estado
                                                            
                                  
                                  } ).ToList();


            }


            return View(listComputador);
        }

        // GET: Computador/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Computador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Computador/Create
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

        // GET: Computador/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Computador/Edit/5
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

        // GET: Computador/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Computador/Delete/5
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
