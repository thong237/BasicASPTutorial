using BasicASPTutorial.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicASPTutorial.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options ) : base(options) 
        { 
        
        }
        public DbSet<Student> Students { get; set; } // คำสั่งนี้ไว้ใช้สำหรับ PM>add-migration addStudentDb>ไฟล์ เพื่อแปลง model ให้สร้างตารางใน database server


    }
}
