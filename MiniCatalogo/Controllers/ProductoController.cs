using Microsoft.AspNetCore.Mvc;
using MiniCatalogo.Models;

namespace MiniCatalogo.Controllers
{
    public class ProductoController : Controller
    {
        // Datos en memoria (sin base de datos)
        private static List<Producto> _productos = new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Laptop Asus", Descripcion = "Intel i7, 16GB RAM", Precio = 850.00m, Categoria = "Tecnología" },
            new Producto { Id = 2, Nombre = "Escritorio Madera", Descripcion = "120x60cm, color roble", Precio = 250.00m, Categoria = "Muebles" },
            new Producto { Id = 3, Nombre = "Auriculares Sony", Descripcion = "Bluetooth, cancelación de ruido", Precio = 120.00m, Categoria = "Tecnología" }
        };

        // GET: Lista de productos
        public IActionResult Index()
        {
            return View(_productos);
        }

        // GET: Formulario crear
        public IActionResult Create()
        {
            return View();
        }

        // POST: Guardar nuevo producto
        [HttpPost]
        public IActionResult Create(Producto producto)
        {
            producto.Id = _productos.Count + 1;
            _productos.Add(producto);
            return RedirectToAction("Index");
        }

        // GET: Detalle de un producto
        public IActionResult Detail(int id)
        {
            var producto = _productos.FirstOrDefault(p => p.Id == id);
            if (producto == null) return NotFound();
            return View(producto);
        }
    }
}