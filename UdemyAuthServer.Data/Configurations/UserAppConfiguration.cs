using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UdemyAuthServer.Core.Entities;

namespace UdemyAuthServer.Data.Configurations
{
    public class UserAppConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.City).HasMaxLength(50);
        }
    }
}