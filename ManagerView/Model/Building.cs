﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Building
    {
        public string Name { get; set; }
        public Player Owner { get; set; }
        public int Price { get; set;  }
         
        public int Shtraf { get; set; }
    }
}
