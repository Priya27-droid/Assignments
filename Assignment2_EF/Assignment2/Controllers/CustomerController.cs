using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Assignment2.Entities;
using Assignment2.Repositories;

namespace Assignment2.Controllers
{
    public class CustomerController : Controller
    {
       CustomerRepository _repo = new CustomerRepository();
        // GET: CustomerController
        public ActionResult Index()
        {
            List<Customer> list = _repo.GetCustomer();
            return View(list);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(string id)
        {
            Customer c = _repo.GetCustomerById(id);
            return View(c);
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer item )
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repo.Add(item);
                    return RedirectToAction(nameof(Index));
                }
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(string id)
        {
            Customer  c = _repo.GetCustomerById(id);
            return View(c);
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Customer item  )
        {
            try
            {
                _repo.Update(item);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete( string id)
        {
            Customer c = _repo.GetCustomerById(id);
            return View(c);
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Customer item)
        {
            try
            {
                _repo.Delete(item);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
