using System;

namespace WpfApp.Core
{
    public static class EventBroker
    {
        public static event Action<string> ChangeNamePageEvent;

        public static void OnChangeNamePageEvent(string obj)
        {
            ChangeNamePageEvent?.Invoke(obj);
        }
    }
}