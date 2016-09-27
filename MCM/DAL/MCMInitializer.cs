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
            var usertypes = new List<UserType>
            {
                new UserType{UserTypeCode="ADM", UserTypeName="Administrator", UserTypeInfo="System Administrator/ Operator - MCM Staff", UserTypeActive=true},
                new UserType{UserTypeCode="MEM", UserTypeName="Member", UserTypeInfo="Member - Donor/ receiver", UserTypeActive=true}
            };
            usertypes.ForEach(x => context.UserTypes.Add(x));
            context.SaveChanges();

            var users = new List<User>
            {
                new User{UserTypeID=1, UserFname="Taga", UserLname="Maga", UserPassword="Admin123!",UserActive=true},
                new User{UserTypeID=2, UserFname="Percy", UserLname="Chipuma", UserPassword="Member!123", UserActive=true},
                new User{UserTypeID=1, UserFname="Ben", UserLname="Ochora", UserPassword="Admin!123",UserActive=false},
                new User{UserTypeID=2, UserFname="Placky", UserLname="Bizure", UserPassword="Member123!",UserActive=false},
                new User{UserTypeID=2, UserFname="Mutsa", UserLname="Maga", UserPassword="Member789!",UserActive=true},
                new User{UserTypeID=2, UserFname="Nyasha", UserLname="Ruzvidzo", UserPassword="Member!789",UserActive=true}
            };
            users.ForEach(x => context.Users.Add(x));
            context.SaveChanges();
        }
    }
}