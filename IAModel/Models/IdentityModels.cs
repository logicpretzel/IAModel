﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace IAModel.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
        //Additional Properties

        //[RegularExpression(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", ErrorMessage = "Email Address is not Valid.")]

        public int UserType { get; set; }
        [Display(Name = "Choose Company:")]
        public int ClientID { get; set; }
        [Display(Name = "I am a new client:")]
        public bool NewClient { get; set; }
        //       [StringLength(200, MinimumLength = 4, ErrorMessage = "Company Name Length Between 4 to 200 character")]
        [StringLength(200)]
        [Display(Name = "Company Name:")]
        public string CompanyName { get; set; }

        [StringLength(50)]
        [Display(Name = "Contact Phone:")]
        public string Phone { get; set; }

        [StringLength(50)]
        [Display(Name = "Best Time to Call:")]
        public string ContactTime { get; set; }
        


    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {

        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        DbSet<Client> Clients { get; set; }
        DbSet<AssetType> AssetTypes { get; set; }
        DbSet<Asset> Assets { get; set; }
        DbSet<ClientAsset> ClientAssets {get; set;}
        DbSet<FileLog> FileLogs { get; set; }
        DbSet<TransactionLog> TransactionLogs { get; set; }


    }
}