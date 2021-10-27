﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiRest.Controllers
{
    public class MaterialDidacticoController : ApiController
    {
        [HttpPost]
        [Route("api/AgregarHojaEncabezado")]
        public DataTable AgregarHojaEncabezado(Entidades.HojaEncabezado entidad)
        {
            return Datos.MaterialDidacticoDatos.AgregarHojaEncabezado(entidad);
        }

        [HttpPost]
        [Route("api/AgregarHojaCuerpo")]
        public DataTable AgregarHojaCuerpo(Entidades.HojaCuerpo entidad)
        {
            return Datos.MaterialDidacticoDatos.AgregarHojaCuerpo(entidad);
        }

        [HttpPost]
        [Route("api/AgregarHojaSeccion")]
        public DataTable AgregarHojaSeccion(Entidades.HojaSeccion entidad)
        {
            return Datos.MaterialDidacticoDatos.AgregarHojaSeccion(entidad);
        }

        [HttpPost]
        [Route("api/AgregarHojaPalabras")]
        public DataTable AgregarHojaPalabras(Entidades.HojaPalabras entidad)
        {
            return Datos.MaterialDidacticoDatos.AgregarHojaPalabras(entidad);
        }


        [HttpPost]
        [Route("api/VerHojaEncabezado")]
        public DataTable VerHojaEncabezado(Entidades.HojaEncabezado entidad)
        {
            return Datos.MaterialDidacticoDatos.VerHojaEncabezado(entidad);
        }

        [HttpPost]
        [Route("api/VerHojaCuerpo")]
        public DataTable VerHojaCuerpo(Entidades.HojaCuerpo entidad)
        {
            return Datos.MaterialDidacticoDatos.VerHojaCuerpo(entidad);
        }


    }
}