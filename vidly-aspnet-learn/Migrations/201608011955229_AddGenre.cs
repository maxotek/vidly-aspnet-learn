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
    public partial class AddGenre : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                {
                    Id = c.Int(false, true),
                    Name = c.String(false, 255)
                })
                .PrimaryKey(t => t.Id);

            AddColumn("dbo.Movies", "GenreId", c => c.Int(false));
            CreateIndex("dbo.Movies", "GenreId");
            AddForeignKey("dbo.Movies", "GenreId", "dbo.Genres", "Id", true);
            DropColumn("dbo.Movies", "Genre");
        }

        public override void Down()
        {
            AddColumn("dbo.Movies", "Genre", c => c.String(false, 255));
            DropForeignKey("dbo.Movies", "GenreId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] {"GenreId"});
            DropColumn("dbo.Movies", "GenreId");
            DropTable("dbo.Genres");
        }
    }
}