using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FizzBuzz.Data;
using FizzBuzz.Models;

namespace FizzBuzz.Controllers
{
    public class FizzNumsController : Controller
    {
        private readonly FizzBuzzContext _context;

        public FizzNumsController(FizzBuzzContext context)
        {
            _context = context;
        }

        // GET: FizzNums
        public async Task<IActionResult> Index()
        {
              return View(await _context.FizzNum.ToListAsync());
        }

        //// GET: FizzNums/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null || _context.FizzNum == null)
        //    {
        //        return NotFound();
        //    }

        //    var fizzNum = await _context.FizzNum
        //        .FirstOrDefaultAsync(m => m.id == id);
        //    if (fizzNum == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(fizzNum);
        //}

        //// GET: FizzNums/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: FizzNums/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("id,FZN")] FizzNum fizzNum)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(fizzNum);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(fizzNum);
        //}

        //// GET: FizzNums/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || _context.FizzNum == null)
        //    {
        //        return NotFound();
        //    }

        //    var fizzNum = await _context.FizzNum.FindAsync(id);
        //    if (fizzNum == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(fizzNum);
        //}

        //// POST: FizzNums/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("id,FZN")] FizzNum fizzNum)
        //{
        //    if (id != fizzNum.id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(fizzNum);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!FizzNumExists(fizzNum.id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(fizzNum);
        //}

        //// GET: FizzNums/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null || _context.FizzNum == null)
        //    {
        //        return NotFound();
        //    }

        //    var fizzNum = await _context.FizzNum
        //        .FirstOrDefaultAsync(m => m.id == id);
        //    if (fizzNum == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(fizzNum);
        //}

        //// POST: FizzNums/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (_context.FizzNum == null)
        //    {
        //        return Problem("Entity set 'FizzBuzzContext.FizzNum'  is null.");
        //    }
        //    var fizzNum = await _context.FizzNum.FindAsync(id);
        //    if (fizzNum != null)
        //    {
        //        _context.FizzNum.Remove(fizzNum);
        //    }
            
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool FizzNumExists(int id)
        {
          return _context.FizzNum.Any(e => e.id == id);
        }
    }
}
