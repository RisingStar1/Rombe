﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RomBe.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class RombeEntities : DbContext
    {
        public RombeEntities()
            : base("name=RombeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Birth> Births { get; set; }
        public virtual DbSet<Child> Children { get; set; }
        public virtual DbSet<ChildActivity> ChildActivities { get; set; }
        public virtual DbSet<ChildActivitiesHistory> ChildActivitiesHistories { get; set; }
        public virtual DbSet<ChildRealTimeSolutionActivity> ChildRealTimeSolutionActivities { get; set; }
        public virtual DbSet<ChildRealTimeSymptomsActivity> ChildRealTimeSymptomsActivities { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CrudUser> CrudUsers { get; set; }
        public virtual DbSet<CrudUsersLogin> CrudUsersLogins { get; set; }
        public virtual DbSet<CrudUserType> CrudUserTypes { get; set; }
        public virtual DbSet<Duplicate> Duplicates { get; set; }
        public virtual DbSet<EmailLog> EmailLogs { get; set; }
        public virtual DbSet<FacebookProvider> FacebookProviders { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<GlobalParameter> GlobalParameters { get; set; }
        public virtual DbSet<GoogleProvider> GoogleProviders { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<MonthlyCheckList> MonthlyCheckLists { get; set; }
        public virtual DbSet<MonthlyCheckupList> MonthlyCheckupLists { get; set; }
        public virtual DbSet<MonthsList> MonthsLists { get; set; }
        public virtual DbSet<NotificationLog> NotificationLogs { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<NotificationType> NotificationTypes { get; set; }
        public virtual DbSet<PeriodType> PeriodTypes { get; set; }
        public virtual DbSet<PregnantDetail> PregnantDetails { get; set; }
        public virtual DbSet<ProActiveInformation> ProActiveInformations { get; set; }
        public virtual DbSet<ProActiveInformationContent> ProActiveInformationContents { get; set; }
        public virtual DbSet<ProActiveType> ProActiveTypes { get; set; }
        public virtual DbSet<RealTimeLeadingQuestion> RealTimeLeadingQuestions { get; set; }
        public virtual DbSet<RealTimeLeadingQuestionContent> RealTimeLeadingQuestionContents { get; set; }
        public virtual DbSet<RealTimeSolution> RealTimeSolutions { get; set; }
        public virtual DbSet<RealTimeSolutionContent> RealTimeSolutionContents { get; set; }
        public virtual DbSet<RealTimeSymptom> RealTimeSymptoms { get; set; }
        public virtual DbSet<RealTimeSymptomsCongratulation> RealTimeSymptomsCongratulations { get; set; }
        public virtual DbSet<RealTimeSymptomsContent> RealTimeSymptomsContents { get; set; }
        public virtual DbSet<RefreshToken> RefreshTokens { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Subscribe> Subscribes { get; set; }
        public virtual DbSet<SystemMessage> SystemMessages { get; set; }
        public virtual DbSet<SystemMessagesType> SystemMessagesTypes { get; set; }
        public virtual DbSet<TaskCategory> TaskCategories { get; set; }
        public virtual DbSet<Timezone> Timezones { get; set; }
        public virtual DbSet<UserDevice> UserDevices { get; set; }
        public virtual DbSet<UserEmailActivation> UserEmailActivations { get; set; }
        public virtual DbSet<User> Users { get; set; }
    
        public virtual ObjectResult<Nullable<int>> IsVersionValid(string sourceType, string currentVersion)
        {
            var sourceTypeParameter = sourceType != null ?
                new ObjectParameter("SourceType", sourceType) :
                new ObjectParameter("SourceType", typeof(string));
    
            var currentVersionParameter = currentVersion != null ?
                new ObjectParameter("CurrentVersion", currentVersion) :
                new ObjectParameter("CurrentVersion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("IsVersionValid", sourceTypeParameter, currentVersionParameter);
        }
    }
}