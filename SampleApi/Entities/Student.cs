using System;
using System.ComponentModel.DataAnnotations;

namespace SampleApi.Entities
{
    public class Student
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public int ClassId { get; set; }
        public DateTime DateOfBirth { get; set; }
        [StringLength(200)]
        public string Address { get; set; }
        public GenderType Gender { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Address} {DateOfBirth:dđ/MM/yyyy} {(Gender == GenderType.Male ? "Nam" : "Nữ")}";
        }
    }

    public enum GenderType : byte
    {
        /// <summary>
        /// Nam
        /// </summary>
        Male = 0,
        /// <summary>
        /// Nữ
        /// </summary>
        Female = 1
    }
}
