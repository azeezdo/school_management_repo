﻿using System;
namespace SchoolManagement.Domain.Entity
{
	public class Student : BaseEntity
	{
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public long TeacherId { get; set; }
        public Teacher Teacher { get; set; }


    }
}

