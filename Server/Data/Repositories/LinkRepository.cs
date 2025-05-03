using Data.Context;
using Data.Repositories.Generic;
using Domain.Entities;
using Domain.Interfaces;

namespace Data.Repositories;

public class LinkRepository(ApplicationContext context) :Repository<LinkEntity>(context),ILinkRepository
{
}