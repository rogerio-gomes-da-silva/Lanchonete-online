using Lancho.net.Models;

namespace Lancho.net.ViewModels
{
    public class LancheListViewModel
    {
        public IEnumerable<Lanche> Lanches { get; set; }

        public string CategoriaAtual { get; set; }
    }
}
