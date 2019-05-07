using APM.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APM.Web.Infrastructure.Core
{
    public class ObjectResult
    {
        public Enums.StatusCode StatusCode { get; set; }

        /// <summary>
        /// Message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Result Object
        /// </summary>
        public object Result { get; set; }
    }
}