using System.Collections.Generic;

namespace WH.Previdencia.Domain.Core.Notifications
{
    public interface IDomainNotificationHandle
    {
        List<DomainNotification> GetNotifications();
        void HandleNotification(string key, string value);
        bool HasNotification();
    }
}
