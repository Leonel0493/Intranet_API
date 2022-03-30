using Intranet_API.DataModels;
using Intranet_API.DataModels.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Intranet_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<t_Country> Countries { get; set; }
        public DbSet<t_CountryRegion> CountriesRegion { get; set; }
        public  DbSet<t_Department> Departments { get; set; }
        public DbSet<t_Employees> Employees { get; set; }
        public DbSet<t_Person> Persons { get; set; }
        public DbSet<t_PersonalDocument> PersonDocuments { get; set; }
        public DbSet<t_PersonalDocumentType> PersonDocumentsType { get; set; }
        public DbSet<t_Positions> Positions { get; set; }
        public DbSet<t_RegionDelegation> RegionDelegation { get; set; }
        public DbSet<t_Units> Units { get; set; }
        
        public DbSet<spUserLogin> UserLogin { get; set; }
        //public DbSet<v_EmployeeInfo> v_EmployeeInfos { get; set; }

    }
}
