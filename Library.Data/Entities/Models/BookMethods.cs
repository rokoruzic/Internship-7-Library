﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Entities.Models
{
   public partial class Book
    {
        public override string ToString()
        {
            return $"{Name}({BookId})";
        }
    }
}
