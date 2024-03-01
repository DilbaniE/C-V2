using CreandoApis.DTO;
using CreandoApis.Modelo;
using CreandoApis.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace CreandoApis.Controllers
{
    [Route("productos")]
    [ApiController]
    public class ProductosController : ControllerBase
    {

        private readonly InProductosEnMemory repositorio;
         
        //constructor del controlador inicializa el objeto producMemory
        public ProductosController(InProductosEnMemory r)
        {
            this.repositorio = r;
        }


        //metodo para ddevolver la lista de productos 5tr
        [HttpGet]
        public IEnumerable<ProducDTO> DameProductos()
        {
            var  listaProductos = repositorio.DameProductos().Select(p=>p.ConvertirDTO());
            return listaProductos;
        }


        [HttpGet("codeProduc")]
        public ActionResult<ProducDTO> GetItem(string codeProduc) { 
            var item = repositorio.DameProducto(codeProduc).ConvertirDTO();
            if (item is null)
            {
                return NotFound();
            }
            return item;

        }
    }
}
