namespace NHibernateMigrate.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class BlogAndPostHasNoPrimaryKeys : DbMigration
    {
        public override void Up()
        {
            Sql("alter table Posts add primary key (Id)");
            Sql("alter table Blogs add primary key (Id)");
        }
        
        public override void Down()
        {
        }
    }
}
