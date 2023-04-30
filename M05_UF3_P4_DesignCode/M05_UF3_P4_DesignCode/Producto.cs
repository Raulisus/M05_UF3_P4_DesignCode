using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace M05_UF3_P4_DesignCode
{
    internal class Producto
    {
        public int id;
        public bool visible;    
        public string nombre;
        public string marca;
        public ArrayList imagenes = new ArrayList();
        public string descripcion;
        public double precio_base;
        public bool descuento;
        public int num_productos;
        public string categoria;
        public string subcategoria;

        public Pedido_Item pedido_Item;
        public Reseña reseña;


    }
}
