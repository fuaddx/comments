using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Twitter.Core.Entities;

namespace Twitter.Dal.Configurations
{
    public class CommentConfiguration: IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> modelBuilder)
        {
            modelBuilder.Property(x => x.Content).IsRequired()
                .HasMaxLength(50);
            modelBuilder
                .HasOne(c => c.ParentComment)
                .WithMany(c => c.Childs)
                .HasForeignKey(c => c.ParentCommentId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.HasOne(c => c.AppUser)
           .WithMany(c=>c.Comments)
           .HasForeignKey(c => c.AppUserId).
           OnDelete(DeleteBehavior.NoAction);


            modelBuilder.HasOne(c => c.Post)
           .WithMany(c => c.Comments)
           .HasForeignKey(c => c.PostId).
           OnDelete(DeleteBehavior.NoAction);
        }
    }
}
