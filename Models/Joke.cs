﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesSite.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public String JokeQuestion { get; set; }
        public String JokeAnswer { get; set; }

        public Joke()
        {
                   
        }
    }
}
