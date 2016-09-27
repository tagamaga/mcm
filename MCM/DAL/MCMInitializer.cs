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

            var regions = new List<Region>
            {
                new Region{RegionCode="WC", RegionName="Western Cape", RegionActive=true},
                new Region{RegionCode="GP", RegionName="Gauteng Province", RegionActive=true},
                new Region{RegionCode="EC", RegionName="Eastern Cape", RegionActive=true},
                new Region{RegionCode="KZN", RegionName="Kwa Zulu-Natal", RegionActive=true},
                new Region{RegionCode="FS", RegionName="Free State", RegionActive=true},
                new Region{RegionCode="LP", RegionName="Limpopo Province", RegionActive=true}
            };
            regions.ForEach(x => context.Regions.Add(x));
            context.SaveChanges();

            var cities = new List<City>
            {
                new City{ CityCode="PMB", CityName="Pietermaritzburg", RegionID=4,CityActive=true },
                new City{ CityCode="JHB", CityName="Johannesburg", RegionID=2,CityActive=true },
                new City{ CityCode="PE", CityName="Port Elizabeth", RegionID=3,CityActive=true },
                new City{ CityCode="PE", CityName="Pretoria", RegionID=2,CityActive=true },
                new City{ CityName="George", RegionID=3,CityActive=true },
                new City{ CityCode="POL", CityName="Polokwane", RegionID=6,CityActive=true },
                new City{ CityCode="BLOEM", CityName="Bloemfontein", RegionID=5,CityActive=true },
                new City{ CityCode="CT", CityName="Cape Town", RegionID=1,CityActive=true },
            };
            cities.ForEach(x => context.Cities.Add(x));
            context.SaveChanges();

            var postalcodes = new List<PostalCode>
            {
                new PostalCode{PostalCodeID=7493, PostalCodeActive=true},
                 new PostalCode{PostalCodeID=2090, PostalCodeActive=true},
                  new PostalCode{PostalCodeID=7800, PostalCodeActive=true}
            };
            postalcodes.ForEach(x => context.PostalCodes.Add(x));
            context.SaveChanges();

            var areas = new List<Area>
            {
                new Area{AreaCode="BEL", AreaName="Belhar", CityID=8,  PostalCodeID=7493, AreaActive=true},
                new Area{AreaCode="WYN", AreaName="Wynberg", CityID=2,  PostalCodeID=2090, AreaActive=true},
                new Area{AreaCode="WYN", AreaName="Wynberg", CityID=2,  PostalCodeID=7800, AreaActive=true}
            };
            areas.ForEach(x => context.Areas.Add(x));
            context.SaveChanges();
            
            var suburbs = new List<Suburb>
            {
                new Suburb{AreaID=1, SuburbCode="ERICA", SuburbName="Erica Township", SuburbActive=true},
                new Suburb{AreaID=3, SuburbCode="KENWYN", SuburbName="Kenilworth - Wynberg", SuburbActive=true},
            };
            suburbs.ForEach(x => context.Suburbs.Add(x));
            context.SaveChanges();

        }
    }
}