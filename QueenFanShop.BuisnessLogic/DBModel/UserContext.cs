using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using QueenFanShop.Models.Enteties.User;

namespace QueenFanShop.BuisnessLogic.DBModel
{
    class UserContext :DbContext
    {
        public virtual DbSet<UDbTable> Users { get; set; }

        public UserContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=mssqlserver02;Database=queenshop;Trusted_Connection=True;");
        }
    }
}
