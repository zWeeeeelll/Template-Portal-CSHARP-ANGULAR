using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Linq;
using System.Xml.Linq;
using Template.Data.Mappings;
using Template.Data.Mappings.Location;
using Template.Data.Mappings.Person;
using Template.Data.Mappings.Production;
using Template.Data.Mappings.Sales;
using Template.Data.Mappings.Usr;
using Template.Domain.Entities;
using Template.Domain.Entities.Invent;
using Template.Domain.Entities.Location;
using Template.Domain.Entities.Person;
using Template.Domain.Entities.Production;
using Template.Domain.Entities.Sales;
using Template.Domain.Entities.Usr;

namespace Template.Data.Context
{
    public class PortalContext : DbContext
    {
        public PortalContext(DbContextOptions<PortalContext> options)
            : base(options) { }

        public DbSet<Users> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<ModuleProfile> ModuleProfiles { get; set; }

        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Company> Companies { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductSubCategory> ProductSubCategories { get; set; }

        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<InventoryItem> InventoryItems { get; set; }
        public DbSet<InventoryType> InventoryTypes { get; set; }

        public DbSet<Opportunity> Opportunities { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Concept> Concepts { get; set; }
        public DbSet<Annotation> Annotations { get; set; }
        public DbSet<AnnotationType> AnnotationTypes { get; set; }
        public DbSet<OpportunityType> OpportunityTypes { get; set; }
        public DbSet<Stage> Stages { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Usr
            modelBuilder.ApplyConfiguration(new UsersMap()).Entity<Users>().ToTable("Users", schema: "Usr");
            modelBuilder.ApplyConfiguration(new ProfileMap()).Entity<Profile>().ToTable("Profile", schema: "Usr");
            modelBuilder.ApplyConfiguration(new ModuleMap()).Entity<Module>().ToTable("Module", schema: "Usr");
            modelBuilder.ApplyConfiguration(new ModuleProfileMap()).Entity<ModuleProfile>().ToTable("ModuleProfile", schema: "Usr");
            #endregion



            #region Loc
            modelBuilder.ApplyConfiguration(new CountryMap()).Entity<Country>().ToTable("Country", schema: "Location");
            modelBuilder.ApplyConfiguration(new StateMap()).Entity<State>().ToTable("State", schema: "Location");
            modelBuilder.ApplyConfiguration(new CityMap()).Entity<City>().ToTable("City", schema: "Location");
            modelBuilder.ApplyConfiguration(new AddressMap()).Entity<Address>().ToTable("Address", schema: "Location");
            #endregion

            #region Person
            modelBuilder.ApplyConfiguration(new ContactMap()).Entity<Contact>().ToTable("Contact", schema: "Person");
            modelBuilder.ApplyConfiguration(new CompanyMap()).Entity<Company>().ToTable("Company", schema: "Person");
            #endregion

            #region Production
            modelBuilder.ApplyConfiguration(new ProductMap()).Entity<Product>().ToTable("Product", schema: "Production");
            modelBuilder.ApplyConfiguration(new ProductCategoryMap()).Entity<ProductCategory>().ToTable("ProductCategory", schema: "Production");
            modelBuilder.ApplyConfiguration(new ProductSubCategoryMap()).Entity<ProductSubCategory>().ToTable("ProductSubCategory", schema: "Production");
            #endregion

            #region Inventory
            modelBuilder.ApplyConfiguration(new InventoryMap()).Entity<Inventory>().ToTable("Inventory", schema: "Inventory");
            modelBuilder.ApplyConfiguration(new InventoryItemMap()).Entity<InventoryItem>().ToTable("InventoryItem", schema: "Inventory");
            modelBuilder.ApplyConfiguration(new InventoryTypeMap()).Entity<InventoryType>().ToTable("InventoryType", schema: "Inventory");
            #endregion

            #region Sales
            modelBuilder.ApplyConfiguration(new OpportunityMap()).Entity<Opportunity>().ToTable("Opportunity", schema: "Sales");
            modelBuilder.ApplyConfiguration(new OrderMap()).Entity<Order>().ToTable("Order", schema: "Sales");
            modelBuilder.ApplyConfiguration(new ConceptMap()).Entity<Concept>().ToTable("Concept", schema: "Sales");
            modelBuilder.ApplyConfiguration(new AnnotationMap()).Entity<Annotation>().ToTable("Annotation", schema: "Sales");
            modelBuilder.ApplyConfiguration(new AnnotationTypeMap()).Entity<AnnotationType>().ToTable("AnnotationType", schema: "Sales");
            modelBuilder.ApplyConfiguration(new OpportunityTypeMap()).Entity<OpportunityType>().ToTable("OpportunityType", schema: "Sales");
            modelBuilder.ApplyConfiguration(new StageMap()).Entity<Stage>().ToTable("Stage", schema: "Sales");
            modelBuilder.ApplyConfiguration(new OrderProductMap()).Entity<OrderProduct>().ToTable("OrderProduct", schema: "Sales");
            #endregion

            ApplyGlobalStandards(modelBuilder);
            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            Module[] _modules = new[]
            {
                new Module { Id = 1, Name = "Dashboard", Icon = "dashboard.png", URL = "dashboard", IsActive = true, Sequence = 1 },
                new Module { Id = 2, Name = "Users", Icon = "users.png", URL = "users", IsActive = true, Sequence = 2 },
                new Module { Id = 3, Name = "Account", Icon = "accounts.png", URL = "accounts", IsActive = true, Sequence = 3 },
            };

            Profile[] _profiles = new[]
            {
                new Profile { Id = 1, Name = "Admin", IsActive = true },
                new Profile { Id = 2, Name = "User", IsActive = true, IsDefault = true }
            };

            Users[] _users = new[]
            {
                new Users { Id = 1, Name = "Admin", IsActive = true, Email = "admin@template.com",
                    IsAuthorised = true, Password = "8D66A53A381493BEC08DA23CEF5A43767F20A42C", CreatedUser = 1,
                    CreatedDate = DateTime.Now, ProfileId = 1},
                new Users { Id = 2, Name = "User", IsActive = true, Email = "user@template.com",
                    IsAuthorised = true, Password = "8D66A53A381493BEC08DA23CEF5A43767F20A42C", CreatedUser = 1,
                    CreatedDate = DateTime.Now, ProfileId = 2}
            };

            ModuleProfile[] _moduleProfiles = new[]
            {
                new ModuleProfile{ ProfileId = 1, ModuleId = 1 },
                new ModuleProfile{ ProfileId = 1, ModuleId = 2 },
                new ModuleProfile{ ProfileId = 1, ModuleId = 3 },
                new ModuleProfile{ ProfileId = 2, ModuleId = 1 },
                new ModuleProfile{ ProfileId = 2, ModuleId = 3 }
            };

            modelBuilder.Entity<Module>().HasData(_modules);
            modelBuilder.Entity<Profile>().HasData(_profiles);
            modelBuilder.Entity<Users>().HasData(_users);
            modelBuilder.Entity<ModuleProfile>().HasData(_moduleProfiles);

        }

        private ModelBuilder ApplyGlobalStandards(ModelBuilder builder)
        {
            foreach (IMutableEntityType entityType in builder.Model.GetEntityTypes())
            {
                entityType.GetForeignKeys()
                    .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade).ToList()
                    .ForEach(fe => fe.DeleteBehavior = DeleteBehavior.Restrict);

                foreach (IMutableProperty property in entityType.GetProperties())
                {
                    switch (property.Name)
                    {
                        case nameof(Entity.Id):
                            property.IsKey();
                            break;
                        case nameof(Entity.UpdatedData):
                            property.IsNullable = true;
                            break;
                        case nameof(Entity.CreatedDate):
                            property.IsNullable = false;
                            property.SetColumnType("datetime");
                            property.SetDefaultValueSql("CURRENT_TIMESTAMP");
                            break;
                        case nameof(Entity.IsActive):
                            property.IsNullable = false;
                            property.SetDefaultValue(true);
                            break;
                    }
                }
            }

            return builder;
        }
    }
}
