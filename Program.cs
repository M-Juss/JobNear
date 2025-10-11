using JobNear.Forms;
using JobNear.Models;
using JobNear.Services;
using MongoDB.Driver;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JobNear
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new JobSeekerDashboardForm());

//            Mongodb queries template in C# 

//      FindOneMethod:
//          var seeker = await JobSeekerAccount
//              .Find(x => x.Email == email)
//              .FirstOrDefaultAsync();

//      FindManyMethod:

//            var pendingAccounts = await MongoDbServices.JobSeekerAccount
//                .Find(x => x.Status, "pending")
//                .ToListAsync();


//      InsertMethod:
//            var newAccount = new JobSeekerAccountModel
//            {
//                Username = username,
//                Phone = phone,
//                Email = email,
//                Password = password,
//                Status = status
//            };

//            await JobSeekerAccount.InsertOneAsync(newAccount);

//      UpdateOneMethod:
//            var user = Builders<JobSeekerAccountModel>.Filter.Eq(x => x.Email, email);

//            var update = Builders<JobSeekerAccountModel>.Update
//                .Set(x => x.Lastname, lastname)
//                .Set(x => x.Firstname, firstname)
//                .Set(x => x.Middlename, middlename)
//                .Set(x => x.Sex, sex)
//                .Set(x => x.Birthdate, DateTime.Parse(birthdate))

//            await JobSeekerAccount.UpdateOneAsync(user, update);


        }
    }
}