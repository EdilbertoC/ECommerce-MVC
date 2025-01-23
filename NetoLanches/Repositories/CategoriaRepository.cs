using NetoLanches.Context;
using NetoLanches.Models;
using NetoLanches.Repositories.Interfaces;

namespace NetoLanches.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        public readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
