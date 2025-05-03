using Domain.Entities;
using Domain.Interfaces.Generic;

namespace Domain.Interfaces;

public interface IWebhookRepository:IRepository<WebhookEntity>
{
}