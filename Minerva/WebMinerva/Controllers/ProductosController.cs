
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebMinerva.Models;

public class ProductosController : Controller
{
    private readonly MinervaContext _context;

    public ProductosController(MinervaContext context)
    {
        _context = context;
    }

    // GET: PRODUCTOS
    public async Task<IActionResult> Index()
    {
        return View(await _context.Producto
            .Include(x => x.IdUnidadMedidaNavigation)
            .Where(x => x.Estado == 1)
            .OrderBy(x => x.Descripcion)
            .ToListAsync());
    }

    // GET: PRODUCTOS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var producto = await _context.Producto
            .Include( x => x.IdUnidadMedidaNavigation)
            .FirstOrDefaultAsync(m => m.Id == id);
        if (producto == null)
        {
            return NotFound();
        }

        return View(producto);
    }

    // GET: PRODUCTOS/Create
    public IActionResult Create()
    {
        ViewData["UnidadesMedida"] = new SelectList(_context.UnidadMedida, "Id", "Descripcion");
        return View();
    }

    // POST: PRODUCTOS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Producto producto)
    {
        if (!string.IsNullOrWhiteSpace(producto.Codigo) && 
            !string.IsNullOrWhiteSpace(producto.Descripcion))
        {
            producto.UsuarioRegistro = "admin";
            producto.FechaRegistro = DateTime.Now;
            producto.Estado = 1;
            _context.Add(producto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        ViewData["UnidadesMedida"] = new SelectList(_context.UnidadMedida, "Id", "Descripcion");
        return View(producto);
    }

    // GET: PRODUCTOS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var producto = await _context.Producto.FindAsync(id);
        if (producto == null)
        {
            return NotFound();
        }

        ViewData["UnidadesMedida"] = new SelectList(_context.UnidadMedida, "Id", "Descripcion");
        return View(producto);
    }

    // POST: PRODUCTOS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, Producto producto)
    {
        if (id != producto.Id)
        {
            return NotFound();
        }

        if (!string.IsNullOrWhiteSpace(producto.Codigo) &&
            !string.IsNullOrWhiteSpace(producto.Descripcion))
        {
            try
            {
                producto.UsuarioRegistro = "admin";
                _context.Update(producto);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductoExists(producto.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        ViewData["UnidadesMedida"] = new SelectList(_context.UnidadMedida, "Id", "Descripcion");
        return View(producto);
    }

    // GET: PRODUCTOS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var producto = await _context.Producto
            .Include(x => x.IdUnidadMedidaNavigation)
            .FirstOrDefaultAsync(m => m.Id == id);
        if (producto == null)
        {
            return NotFound();
        }

        return View(producto);
    }

    // POST: PRODUCTOS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var producto = await _context.Producto.FindAsync(id);
        if (producto != null)
        {
            producto.UsuarioRegistro = "admin";
            producto.Estado = -1;
            _context.Update(producto);
            //_context.Producto.Remove(producto);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool ProductoExists(int? id)
    {
        return _context.Producto.Any(e => e.Id == id);
    }
}
