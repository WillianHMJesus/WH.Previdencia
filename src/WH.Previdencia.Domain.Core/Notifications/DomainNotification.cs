using System;

namespace WH.Previdencia.Domain.Core.Notifications
{
    public class DomainNotification
    {
        public Guid DomainNotificationId { get; private set; }
        public string Key { get; private set; }
        public string Value { get; private set; }

        public DomainNotification(string key, string value)
        {
            DomainNotificationId = Guid.NewGuid();
            Key = key;
            Value = value;
        }
    }
}
