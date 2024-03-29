﻿using System;

namespace Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public DateTime OpenTime { get; set; } = DateTime.Now;
        public string Username { get; set; }
        public string Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string Role { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public bool IsActive { get; set; }
        public string? Src { get; set; }
        public string AdminUserName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
