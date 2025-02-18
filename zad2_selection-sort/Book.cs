﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2_selection_sort
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
        public override string ToString()
        {
            return $"{Title} - {Author}";
        }
    }
}
