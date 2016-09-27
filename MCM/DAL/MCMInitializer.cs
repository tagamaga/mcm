using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MCM.Models;

namespace MCM.DAL
{
    public class MCMInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MCMContext>
    {
        protected override void Seed(MCMContext context)
        {
            base.Seed(context);
        }
    }
}