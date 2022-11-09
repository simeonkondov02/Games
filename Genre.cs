﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesClassLibrary
{
    public class Genre
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public List<Game> Games { get; set; }
    }
}
