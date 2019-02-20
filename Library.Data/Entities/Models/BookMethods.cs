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

        public string Print()
        {
            return $"{Name}({BookId}) Author: {Author} Publisher: {Publisher} {Pages} pages";
        }
        public string PrintWithoutPublisher()
        {
            return $"{Name}({BookId}) Author: {Author} {Pages} pages";
        }
        public string PrintWithoutAuthor()
        {
            return $"{Name}({BookId}) Publisher {Publisher} {Pages} pages";
        }
    }
}
