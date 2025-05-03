using Data.Context;
using Data.Repositories.Generic;
using Domain.Entities;
using Domain.Interfaces;

namespace Data.Repositories;

public class WebhookRepository(ApplicationContext context) :Repository<WebhookEntity>(context),IWebhookRepository
{
}