using Data.Context;
using Data.Repositories.Generic;
using Domain.Entities;
using Domain.Interfaces;

namespace Data.Repositories;

public class AccessRepository(ApplicationContext context) :Repository<AccessEntity>(context),IAccessRepository
{
}