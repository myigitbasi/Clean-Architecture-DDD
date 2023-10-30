﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureApp.Domain.Entities
{
    public sealed class User
    {
        public Ulid Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string  Username { get; set; }
        public string  Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
    }
}
