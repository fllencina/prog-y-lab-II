﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class TrackingIdRepetidoException:Exception
    {
        public TrackingIdRepetidoException(string mensaje):base (mensaje,null)
        {

        }
        public TrackingIdRepetidoException(string mensaje, Exception inner):base (mensaje, inner)
        {

        }
    }
}
