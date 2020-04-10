using System;
using System.Collections.Generic;
using System.Linq;

namespace WH.Previdencia.Domain.Core.Notifications
{
    public class DomainNotificationHandle : IDomainNotificationHandle, IDisposable
    {
        private List<DomainNotification> _notifications;

        public List<DomainNotification> GetNotifications()
        {
            return _notifications;
        }

        public void HandleNotification(string key, string value)
        {
            _notifications.Add(new DomainNotification(key, value));
        }

        public bool HasNotification()
        {
            return _notifications.Any();
        }

        public void Dispose()
        {
            _notifications = new List<DomainNotification>();
        }
    }
}
