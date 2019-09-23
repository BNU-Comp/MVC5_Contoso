﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace MVC5_Contoso.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        [StringLength(20), DisplayName("Last Name"), Required]
        public string LastName { get; set; }

        [StringLength(20), DisplayName("First Name"), Required]
        public string FirstName { get; set; }

        [DataType(DataType.Date), DisplayName("Enrollment Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}