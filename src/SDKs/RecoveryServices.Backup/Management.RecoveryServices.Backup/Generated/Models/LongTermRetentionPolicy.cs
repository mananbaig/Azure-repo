// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.Backup;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Long term retention policy.
    /// </summary>
    public partial class LongTermRetentionPolicy : RetentionPolicy
    {
        /// <summary>
        /// Initializes a new instance of the LongTermRetentionPolicy class.
        /// </summary>
        public LongTermRetentionPolicy()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LongTermRetentionPolicy class.
        /// </summary>
        /// <param name="dailySchedule">Daily retention schedule of the
        /// protection policy.</param>
        /// <param name="weeklySchedule">Weekly retention schedule of the
        /// protection policy.</param>
        /// <param name="monthlySchedule">Monthly retention schedule of the
        /// protection policy.</param>
        /// <param name="yearlySchedule">Yearly retention schedule of the
        /// protection policy.</param>
        public LongTermRetentionPolicy(DailyRetentionSchedule dailySchedule = default(DailyRetentionSchedule), WeeklyRetentionSchedule weeklySchedule = default(WeeklyRetentionSchedule), MonthlyRetentionSchedule monthlySchedule = default(MonthlyRetentionSchedule), YearlyRetentionSchedule yearlySchedule = default(YearlyRetentionSchedule))
        {
            DailySchedule = dailySchedule;
            WeeklySchedule = weeklySchedule;
            MonthlySchedule = monthlySchedule;
            YearlySchedule = yearlySchedule;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets daily retention schedule of the protection policy.
        /// </summary>
        [JsonProperty(PropertyName = "dailySchedule")]
        public DailyRetentionSchedule DailySchedule { get; set; }

        /// <summary>
        /// Gets or sets weekly retention schedule of the protection policy.
        /// </summary>
        [JsonProperty(PropertyName = "weeklySchedule")]
        public WeeklyRetentionSchedule WeeklySchedule { get; set; }

        /// <summary>
        /// Gets or sets monthly retention schedule of the protection policy.
        /// </summary>
        [JsonProperty(PropertyName = "monthlySchedule")]
        public MonthlyRetentionSchedule MonthlySchedule { get; set; }

        /// <summary>
        /// Gets or sets yearly retention schedule of the protection policy.
        /// </summary>
        [JsonProperty(PropertyName = "yearlySchedule")]
        public YearlyRetentionSchedule YearlySchedule { get; set; }

    }
}
