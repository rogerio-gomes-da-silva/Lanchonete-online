using Lancho.net.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lancho.net.Components
{
    public class CategoriaMenu : ViewComponent
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaMenu(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categoria = _categoriaRepository.Categorias.OrderBy(c => c.CategoriaNome);
            return View(categoria);
        }
    }
}
