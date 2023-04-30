using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace M05_UF3_P4_DesignCode
{
    internal class Pedido
    {
        public int num_pedidos;
        public DateTime fecha_pedido;
        public ArrayList productos = new ArrayList();
        public int cantidad;
        public bool precio_final;
        public string sistema_pago;

        public Usuario usuario;
        public Pedido_Item pedido_Item;

        public void calcular_cantidad()
        {

        }

        public void calcular_precio()
        {

        }
    }
}
