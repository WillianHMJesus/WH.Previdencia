using FluentValidation.Results;
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

        public void HandleNotification(DomainNotification notification)
        {
            _notifications.Add(notification);
        }

        public void HandleNotification(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                HandleNotification(error.ErrorCode, error.ErrorMessage);
            }
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
