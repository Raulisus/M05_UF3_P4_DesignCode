using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace M05_UF3_P4_DesignCode
{
    internal class Usuario
    {
        private string nombre;
        private string apellido;
        public string correo_electronico;
        private string contraseña;
        private int telefono;
        private string direccion;
        private string dni;
        public ArrayList lista_deseos = new ArrayList ();
        private ArrayList carrito = new ArrayList();

        public Pedido pedido;
        public Reseña reseña;

    }
}
