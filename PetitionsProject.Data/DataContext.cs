using Microsoft.EntityFrameworkCore;
using PetitionsProject.Data.Models.Common;
using PetitionsProject.Data.Models.Finances;
using PetitionsProject.Data.Models.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetitionsProject.Data
{
    public class DataContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Region> Regions { get; set; }

        public DbSet<AccountWallet> AccountWallets { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<CurrencyOperation> CurrencyOperations { get; set; }
        public DbSet<CurrencyOperationGrant> CurrencyOperationGrants { get; set; }
        public DbSet<TransactionDirection> TransactionDirections { get; set; }
        public DbSet<WalletTransaction> WalletTransactions { get;set; }


        public DataContext(DbContextOptions options) : base(options)
        {
        }
    }
}
