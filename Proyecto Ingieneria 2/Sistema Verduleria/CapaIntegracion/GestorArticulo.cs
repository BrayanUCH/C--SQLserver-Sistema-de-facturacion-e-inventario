using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVerduleria.CapaLogica.LogicaNegocio;
using SistemaVerduleria.CapaLogica.Servicios;
using System.Data;
using SistemaVerduleria.CapaConexion;

namespace SistemaVerduleria.CapaIntegracion
{
    public class GestorArticulo : servicio, IDisposable
    {
        public GestorArticulo()
        {

        }

        public void Dispose()
        {

        }

        public string Insertar(string articulos_Codigo, string articulos_Descripcion, string articulos_Nombre, string articulos_FamiliaID, string articulos_UnidadesMedidaID, double articulos_CantidadUnidadesMedida, double articulos_Precio, double articulos_Descuento, double articulos_Impuesto, string articulos_Estado)
        {
            Articulos insertarOBJ = new Articulos(articulos_Codigo, articulos_Descripcion, articulos_Nombre, articulos_FamiliaID, articulos_UnidadesMedidaID, articulos_CantidadUnidadesMedida, articulos_Precio, articulos_Descuento, articulos_Impuesto, articulos_Estado);

            using (ServicioArticulo objServico = new ServicioArticulo())
                return objServico.Insertar(insertarOBJ);

        }
        public string Modificar(int articulo_id, string articulos_Codigo, string articulos_Descripcion, string articulos_Nombre, string articulos_FamiliaID, string articulos_UnidadesMedidaID, double articulos_CantidadUnidadesMedida, double articulos_Precio, double articulos_Descuento, double articulos_Impuesto, string articulos_Estado)
        {
            Articulos modificarOBJ = new Articulos(articulo_id, articulos_Codigo, articulos_Descripcion, articulos_Nombre, articulos_FamiliaID, articulos_UnidadesMedidaID, articulos_CantidadUnidadesMedida, articulos_Precio, articulos_Descuento, articulos_Impuesto, articulos_Estado);

            using (ServicioArticulo objServico = new ServicioArticulo())
                return objServico.Modificar(modificarOBJ);
        }
        public DataTable ListarA()
        {
            using (ServicioArticulo objServico = new ServicioArticulo())
                return objServico.ListarA();
        }

        public object ListarI()
        {
            using (ServicioArticulo objServico = new ServicioArticulo())
                return objServico.ListarI();
        }

        public object ListarPF(string Familia, string Producto)
        {
            using (ServicioArticulo objServico = new ServicioArticulo())
                return objServico.ListarPF(Familia, Producto);
        }

        public object ListarF(string Familia)
        {
            using (ServicioArticulo objServico = new ServicioArticulo())
                return objServico.ListarF(Familia);
        }

        public object ListarP(String Producto)
        {
            using (ServicioArticulo objServico = new ServicioArticulo())
                return objServico.ListarP(Producto);
        }
        public object ListarFiltradoP(String Producto)
        {
            using (ServicioArticulo objServico = new ServicioArticulo())
                return objServico.ListarFiltradoP(Producto);
        }
        public DataSet Consultar(int id)
        {
            using (ServicioArticulo objServico = new ServicioArticulo())
            {
                return objServico.Consultar(id);
            }
        }

        public string Activar(int id)
        {
            using (ServicioArticulo objServico = new ServicioArticulo())
            {
                return objServico.Activar(id);
            }
        }

        public string Inactivar(int id)
        {
            using (ServicioArticulo objServico = new ServicioArticulo())
            {
                return objServico.Inactivar(id);
            }
        }

        public string Eliminar(int id)
        {
            using (ServicioArticulo objServico = new ServicioArticulo())
            {
                return objServico.Eliminar(id);
            }
        }
    }
}