using FluentNHibernate.Mapping;

namespace NHibernateMigrate.Models.Mapping
{
    public class BlogMap : ClassMap<Blog>
    {
        public BlogMap()
        {
            Id(x => x.Id).GeneratedBy.GuidComb();
            Map(x => x.Name);
        } 
    }
}