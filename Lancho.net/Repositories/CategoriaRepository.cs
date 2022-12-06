using Lancho.net.Context;
using Lancho.net.Models;
using Lancho.net.Repositories.Interfaces;

namespace Lancho.net.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
