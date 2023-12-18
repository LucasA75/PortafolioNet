using PortafolioNET.Models;

namespace PortafolioNET.Services
{

    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }

    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>()
            {
                new Proyecto
                {
                    Titulo = "Ebay Lol",
                    Descripcion = "Pagina de compra y venta",
                    ImagenURL = "",
                    Link = "Ebay.com"
                },new Proyecto
                {
                    Titulo = "Amazon",
                    Descripcion = "Pagina de compra y venta",
                    ImagenURL = "",
                    Link = "Amazon.com"
                },new Proyecto
                {
                    Titulo = "Aliexpress",
                    Descripcion = "Pagina de compra y venta",
                    ImagenURL = "",
                    Link = "Aliexpress.com"
                }
                ,new Proyecto
                {
                    Titulo = "Mercado Libre",
                    Descripcion = "Pagina de compra y venta",
                    ImagenURL = "",
                    Link = "Mercadolibre.com"
                }
            };
        }
    }
}