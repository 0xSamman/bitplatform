﻿using Bit.Data.EntityFramework.Implementations;
using Foundation.Model.Contracts;

namespace BitChangeSetManager.DataAccess
{
    public class BitChangeSetManagerEfRepository<TEntity> : EfEntityWithDefaultGuidKeyRepository<TEntity>, IBitChangeSetManagerRepository<TEntity>
        where TEntity : class, IEntityWithDefaultGuidKey
    {
        public BitChangeSetManagerEfRepository(BitChangeSetManagerDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}