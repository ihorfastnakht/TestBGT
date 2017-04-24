using Microsoft.Toolkit.Uwp;
using Windows.ApplicationModel.Background;

namespace TestBGT
{
    public static class BackgroundTaskWrapper
    {
        public static void RegisterTasks()
        {
            var taskName = nameof(TimeBackgroundTask);
            var trigger = new TimeTrigger(15, false);
            var condition = new SystemCondition(SystemConditionType.InternetAvailable);

            BackgroundTaskHelper.Register(taskName, trigger, true, conditions: condition);
        }
    }
}
