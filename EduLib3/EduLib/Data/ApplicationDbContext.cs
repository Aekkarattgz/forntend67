namespace EduLib.Data;
using EduLib.Models;
using Microsoft.EntityFrameworkCore;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){

    }
    // <ชื่อ Model> ชื่อตาราง
    public DbSet<User> Users_tb { get;set;}
    public DbSet<Book> Books_tb { get;set;}
    public DbSet<Category> Category_tb { get;set;}
}