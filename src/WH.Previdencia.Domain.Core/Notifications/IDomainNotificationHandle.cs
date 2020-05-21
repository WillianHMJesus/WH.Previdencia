using FluentValidation.Results;
using System.Collections.Generic;

namespace WH.Previdencia.Domain.Core.Notifications
{
    public interface IDomainNotificationHandle
    {
        List<DomainNotification> GetNotifications();
        void HandleNotification(string key, string value);
        void HandleNotification(DomainNotification notification);
        void HandleNotification(ValidationResult validationResult);
        bool HasNotification();
    }
}
