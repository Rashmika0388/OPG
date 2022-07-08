using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MySql.Data.EntityFramework;
using MVC_Entity_Framework.Models;
//this is comment

namespace MVC_Entity_Framework.DAL
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DbOrmContext:DbContext
    {
        public DbSet<Person> persons { get; set; }

        public DbOrmContext() : base("WebAppCon")
        {

        }
    }
}
