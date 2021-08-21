﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class AulaVirtualEntidad
    {

    }

    public class TipoDeEvaluacionEntidad : TokenEntidad
    {
        public int IdTipoEvaluacion { get; set; }
        public string TxtNombreEvaluacion { get; set; }
        public string TxtDescripcion { get; set; }
        public int IntMaxPalabras { get; set; }
    }

    public class WorksheetHeaderEntidad : TokenEntidad
    {
        public int IdWorksheetHeader { get; set; }
        public string ImgLogo { get; set; }
        public string FechaAplicacion { get; set; }
        public string TxtDocente { get; set; }
        public string TxtTipoWorksheet { get; set; }
    }

    public class WorksheetBodyEntidad : TokenEntidad
    {
        public int IdWorksheetBody { get; set; }
        public int IdWorksheetHeader { get; set; }
    }

    public class WorksheetSeccionEntidad : TokenEntidad
    {
        public int IdWorksheetSeccion { get; set; }
        public int IdWorksheetBody { get; set; }
        public int IdTipoEvaluacion { get; set; }
        public string TxtComposicion { get; set; }
    }

    public class WorksheetPalabraEntidad : TokenEntidad
    {
        public int IdWorksheetPalabra { get; set; }
        public int IdWorksheetSeccion { get; set; }
        public int IdPalabra { get; set; }
        public string Composicion { get; set; }
    }
}