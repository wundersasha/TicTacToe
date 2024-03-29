using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicTacToe.Api.Models;

namespace TicTacToe.Api.Data.EntityConfigurations
{
    public class PlayerEntityTypeConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.ToTable("Players").HasKey(p => p.PlayerId);
            builder.HasIndex(p => p.Name).IsUnique(true);
            builder.Property(p => p.Name).IsRequired(true);
        }
    }
}