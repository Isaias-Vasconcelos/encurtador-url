using Data.Context;
using Data.Repositories.Generic;
using Domain.Entities;
using Domain.Interfaces;

namespace Data.Repositories;

public class UserRepository(ApplicationContext context) :Repository<UserEntity>(context),IUserRepository
{
}