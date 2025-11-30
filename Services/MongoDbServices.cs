using JobNear.Controller;
using JobNear.Forms;
using JobNear.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobNear.Services
{
    public class MongoDbServices
    {
        private static readonly MongoClient _client;
        private static readonly IMongoDatabase _database;

        static MongoDbServices()
        {
            _client = new MongoClient("mongodb+srv://jusssayson:12345@projectexercises.luow6uq.mongodb.net/");
            _database = _client.GetDatabase("JobNearDB");


            var seekerIndex = Builders<JobSeekerAccountModel>.IndexKeys.Ascending(x => x.Email);
            JobSeekerAccount.Indexes.CreateOne(
                new CreateIndexModel<JobSeekerAccountModel>(seekerIndex, new CreateIndexOptions { Unique = true })
            );

            var posterIndex = Builders<JobPosterAccountModel>.IndexKeys.Ascending(x => x.Email);
            JobPosterAccount.Indexes.CreateOne(
                new CreateIndexModel<JobPosterAccountModel>(posterIndex, new CreateIndexOptions { Unique = true })
            );
        }


        public static IMongoCollection<JobSeekerAccountModel> JobSeekerAccount =>
            _database.GetCollection<JobSeekerAccountModel>("JobSeekerAccounts");

        public static IMongoCollection<JobPosterBusinessModel> JobPosterBusiness =>
            _database.GetCollection<JobPosterBusinessModel>("JobPosterBusinesses");

        public static IMongoCollection<JobPosterAccountModel> JobPosterAccount =>
            _database.GetCollection<JobPosterAccountModel>("JobPosterAccounts");

        public static IMongoCollection<JobPosterJobPostingModel> JobPosterJobPosting =>
            _database.GetCollection<JobPosterJobPostingModel>("JobPosterJobPostings");

        public static IMongoCollection<AdminAccountModel> AdminAccount =>
            _database.GetCollection<AdminAccountModel>("AdminAccounts");

        public static IMongoCollection<UserNotificationModel> UserNotification =>
            _database.GetCollection<UserNotificationModel>("UserNotifications");
        public static IMongoCollection<ReportBusinessModel> ReportBusiness =>
            _database.GetCollection<ReportBusinessModel>("ReportBusinesses");
        public static IMongoCollection<RequirementGuideModel> RequirementGuide =>
            _database.GetCollection<RequirementGuideModel>("RequirementsGuide");
        public static IMongoCollection<ControlSiteNotificationModel> ControlSiteNotification =>
            _database.GetCollection<ControlSiteNotificationModel>("ControlSiteNotification");

        public static IMongoCollection<ControlSiteMaintenanceModel> ControlSiteMaintenance =>
            _database.GetCollection<ControlSiteMaintenanceModel>("ControlSiteMaintenance");


        public static async Task LoginJobNearAccountAsync(string user, string email, string password, Panel app_panel)
        {
            try
            {
                if (user == "jobseeker")
                {
                    var seeker = await JobSeekerAccount
                        .Find(x => x.Email == email)
                        .FirstOrDefaultAsync();

                    if (seeker != null)
                    {
                        var maintenance = await ControlSiteMaintenance
                            .Find(_ => true)
                            .FirstOrDefaultAsync();

                        if (maintenance.IsUnderMaintenance == true)
                        {
                            MaintenanceForm maintenanceForm = new MaintenanceForm();
                            maintenanceForm.ShowDialog();
                        }

                        if (seeker == null)
                        {
                            MessageBox.Show("Email not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (seeker.Password != password)
                        {
                            MessageBox.Show("Incorrect password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        Session.CurrentUserType = "seeker";
                        Session.CurrentUserId = seeker.Id;
                        Session.CurrentEmail = seeker.Email;

                        if (seeker.Latitude != 0 && seeker.Longitude != 0)
                        {
                            Session.CurrentLatitude = seeker.Latitude;
                            Session.CurrentLongitude = seeker.Longitude;
                        }

                        Console.WriteLine($"\n id: {Session.CurrentUserId} \n email: {Session.CurrentEmail} \n lat: {Session.CurrentLatitude} \n lon: {Session.CurrentLongitude}");

                        var userNotif = await MongoDbServices.UserNotification
                            .Find(x => x.NotificationId == Session.CurrentUserId)
                            .ToListAsync();

                        Console.WriteLine($"Found {userNotif.Count} notifications for user {Session.CurrentUserId}");

                        if (userNotif.Count == 0)
                        {
                            string key = "System";
                            string headerMessage = "Welcome to JobNear! Complete your profile to get started.";
                            string remarks = "You must need to make your profile verify for you to browse job.";
                            string type = "Info";
                            DateTime date = DateTime.Now;

                            var systemNotif = new UserNotificationModel
                            {
                                NotificationId = Session.CurrentUserId,
                                Key = key,
                                HeaderMessage = headerMessage,
                                Remarks = remarks,
                                Type = type,
                                Date = date,
                            };

                            await MongoDbServices.UserNotification.InsertOneAsync(systemNotif);
                        }

                        MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormsController.FormLoad(new JobSeekerDashboardForm(), app_panel);
                    }
                    else MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (user == "jobposter")
                {
                    var poster = await JobPosterAccount
                        .Find(x => x.Email == email)
                        .FirstOrDefaultAsync();

                    if (poster != null)
                    {

                        var maintenance = await ControlSiteMaintenance
                            .Find(_ => true)
                            .FirstOrDefaultAsync();

                        if (maintenance.IsUnderMaintenance == true)
                        {
                            MaintenanceForm maintenanceForm = new MaintenanceForm();
                            maintenanceForm.ShowDialog();
                        }

                        if (poster.Email != email)
                        {
                            MessageBox.Show("Email not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (poster.Password != password)
                        {
                            MessageBox.Show("Incorrect password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        Session.CurrentUserType = "poster";
                        Session.CurrentUserId = poster.Id;
                        Session.CurrentEmail = poster.Email;

                        Console.WriteLine($"\n id: {Session.CurrentUserId} \n email: {Session.CurrentEmail}");


                        var userNotif = await MongoDbServices.UserNotification
                            .Find(x => x.NotificationId == Session.CurrentUserId)
                            .ToListAsync();

                        Console.WriteLine($"Found {userNotif.Count} notifications for user {Session.CurrentUserId}");

                        if (userNotif.Count == 0)
                        {
                            string key = "System";
                            string headerMessage = "Welcome to JobNear! Register your business to start posting jobs.";
                            string remarks = "Add and verify your business so job seekers can discover your listings and apply easily.";
                            string type = "Info";
                            DateTime date = DateTime.Now;

                            var systemNotif = new UserNotificationModel
                            {
                                NotificationId = Session.CurrentUserId,
                                Key = key,
                                HeaderMessage = headerMessage,
                                Remarks = remarks,
                                Type = type,
                                Date = date,
                            };

                            await MongoDbServices.UserNotification.InsertOneAsync(systemNotif);
                        }

                        MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormsController.FormLoad(new JobPosterDashboardForm(), app_panel);
                    }
                    else MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Admin or Super Admin Login
                else if (user == "admin")
                {
                    var admin = await AdminAccount
                    .Find(x => x.Email == email)
                    .FirstOrDefaultAsync();

                    if (admin != null)
                    {
                        if (admin.Email != email)
                        {
                            MessageBox.Show("Email not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (admin.Password != password)
                        {
                            MessageBox.Show("Incorrect password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (admin.Status != "Active")
                        {
                            MessageBox.Show("Account is inactive. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        Session.CurrentUserType = "admin";
                        Session.CurrentUserId = admin.Id;
                        Session.CurrentEmail = admin.Email;

                        MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormsController.FormLoad(new AdminDashboardForm(), app_panel);
                    }
                    else MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Unknown user type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while checking user credentials: {ex.Message}");
            }
        }

        public static async Task<bool> InsertJobSeekerAccountAsync(string username, string phone, string email, string password, string status)
        {
            try
            {
                var newAccount = new JobSeekerAccountModel
                {
                    Username = username,
                    Phone = phone,
                    Email = email,
                    Password = password,
                    Status = status
                };

                await JobSeekerAccount.InsertOneAsync(newAccount);
                return true;
            }
            catch (MongoWriteException ex) when (ex.WriteError.Category == ServerErrorCategory.DuplicateKey)
            {
                MessageBox.Show("Email already exists. Please use a different email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while creating account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static async Task<bool> InsertJobPosterAccountAsync(string username, string email, string phone, string password)
        {
            try
            {
                var newAccount = new JobPosterAccountModel
                {
                    Username = username,
                    Phone = phone,
                    Email = email,
                    Password = password
                };

                await JobPosterAccount.InsertOneAsync(newAccount);
                return true;
            }
            catch (MongoWriteException ex) when (ex.WriteError.Category == ServerErrorCategory.DuplicateKey)
            {
                MessageBox.Show("Email already exists. Please use a different email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while creating account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static async Task<bool> InsertBusinessApplicationAsync(string id, string name, string industry, string description, string email, string phone, string website, string address, double lat, double lon, byte[] profile, List<SupportingDocument> docu, string status)
        {
            try
            {
                var newBusiness = new JobPosterBusinessModel
                {
                    BusinessId = id,
                    BusinessName = name,
                    BusinessIndustry = industry,
                    BusinessDescription = description,
                    BusinessAddress = address,
                    BusinessLatitude = lat,
                    BusinessLongitude = lon,
                    BusinessEmail = email,
                    BusinessContact = phone,
                    BusinessLogo = profile,
                    BusinessSite = website,
                    SupportingDocuments = docu,
                    Status = status
                };

                await JobPosterBusiness.InsertOneAsync(newBusiness);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while submitting business application: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static async Task<bool> InsertJobPostingAsync(string id, string address, string title, string employmentType, string workModel, string minQual, string prefQual, string aboutJob, string responsibilities, string paymentType, double monthlySalary, double hourlyRate, string status)
        {
            try
            {
                var newJobPosting = new JobPosterJobPostingModel
                {
                    BusinessId = id,
                    JobAddress = address,
                    JobPosition = title,
                    JobEmploymentType = employmentType,
                    JobWorkModel = workModel,
                    JobMinimumQualification = minQual,
                    JobPreferredQualification = prefQual,
                    JobAbout = aboutJob,
                    JobResponsibilities = responsibilities,
                    JobPaymentType = paymentType,
                    JobMonthlyRate = monthlySalary,
                    JobHourlyRate = hourlyRate,
                    JobStatus = status
                };

                await JobPosterJobPosting.InsertOneAsync(newJobPosting);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while submitting job posting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static async Task<bool> InsertAdminAccountAsync(string email, string password, string fullname, string role, string status)
        {
            try
            {
                var newAccount = new AdminAccountModel
                {
                    Email = email,
                    Password = password,
                    Fullname = fullname,
                    Role = role,
                    Status = status

                };
                await AdminAccount.InsertOneAsync(newAccount);
                return true;

            }
            catch (MongoWriteException ex) when (ex.WriteError.Category == ServerErrorCategory.DuplicateKey)
            {
                MessageBox.Show("Email already exists. Please use a different email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while creating account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static async Task<bool> InsertReportAsync(string seekerId, string businessId, string subject, string description, List<SupportingDocument> docu)
        {
            try
            {
                var newReport = new ReportBusinessModel
                {
                    Complainant = seekerId,
                    Complainee = businessId,
                    Subject = subject,
                    Description = description,
                    SupportingDocuments = docu

                };
                await ReportBusiness.InsertOneAsync(newReport);
                return true;

            }
            catch (MongoWriteException ex) when (ex.WriteError.Category == ServerErrorCategory.DuplicateKey)
            {
                MessageBox.Show("Email already exists. Please use a different email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while creating report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static async Task<bool> InsertVerificationRequirement(string documentName, string documentDescription, string requirementType, string userType, List<SupportingDocument> docu)
        {
            try
            {
                var newDocu = new RequirementGuideModel
                {
                    DocumentName = documentName,
                    DocumentDescription = documentDescription,
                    RequirementType = requirementType,
                    UserType = userType,
                    SupportingDocuments = docu

                };
                await RequirementGuide.InsertOneAsync(newDocu);
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while adding document: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static async Task<bool> InsertControlSite(string maintenanceTitle, string maintenanceDescription, DateTime startDate, DateTime endDatem)
        {
            try
            {
                var newControl = new ControlSiteNotificationModel
                {
                    MaintenanceTitle = maintenanceTitle,
                    MaintenanceDescription = maintenanceDescription,
                    StartDate = startDate,
                    EndDate = endDatem
                };

                await ControlSiteNotification.InsertOneAsync(newControl);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while adding control site: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static async Task<bool> UpdateUserAccount(string email, string password, string user)
        {
            try
            {
                if (user == "jobpster")
                {
                    var posterAccount = Builders<JobPosterAccountModel>.Filter.Eq(x => x.Email, email);

                    var update = Builders<JobPosterAccountModel>.Update
                        .Set(x => x.Password, password);

                    await JobPosterAccount.UpdateOneAsync(posterAccount, update);
                    return true;
                }
                else if (user == "jobseeker")
                {
                    var seekerAccount = Builders<JobSeekerAccountModel>.Filter.Eq(x => x.Email, email);

                    var update = Builders<JobSeekerAccountModel>.Update
                        .Set(x => x.Password, password);

                    await JobSeekerAccount.UpdateOneAsync(seekerAccount, update);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while updating account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static async Task<bool> UpdatePostedJobAsync(string id, string title, string employmentType, string workModel, string minQual, string prefQual, string aboutJob, string responsibilities, string paymentType, double monthlySalary, double hourlyRate, string status)
        {
            try
            {
                var postedJob = Builders<JobPosterJobPostingModel>.Filter.Eq(x => x.Id, id);

                var update = Builders<JobPosterJobPostingModel>.Update
                    .Set(x => x.JobPosition, title)
                    .Set(x => x.JobEmploymentType, employmentType)
                    .Set(x => x.JobWorkModel, workModel)
                    .Set(x => x.JobMinimumQualification, minQual)
                    .Set(x => x.JobPreferredQualification, prefQual)
                    .Set(x => x.JobAbout, aboutJob)
                    .Set(x => x.JobResponsibilities, responsibilities)
                    .Set(x => x.JobPaymentType, paymentType)
                    .Set(x => x.JobMonthlyRate, monthlySalary)
                    .Set(x => x.JobHourlyRate, hourlyRate)
                    .Set(x => x.JobStatus, status);

                await JobPosterJobPosting.UpdateOneAsync(postedJob, update);

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while updating posted job: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static async Task<bool> UpdateJobSeekerProfileAsync(string id, string email, string phone, string lastname, string firstname, string middlename, string sex, string birthdate, short age, string address, double lat, double lon, byte[] profile, List<SupportingDocument> docu, bool isDraft, string status)
        {
            try
            {
                var user = Builders<JobSeekerAccountModel>.Filter.Eq(x => x.Email, email);

                var update = Builders<JobSeekerAccountModel>.Update
                    .Set(x => x.Lastname, lastname)
                    .Set(x => x.Firstname, firstname)
                    .Set(x => x.Middlename, middlename)
                    .Set(x => x.Sex, sex)
                    .Set(x => x.Birthdate, DateTime.Parse(birthdate))
                    .Set(x => x.Age, age)
                    .Set(x => x.Address, address)
                    .Set(x => x.Latitude, lat)
                    .Set(x => x.Longitude, lon)
                    .Set(x => x.Email, email)
                    .Set(x => x.Phone, phone)
                    .Set(x => x.ProfilePicture, profile)
                    .Set(x => x.SupportingDocuments, docu)
                    .Set(x => x.IsDraft, isDraft)
                    .Set(x => x.Status, status);

                await JobSeekerAccount.UpdateOneAsync(user, update);

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while updating profile: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static async Task<bool> UpdateBusinessAsync(string id, string name, string industry, string description, string email, string phone, string website, string address, double lat, double lon, byte[] profile, List<SupportingDocument> docu, string status)
        {
            try
            {
                var business = Builders<JobPosterBusinessModel>.Filter.Eq(x => x.Id, id);
                var update = Builders<JobPosterBusinessModel>.Update
                    .Set(x => x.BusinessName, name)
                    .Set(x => x.BusinessIndustry, industry)
                    .Set(x => x.BusinessDescription, description)
                    .Set(x => x.BusinessAddress, address)
                    .Set(x => x.BusinessLatitude, lat)
                    .Set(x => x.BusinessLongitude, lon)
                    .Set(x => x.BusinessEmail, email)
                    .Set(x => x.BusinessContact, phone)
                    .Set(x => x.BusinessLogo, profile)
                    .Set(x => x.BusinessSite, website)
                    .Set(x => x.SupportingDocuments, docu)
                    .Set(x => x.Status, status);

                await JobPosterBusiness.UpdateOneAsync(business, update);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while updating business: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static async Task<bool> UpdateAdminAccountAsync(string id, string email, string password, string fullname, string role, string status)
        {
            try
            {
                var adminAccount = Builders<AdminAccountModel>.Filter.Eq(x => x.Id, id);

                var update = Builders<AdminAccountModel>.Update
                    .Set(x => x.Email, email)
                    .Set(x => x.Password, password)
                    .Set(x => x.Fullname, fullname)
                    .Set(x => x.Role, role)
                    .Set(x => x.Status, status);

                await AdminAccount.UpdateOneAsync(adminAccount, update);
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while updating admin account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        public static async Task<JobSeekerAccountModel> LoadCurrentSeekerData()
        {

            var filter = Builders<JobSeekerAccountModel>.Filter.Eq(x => x.Id, Session.CurrentUserId);

            var seeker = await JobSeekerAccount
                .Find(filter)
                .FirstOrDefaultAsync();

            return seeker;
        }


        public static async Task<JobSeekerAccountModel> LoadOnReviewSeekerData()
        {
            var filter = Builders<JobSeekerAccountModel>.Filter.Eq(x => x.IsDraft, false);

            var onReview = await JobSeekerAccount
                .Find(filter)
                .FirstOrDefaultAsync();

            return onReview;
        }



    }
}
