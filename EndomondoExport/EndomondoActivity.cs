﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EndomondoExport
{
    public class EndomondoActivity
    {
        [XmlIgnore()]
        public string FullContents { get; set; }

    }
}