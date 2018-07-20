﻿using Google.Service.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace Google.Service.Dtos
{
    public class AccountDto : IDto
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}".Trim();

        public string ProfileImageUrl { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}