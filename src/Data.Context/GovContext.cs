using System;
using System.Diagnostics.CodeAnalysis;
using Gov.Entity;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class GovContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountExtend> AccountExtends { get; set; }
        public DbSet<ActionLog> ActionLogs { get; set; }
        public DbSet<ApproveFlow> ApproveFlows { get; set; }
        public DbSet<ApproveFlowSteps> ApproveFlowSteps { get; set; }
        public DbSet<ApproveFlowStatus> ApproveFlowStatuses { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleCatalog> ArticleCatalogs { get; set; }
        public DbSet<ArticleExtend> ArticleExtends { get; set; }
        public DbSet<Authority> Authorities { get; set; }
        public DbSet<AuthorityGroup> AuthorityGroups { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Dictionary> Dictionaries { get; set; }
        public DbSet<EnterpriseInfo> EnterpriseInfos { get; set; }
        public DbSet<EnterpriseExtend> EnterpriseExtends { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Personnel> Personnels { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCatalog> ProductCatalogs { get; set; }
        public DbSet<ProductExtend> ProductExtends { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<WorkOrder> WorkOrders { get; set; }
        public DbSet<WorkOrderExecutor> WorkOrderExecutors { get; set; }
        public DbSet<WorkOrderFlowLog> WorkOrderFlowLogs { get; set; }

        public GovContext([NotNull] DbContextOptions options) : base(options)
        {
        }

        protected GovContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Account>(e =>
            {
                e.HasIndex(a => a.Email);
                e.HasIndex(a => a.Phone);
                e.HasIndex(a => a.Username);
                e.HasIndex(a => a.IsDeleted);
                e.HasIndex(a => a.PhoneConfirm);
                e.HasIndex(a => a.EmailConfirm);
                e.HasIndex(a => a.CreatedTime);
            });
            builder.Entity<AccountExtend>(e =>
            {
                e.HasIndex(a => a.RealName);
                e.HasIndex(a => a.Country);
                e.HasIndex(a => a.Province);
                e.HasIndex(a => a.City);
            });

            builder.Entity<ActionLog>(e =>
            {
                e.HasIndex(m => m.Status);
                e.HasIndex(m => m.ActionType);
                e.HasIndex(m => m.CreatedTime);
                e.HasIndex(m => m.Username);
                e.HasIndex(m => m.UserId);
            });

            builder.Entity<ApproveFlow>(e =>
            {
                e.HasIndex(m => m.Name);
            });
            builder.Entity<ApproveFlowSteps>(e =>
            {
                e.HasIndex(m => m.Step);
                e.HasIndex(m => m.UserId);
                e.HasIndex(m => m.RoleId);
            });
            builder.Entity<ApproveFlowStatus>(e =>
            {
                e.HasIndex(m => m.CreatedTime);
                e.HasIndex(m => m.TargetId);
                e.HasIndex(m => m.RoleId);
                e.HasIndex(m => m.UserId);
            });
            builder.Entity<Article>(e =>
            {
                e.HasIndex(m => m.AuthorName);
                e.HasIndex(m => m.CreatedTime);
                e.HasIndex(m => m.Status);
                e.HasIndex(m => m.Title);

            });
            builder.Entity<ArticleCatalog>(e =>
            {
                e.HasIndex(m => m.Name);
                e.HasIndex(m => m.Level);
                e.HasIndex(m => m.Type);
            });
            builder.Entity<ArticleExtend>(e =>
            {

            });
            builder.Entity<Authority>(e =>
            {
                e.HasIndex(m => m.Name);
                e.HasIndex(m => m.Type);
            });
            builder.Entity<AuthorityGroup>(e =>
            {
                e.HasIndex(m => m.Name);
            });
            builder.Entity<Comment>(e =>
            {
                e.HasIndex(m => m.Status);
            });
            builder.Entity<Dictionary>(e =>
            {
                e.HasIndex(m => m.Key);
                e.HasIndex(m => m.Type);
                e.HasIndex(m => m.ValType);
            });
            builder.Entity<EnterpriseInfo>(e =>
            {
                e.HasIndex(m => m.Name);
                e.HasIndex(m => m.RegDate);
                e.HasIndex(m => m.Type);
                e.HasIndex(m => m.RegistrationStatus);
                e.HasIndex(m => m.RegisteredCapital);
                e.HasIndex(m => m.UnionCode);
                e.HasIndex(m => m.Corporation);
                e.HasIndex(m => m.EndDate);
            });
            builder.Entity<EnterpriseExtend>(e =>
            {
                //e.HasIndex(m => m.);
            });
            builder.Entity<Menu>(e =>
            {
                e.HasIndex(m => m.Name);
                e.HasIndex(m => m.Type);
                e.HasIndex(m => m.Status);
            });
            builder.Entity<Organization>(e =>
            {
                e.HasIndex(m => m.Name);
                e.HasIndex(m => m.Level);
                e.HasIndex(m => m.Province);
                e.HasIndex(m => m.Country);
                e.HasIndex(m => m.City);
                e.HasIndex(m => m.Status);
            });
            builder.Entity<Personnel>(e =>
            {
                e.HasIndex(m => m.PositionTitle);
                e.HasIndex(m => m.RealName);
                e.HasIndex(m => m.Country);
                e.HasIndex(m => m.City);
                e.HasIndex(m => m.Province);
                e.HasIndex(m => m.JobTitle);
                e.HasIndex(m => m.IdentityCard);
                e.HasIndex(m => m.IsFullTime);
                e.HasIndex(m => m.HireDate);
            });
            builder.Entity<Product>(e =>
            {
                e.HasIndex(m => m.Name);
                e.HasIndex(m => m.Status);
                e.HasIndex(m => m.Title);
                e.HasIndex(m => m.UniqueCode);
            });
            builder.Entity<ProductCatalog>(e =>
            {
                e.HasIndex(m => m.Name);
                e.HasIndex(m => m.Type);
            });
            builder.Entity<ProductExtend>(e =>
            {
                //e.HasIndex(m => m.);
            });
            builder.Entity<Role>(e =>
            {
                e.HasIndex(m => m.Name);
                e.HasIndex(m => m.Status);
            });

            builder.Entity<WorkOrder>(e =>
            {
                e.HasIndex(m => m.UniqueCode);
                e.HasIndex(m => m.Type);
                e.HasIndex(m => m.Priority);
                e.HasIndex(m => m.StartDate);
                e.HasIndex(m => m.EndDate);
                e.HasIndex(m => m.TargetName);
                e.HasIndex(m => m.Status);
            });
            builder.Entity<WorkOrderExecutor>(e =>
            {
                e.HasIndex(m => m.Status);
                e.HasIndex(m => m.CreatedTime);
            });

            builder.Entity<WorkOrderFlowLog>(e =>
            {
                e.HasIndex(m => m.Status);
                e.HasIndex(m => m.CreatedTime);
            });
            base.OnModelCreating(builder);
        }
    }
}
