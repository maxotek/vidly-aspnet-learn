#region Copyright

// Maxotek CONFIDENTIAL INFORMATION
// © 2007-2016 Maxotek Inc.
// All Rights Reserved
//                                                                   
// This program contains confidential and proprietary information   
// of the Maxotek, Inc.  Any reproduction, disclosure, or use       
// in whole or in part is expressly prohibited, except as may be    
// specifically authorized by prior written agreement.

#endregion

#region Imports

using System.Data.Entity.Migrations;

#endregion

namespace vidly_aspnet_learn.Migrations
{
    public partial class AddMovies : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                {
                    Id = c.Int(false, true),
                    Name = c.String(false, 255),
                    Genre = c.String(false, 255),
                    ReleaseDate = c.DateTime(false),
                    DateAdded = c.DateTime(false),
                    NumberInStock = c.Short(false)
                })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}