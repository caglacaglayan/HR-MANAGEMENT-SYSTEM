using EntityLayer.Concrete;
using EntityLayer.Concrete.Connection;
using EntityLayer.Concrete.Inventories;
using EntityLayer.Concrete.People;
using EntityLayer.Concrete.System;
using EntityLayer.Concrete.Types;
using EntityLayer.Concrete.Work;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<PersonCard> PersonCards { get; set; }
        public DbSet<PersonFinger> PersonFingers { get; set; }
        public DbSet<PersonPass> PersonPasses { get; set; }
        public DbSet<PersonEdu> PersonEdus { get; set; }
        public DbSet<PersonVisa> PersonVisas { get; set; }
        public DbSet<PersonLeave> PersonLeaves { get; set; }
        public DbSet<PersonSocial> PersonSocials { get; set; }
        public DbSet<PersonDocument> PersonDocuments { get; set; }
        public DbSet<PersonAddress> PersonAddresses { get; set; }

        public DbSet<PersonType> PersonTypes { get; set; }
        public DbSet<SysVisaType> SysVisaTypes { get; set; }
        public DbSet<SysLeaveType> SysLeaveTypes { get; set; }
        public DbSet<SysEduType> SysEduTypes { get; set; }
        public DbSet<SysDocumentType> SysDocumentTypes { get; set; }
        public DbSet<WorkGroupRType> WorkGroupRTypes { get; set; }
        public DbSet<WorkGroupType> WorkGroupTypes { get; set; }

        public DbSet<SysAnnual> SysAnnuals { get; set; }
        public DbSet<SysCountry> SysCountries { get; set; }
        public DbSet<SysLog> SysLogs { get; set; }
        public DbSet<SysUser> SysUsers { get; set; }
        public DbSet<SysPosition> SysPositions { get; set; }
        public DbSet<SysCompany> SysCompanies { get; set; }
        public DbSet<SysDepartment> SysDepartments { get; set; }
        public DbSet<SysModule> SysModules { get; set; }
        public DbSet<SysModuleMenu> SysModuleMenus { get; set; }
        public DbSet<SysLanguage> SysLanguages { get; set; }
        public DbSet<SysFeedback> SysFeedbacks { get; set; }
        public DbSet<SysFeedbackCategory> SysFeedbackCategories { get; set; }
        public DbSet<SysFeedbackTrans> SysFeedbackTrans { get; set; }
        public DbSet<SysWorkGroups> SysWorkGroups { get; set; }
        public DbSet<SysWorkTemp> SysWorkTemps { get; set; }
        public DbSet<SysWorkTempItem> SysWorkTempItems { get; set; }

        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<InvCategory> InvCategories { get; set; }
        public DbSet<InvTrans> InvTrans { get; set; }

        public DbSet<WorkGroup> WorkGroups { get; set; }
        public DbSet<WorkGroupArea> WorkGroupAreas { get; set; }

        public DbSet<InventoryConCategory> InventoryConCategories { get; set; }
        public DbSet<PersonConDepartment> PersonConDepartments { get; set; }
        public DbSet<PersonConPosition> PersonConPositions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SysUser>()
            .HasIndex(p => new { p.Username })
            .IsUnique(true);
        }

    }
}