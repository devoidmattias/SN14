using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using CrudDemo.Models;
using CrudDemo.Models.Repository;


namespace CrudDemo.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IRepository _repository;

        public ProductsController()
            : this(new XmlRepository())
        {
        }

        public ProductsController(IRepository repository)
        {
            _repository = repository;
        }


        // GET: Products
        public ActionResult Index()
        {
            return View(_repository.GetProducts());
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for  
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598. 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name, Description, Price, Supplier")]Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repository.AddProduct(product);
                    _repository.Save();

                    TempData["success"] = "Produkten sparad";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {
                TempData["error"] = "Misslyckades att spara produkten. Försök igen!";
            }
            return View(product);
        }

        // GET: /Products/Edit/XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX
        public ActionResult Edit(Guid? id)
        {
            if (!id.HasValue)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var product = _repository.GetProduct(id.Value);
            if (product == null)
            {
                return HttpNotFound();
            }

            return View(product);
        }


        // POST /Products/Edit/XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit_POST(Guid id)
        {
            var productToUpdate = _repository.GetProduct(id);

            if (productToUpdate == null)
            {
                return HttpNotFound();
            }
            if (TryUpdateModel(productToUpdate, string.Empty, new string[] {"Name", "Description", "Price", "Supplier"}))
            {
                try
                {
                    _repository.UpdateProduct(productToUpdate);
                    _repository.Save();
                    TempData["success"] = "Ändringarna sparade";

                    return RedirectToAction("Index");
                }
                catch (Exception)
                {
                    TempData["error"] = "Misslyckades spara ändringarna. Försök igen!";
                }
            }

            return View(productToUpdate);
        }


        // GET: /Products/Delete/XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX
        public ActionResult Delete(Guid? id)
        {
            if (!id.HasValue)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var product = _repository.GetProduct(id.Value);
            if (product == null)
            {
                return HttpNotFound();
            }

            return View(product);
        }

        // POST: /Product/Delete/XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            try
            {
                var productToDelete = new Product { ProductId = id };
                _repository.DeleteProduct(productToDelete);
                _repository.Save();
                TempData["success"] = "Produkten togs bort.";
            }
            catch (Exception)
            {
                TempData["error"] = "Misslyckades att ta bort produkten. Försök igen!";
                return RedirectToAction("Delete", new { id = id });
            }

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            _repository.Dispose();
            base.Dispose(disposing);
        }
    }
}


