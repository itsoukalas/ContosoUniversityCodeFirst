using ContosoUniversity.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ContosoUniversity.DAL
{

    //DAL-> Data Access Layer

    /*
     * The main class that coordinates Entity Framework functionality for a given data model is the database context class. 
     * You create this class by deriving from the System.Data.Entity.DbContext class. 
     * https://docs.microsoft.com/en-us/dotnet/api/system.data.entity.dbcontext?redirectedfrom=MSDN&view=entity-framework-6.2.0
     * In your code, you specify which entities are included in the data model. 
     * You can also customize certain Entity Framework behavior
     * 
     */


    public class SchoolContext : DbContext
    {
        /**
         * If you don't specify a connection string or the name of one explicitly, 
         * Entity Framework assumes that the connection string name is the same as the class name. 
         */


    

        public SchoolContext() : base()
        {
        }



        /**
         *DbSet -> An entity set  corresponds to a database table, 
         *and an entity corresponds to a row in the table. 
         * 
         */

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        //prevents table names from being pluralized.
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}