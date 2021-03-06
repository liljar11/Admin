﻿using Microsoft.AspNet.Identity.EntityFramework;

namespace AdminWeb.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
		public int CompanyID { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
			: base("vasinn_dbConnectionString")
        {
        }
    }
}