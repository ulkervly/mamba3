﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Mamba2.Entities
{
    public class Employee:BaseEntity
    {
        public string FullName { get; set; }
        public string Position { get; set; }
        public string Desc { get; set; }
        public string MediaLink {  get; set; }
        public string? EmployeeImageUrl { get; set; }
        public int? CatagoryId { get; set; } 
        public Catagory Catagory { get; set; }
       
        public List<EmployeePosition> EmployeePositions { get; set; }

        public static implicit operator Employee(EmployeePosition v)
        {
            throw new NotImplementedException();
        }
    }
}
