﻿using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaLogica
{
    public  class logReserva
    {
        #region sigleton
       
        private static readonly logReserva _instancia = new logReserva();
        //privado para evitar la instanciación directa
        public static logReserva Instancia
        {
            get
            {
                return logReserva._instancia;
            }
        }
        #endregion singleton
        #region metodos


        ///listado
        public List<entReserva> ListarReserva()
        {
            return datReserva.Instancia.ListarReserva();
        }

        public void InsertarReserva(entReserva e)
        {
            datReserva.Instancia.InsertarReserva(e);
        }
        //editar
        public void EditarReserva(entReserva e)
        {
            datReserva.Instancia.EditarReserva(e);
        }
        #endregion metodos

    }
}
