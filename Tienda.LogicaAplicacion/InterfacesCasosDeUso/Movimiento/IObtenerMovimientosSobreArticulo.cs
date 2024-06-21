﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.LogicaAplicacion.DTOs;

namespace Tienda.LogicaAplicacion.InterfacesCasosDeUso.Movimiento
{
    public interface IObtenerMovimientosSobreArticulo
    {
        public IEnumerable<MovimientoDTO> ObtenerMovimientos(int idArticulo, string tipoMovimiento, int pagina);
    }
}
