using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication2Car.Data;
using WebApplication2Car.Models;

namespace WebApplication2Car.Controllers
{
    public class CarsController : Controller
    {
        private static List<Car> cars = new List<Car>();
        

        // GET: Cars
        public IActionResult Index()
        {
            return View(cars);

        }

        // GET: Cars/Details/5
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = cars.FirstOrDefault(m => m.ID == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        // GET: Cars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromForm] Car car)
        {
            if (ModelState.IsValid)
            {
                car.ID = Guid.NewGuid();
                cars.Add(car);

                return RedirectToAction(nameof(Index));
            }
            return View(car);
        }

            // GET: Cars/Edit/5
            public IActionResult Edit(Guid? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                  var car = cars.FirstOrDefault(m => m.ID == id);

                if (car == null)
                {
                    return NotFound();
                }
                return View(car);
            }

            // POST: Cars/Edit/5
            // To protect from overposting attacks, enable the specific properties you want to bind to.
            // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Edit(Guid id, [FromForm] Car car)
            {
                if (id != car.ID)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    var carToUpdate = cars.FirstOrDefault(m => m.ID == id);

                    if (carToUpdate == null)
                    {
                        return NotFound();
                    }
                    carToUpdate.Name = car.Name;
                    carToUpdate.Description = car.Description;
                    carToUpdate.DOM = car.DOM;
                    carToUpdate.Fuel = car.Fuel;
                    return RedirectToAction(nameof(Index));

                
                }
                return View(car);
            }

            // GET: Cars/Delete/5
            public IActionResult Delete(Guid? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var car = cars.FirstOrDefault(m => m.ID == id);
                if (car == null)
                {
                    return NotFound();
                }

                return View(car);
            }

            // POST: Cars/Delete/5
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public IActionResult DeleteConfirmed(Guid id)
            {

                var car = cars.FirstOrDefault(m => m.ID == id);
                if (car != null)
                {
                    cars.Remove(car);
                }
                return RedirectToAction(nameof(Index));
            }

        }
    }

    
    

