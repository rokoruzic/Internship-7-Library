﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Entities.Models
{
    public partial class Student
    {
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
