using System;
using batchmailr.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace batchmailr
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        public DbSet<Email> Emails { get; set; }

        public DbSet<TextTemplate> TextTemplates { get; set; }

        public DbSet<LayoutTemplate> LayoutTemplates { get; set; }

        public DbSet<Recipient> Recipients { get; set; }

        public DbSet<RecipientList> RecipientLists { get; set; }
    }
}