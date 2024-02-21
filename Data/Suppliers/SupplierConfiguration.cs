using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Internship.Data
{

    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
           builder.ToTable(name:nameof(Supplier));
           builder.HasKey(x => x.Id);
           builder.Property(x => x.Name).IsRequired();
           builder.Property(x=>x.Location).IsRequired();
           builder.Property(x=>x.Active).IsRequired();
        }
    }
}
