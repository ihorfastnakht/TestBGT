
using Windows.ApplicationModel.Background;

namespace TestBGT
{
    public class TaskObject
    {
        public IBackgroundTaskRegistration Task { get; set; }
        public bool IsRegistered { get; set; }
    }
}
