﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class User : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string CPF { get; set; }

        public string Email { get; set; }

        public string Telephone { get; set; }

        public string NickName { get; set; }

        public string Password { get; set; }
    }
}
