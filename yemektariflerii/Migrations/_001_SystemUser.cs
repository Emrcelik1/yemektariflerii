using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tus1001CLB.Migrations
{
    [Migration(1)]
    public class _001_System_User : Migration
    {
        public override void Down()
        {
            Delete.Table("SystemUser");
        }

        public override void Up()
        {
            Create.Table("SystemUser")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("UserType").AsByte().WithDefaultValue(0)
                .WithColumn("Email").AsString(256)
                .WithColumn("PasswordHash").AsString(256)
                .WithColumn("NameSurName").AsString(128)
                .WithColumn("PhoneNumber").AsString(32)
                .WithColumn("UserState").AsByte().WithDefaultValue(0)
                .WithColumn("ActivationDate").AsDateTime()
                .WithColumn("CreateDate").AsDateTime()
                .WithColumn("LastLogin").AsDateTime()
                .WithColumn("IsDeleted").AsBoolean().WithDefaultValue(0);

        }
    }
}