using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Model.EF
{
    public partial class RestaurantManagementDBContext : DbContext
    {
        public RestaurantManagementDBContext()
            : base("name=RestaurantManagementDBContext")
        {
        }

        public virtual DbSet<AUDIT_LOGS> AUDIT_LOGS { get; set; }
        public virtual DbSet<CATEGORIES> CATEGORIES { get; set; }
        public virtual DbSet<MENUITEMS> MENUITEMS { get; set; }
        public virtual DbSet<MENUITEMVARIANTS> MENUITEMVARIANTS { get; set; }
        public virtual DbSet<ORDERITEMS> ORDERITEMS { get; set; }
        public virtual DbSet<ORDERS> ORDERS { get; set; }
        public virtual DbSet<PAYMENTS> PAYMENTS { get; set; }
        public virtual DbSet<PRINT_JOBS> PRINT_JOBS { get; set; }
        public virtual DbSet<QRTOKENS> QRTOKENS { get; set; }
        public virtual DbSet<RECEIPTS> RECEIPTS { get; set; }
        public virtual DbSet<RESTAURANTS> RESTAURANTS { get; set; }
        public virtual DbSet<ROLES> ROLES { get; set; }
        public virtual DbSet<STATIONS> STATIONS { get; set; }
        public virtual DbSet<TABLES> TABLES { get; set; }
        public virtual DbSet<USERS> USERS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AUDIT_LOGS>()
                .Property(e => e.ACTION)
                .IsUnicode(false);

            modelBuilder.Entity<AUDIT_LOGS>()
                .Property(e => e.ENTITY)
                .IsUnicode(false);

            modelBuilder.Entity<AUDIT_LOGS>()
                .Property(e => e.IP_ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<CATEGORIES>()
                .HasMany(e => e.MENUITEMS)
                .WithRequired(e => e.CATEGORIES)
                .HasForeignKey(e => e.CATEGORY_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MENUITEMS>()
                .Property(e => e.PRICE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MENUITEMS>()
                .Property(e => e.IMAGE_URL)
                .IsUnicode(false);

            modelBuilder.Entity<MENUITEMS>()
                .HasMany(e => e.MENUITEMVARIANTS)
                .WithRequired(e => e.MENUITEMS)
                .HasForeignKey(e => e.MENUITEM_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MENUITEMS>()
                .HasMany(e => e.ORDERITEMS)
                .WithRequired(e => e.MENUITEMS)
                .HasForeignKey(e => e.MENUITEM_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MENUITEMVARIANTS>()
                .Property(e => e.EXTRA_PRICE)
                .HasPrecision(10, 2);

            modelBuilder.Entity<MENUITEMVARIANTS>()
                .HasMany(e => e.ORDERITEMS)
                .WithOptional(e => e.MENUITEMVARIANTS)
                .HasForeignKey(e => e.MENUITEMVARIANT_ID);

            modelBuilder.Entity<ORDERITEMS>()
                .Property(e => e.UNIT_PRICE)
                .HasPrecision(10, 2);

            modelBuilder.Entity<ORDERITEMS>()
                .Property(e => e.LINE_TOTAL)
                .HasPrecision(10, 2);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.ORDER_TOKEN)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .HasMany(e => e.ORDERITEMS)
                .WithRequired(e => e.ORDERS)
                .HasForeignKey(e => e.ORDER_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ORDERS>()
                .HasMany(e => e.PAYMENTS)
                .WithRequired(e => e.ORDERS)
                .HasForeignKey(e => e.ORDER_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ORDERS>()
                .HasMany(e => e.PRINT_JOBS)
                .WithOptional(e => e.ORDERS)
                .HasForeignKey(e => e.ORDER_ID);

            modelBuilder.Entity<ORDERS>()
                .HasMany(e => e.RECEIPTS)
                .WithRequired(e => e.ORDERS)
                .HasForeignKey(e => e.ORDER_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PAYMENTS>()
                .Property(e => e.METHOD)
                .IsUnicode(false);

            modelBuilder.Entity<PAYMENTS>()
                .Property(e => e.PROVIDER)
                .IsUnicode(false);

            modelBuilder.Entity<PAYMENTS>()
                .Property(e => e.PROVIDER_REF)
                .IsUnicode(false);

            modelBuilder.Entity<PRINT_JOBS>()
                .Property(e => e.PRINTER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<QRTOKENS>()
                .Property(e => e.TOKEN)
                .IsUnicode(false);

            modelBuilder.Entity<QRTOKENS>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTS>()
                .Property(e => e.RECEIPT_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTS>()
                .Property(e => e.METHOD)
                .IsUnicode(false);

            modelBuilder.Entity<RESTAURANTS>()
                .Property(e => e.TIMEZONE)
                .IsUnicode(false);

            modelBuilder.Entity<RESTAURANTS>()
                .HasMany(e => e.CATEGORIES)
                .WithRequired(e => e.RESTAURANTS)
                .HasForeignKey(e => e.RESTAURANT_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RESTAURANTS>()
                .HasMany(e => e.MENUITEMS)
                .WithRequired(e => e.RESTAURANTS)
                .HasForeignKey(e => e.RESTAURANT_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RESTAURANTS>()
                .HasMany(e => e.ORDERS)
                .WithRequired(e => e.RESTAURANTS)
                .HasForeignKey(e => e.RESTAURANT_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RESTAURANTS>()
                .HasMany(e => e.STATIONS)
                .WithRequired(e => e.RESTAURANTS)
                .HasForeignKey(e => e.RESTAURANT_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RESTAURANTS>()
                .HasMany(e => e.TABLES)
                .WithRequired(e => e.RESTAURANTS)
                .HasForeignKey(e => e.RESTAURANT_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RESTAURANTS>()
                .HasMany(e => e.USERS)
                .WithRequired(e => e.RESTAURANTS)
                .HasForeignKey(e => e.RESTAURANT_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ROLES>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ROLES>()
                .HasMany(e => e.USERS)
                .WithRequired(e => e.ROLES)
                .HasForeignKey(e => e.ROLE_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<STATIONS>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<STATIONS>()
                .HasMany(e => e.MENUITEMS)
                .WithOptional(e => e.STATIONS)
                .HasForeignKey(e => e.STATION_ID);

            modelBuilder.Entity<TABLES>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLES>()
                .HasMany(e => e.ORDERS)
                .WithRequired(e => e.TABLES)
                .HasForeignKey(e => e.TABLE_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TABLES>()
                .HasMany(e => e.QRTOKENS)
                .WithRequired(e => e.TABLES)
                .HasForeignKey(e => e.TABLE_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USERS>()
                .Property(e => e.USERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<USERS>()
                .Property(e => e.PASSWORD_HASH)
                .IsUnicode(false);

            modelBuilder.Entity<USERS>()
                .HasMany(e => e.AUDIT_LOGS)
                .WithOptional(e => e.USERS)
                .HasForeignKey(e => e.ACTOR_ID);

            modelBuilder.Entity<USERS>()
                .HasMany(e => e.RECEIPTS)
                .WithRequired(e => e.USERS)
                .HasForeignKey(e => e.ISSUED_BY)
                .WillCascadeOnDelete(false);
        }
    }
}
