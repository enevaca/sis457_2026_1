using CadMinerva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnMinerva
{
    public class ProductoCln
    {
        public static int crear(Producto producto)
        {
            using (var context = new MinervaEntities())
            {
                context.Producto.Add(producto);
                context.SaveChanges();
                return producto.id;
            }
        }

        public static int modificar(Producto producto)
        {
            using (var context = new MinervaEntities())
            {
                var existente = context.Producto.Find(producto.id);
                if (existente != null)
                {
                    existente.idUnidadMedida = producto.idUnidadMedida;
                    existente.codigo = producto.codigo;
                    existente.descripcion = producto.descripcion;
                    existente.saldo = producto.saldo;
                    existente.precioVenta = producto.precioVenta;
                    existente.usuarioRegistro = producto.usuarioRegistro;
                    return context.SaveChanges();
                }
                return 0;
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new MinervaEntities())
            {
                var existente = context.Producto.Find(id);
                if (existente != null)
                {
                    existente.estado = -1;
                    existente.usuarioRegistro = usuarioRegistro;
                    return context.SaveChanges();
                }
                return 0;
            }
        }

        public static Producto obtenerUno(int id)
        {
            using (var context = new MinervaEntities())
            {
                return context.Producto.Find(id);
            }
        }

        public static List<Producto> listar()
        {
            using (var context = new MinervaEntities())
            {
                return context.Producto
                    .Where(x => x.estado == 1)
                    .OrderBy(x => x.descripcion)
                    .ToList();
            }
        }

        public static List<paProductoListar_Result> listarPa(string parametro)
        {
            using (var context = new MinervaEntities())
            {
                return context.paProductoListar(parametro.Trim()).ToList();
            }
        }
    }
}
