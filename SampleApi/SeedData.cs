using SampleApi.Entities;
using SampleApi.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SampleApi
{
    public class SeedData
    {
        private SampleDbContext Context { get; }

        public SeedData(SampleDbContext context)
        {
            Context = context;
        }

        public void Seed()
        {
            var students = new List<Student>
            {
                new Student { Name = "Nguyễn Văn Bình", ClassId = 1, Address = "Hà Nội", Gender = GenderType.Male, DateOfBirth = new DateTime(1999, 11, 11) },
                new Student { Name = "Nguyễn Khắc Mạnh", ClassId = 1, Address = "Hà Nội", Gender = GenderType.Male, DateOfBirth = new DateTime(1999, 7, 14) },
                new Student { Name = "Nguyễn Đăng Kiên", ClassId = 2, Address = "Bắc Giang", Gender = GenderType.Male, DateOfBirth = new DateTime(1999, 6, 1) },
                new Student { Name = "Trần Thị Bình", ClassId = 4, Address = "Hà Tây", Gender = GenderType.Female, DateOfBirth = new DateTime(2000, 3, 16) },
                new Student { Name = "Vũ Trọng Phụng", ClassId = 2, Address = "Bắc Ninh", Gender = GenderType.Male, DateOfBirth = new DateTime(2001, 1, 25) },
                new Student { Name = "Nguyễn Thị Hồng", ClassId = 3, Address = "Bắc Giang", Gender = GenderType.Female, DateOfBirth = new DateTime(2004, 4, 30) },
                new Student { Name = "Phạm Thị Lan", ClassId = 4, Address = "Hà Nội", Gender = GenderType.Female, DateOfBirth = new DateTime(1996, 7, 19) },
                new Student { Name = "Lê Thị Quỳnh Anh", ClassId = 5, Address = "Nam Định", Gender = GenderType.Female, DateOfBirth = new DateTime(1995, 7, 24) },
                new Student { Name = "Trần Văn Minh", ClassId = 6, Address = "Hải Phòng", Gender = GenderType.Male, DateOfBirth = new DateTime(1996, 9, 30) },
                new Student { Name = "Trần Quang Mạnh", ClassId = 2, Address = "Phú Thọ", Gender = GenderType.Male, DateOfBirth = new DateTime(1999, 10, 29) },
                new Student { Name = "Bùi Quang Long", ClassId = 10, Address = "Phú Thọ", Gender = GenderType.Male, DateOfBirth = new DateTime(1998, 12, 23) },
                new Student { Name = "Nguyễn Tiến Minh", ClassId = 11, Address = "Bắc Giang", Gender = GenderType.Male, DateOfBirth = new DateTime(1999, 11, 23) },
                new Student { Name = "Nguyễn Khắc Mạnh", ClassId = 12, Address = "Bắc Ninh", Gender = GenderType.Male, DateOfBirth = new DateTime(2001, 1, 1) },
                new Student { Name = "Trịnh Văn Quyết", ClassId = 1, Address = "Thái Nguyên", Gender = GenderType.Male, DateOfBirth = new DateTime(1999, 2, 4) },
                new Student { Name = "Trần Văn Linh", ClassId = 8, Address = "Bắc Giang", Gender = GenderType.Male, DateOfBirth = new DateTime(2002, 4, 3) },
                new Student { Name = "Phạm Thị Lan Anh", ClassId = 8, Address = "Hà Nội", Gender = GenderType.Female, DateOfBirth = new DateTime(1999, 7, 17) },
                new Student { Name = "Nguyễn Thị Hồng Ánh", ClassId = 8, Address = "Hà Nội", Gender = GenderType.Female, DateOfBirth = new DateTime(1998, 3, 16) },
                new Student { Name = "Tạ Thu Phương", ClassId = 9, Address = "Bắc Giang", Gender = GenderType.Female, DateOfBirth = new DateTime(1997, 6, 3) },
                new Student { Name = "Lưu Thị Hồng Thủy", ClassId = 5, Address = "Hà Nội", Gender = GenderType.Female, DateOfBirth = new DateTime(1999, 5, 11) },
                new Student { Name = "Lê Nhật Nam", ClassId = 6, Address = "Hà Nội", Gender = GenderType.Male, DateOfBirth = new DateTime(1999, 7, 24) },
                new Student { Name = "Lê Thị Bình", ClassId = 6, Address = "Bắc Giang", Gender = GenderType.Female, DateOfBirth = new DateTime(1995, 2, 23) },
                new Student { Name = "Võ Thị Quỳnh Trang", ClassId = 6, Address = "Hà Nội", Gender = GenderType.Female, DateOfBirth = new DateTime(1993, 11, 11) },
                new Student { Name = "Hoàng Thị Kim Liên", ClassId = 7, Address = "Hà Nội", Gender = GenderType.Female, DateOfBirth = new DateTime(1999, 12, 14) },
                new Student { Name = "Nguyễn Thị Nhật Linh", ClassId = 8, Address = "Bắc Giang", Gender = GenderType.Female, DateOfBirth = new DateTime(1999, 10, 3) },
                new Student { Name = "Nguyễn Đăng Sơn", ClassId = 7, Address = "Hà Nội", Gender = GenderType.Male, DateOfBirth = new DateTime(1995, 9, 11) },
                new Student { Name = "Phạm Thị Phương", ClassId = 10, Address = "Hà Nội", Gender = GenderType.Female, DateOfBirth = new DateTime(1994, 1, 14) },
                new Student { Name = "Huỳnh Thị Ngọc", ClassId = 11, Address = "Bắc Giang", Gender = GenderType.Female, DateOfBirth = new DateTime(1993, 3, 3) },
                new Student { Name = "Phạm Văn Cường", ClassId = 4, Address = "Hà Nội", Gender = GenderType.Male, DateOfBirth = new DateTime(1999, 7, 11) },
                new Student { Name = "Trần Thị Lý", ClassId = 3, Address = "Hà Nội", Gender = GenderType.Female, DateOfBirth = new DateTime(1999, 6, 14) },
                new Student { Name = "Dương Thị Thảo", ClassId = 3, Address = "Bắc Giang", Gender = GenderType.Female, DateOfBirth = new DateTime(2001, 8, 3) },
            };

            var classRooms = new List<ClassRoom>
            {
                new ClassRoom { Name = "1A", Grade = 1 },
                new ClassRoom { Name = "1B", Grade = 1 },
                new ClassRoom { Name = "1C", Grade = 1 },
                new ClassRoom { Name = "2A", Grade = 2 },
                new ClassRoom { Name = "3B", Grade = 3 },
                new ClassRoom { Name = "3C", Grade = 3 },
                new ClassRoom { Name = "3A", Grade = 3 },
                new ClassRoom { Name = "4B", Grade = 4 },
                new ClassRoom { Name = "4C", Grade = 4 },
                new ClassRoom { Name = "5A", Grade = 5 },
                new ClassRoom { Name = "5B", Grade = 5 },
                new ClassRoom { Name = "5C", Grade = 5 }
            };

            if (!Context.ClassRooms.Any())
            {
                Context.ClassRooms.AddRange(classRooms);

                Context.SaveChanges();
            }

            if (Context.Students.Any())
            {
                Context.Students.AddRange(students);

                Context.SaveChanges();
            }
        }
    }
}
