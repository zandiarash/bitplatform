﻿using Foundation.DataAccess.Contracts;
using Foundation.Model.Contracts;
using System;

namespace Bit.Data.EntityFramework.Implementations
{
    public class EfEntityWithDefaultGuidKeyRepository<TEntity> : EfEntityWithDefaultKeyRepository<TEntity, Guid>, IEntityWithDefaultGuidKeyRepository<TEntity>
        where TEntity : class, IEntityWithDefaultGuidKey
    {
        protected EfEntityWithDefaultGuidKeyRepository()
            : base()
        {
        }

        protected EfEntityWithDefaultGuidKeyRepository(DefaultDbContext dbContext)
            : base(dbContext)
        {
        }

        public override Guid GetNewKey()
        {
            return Guid.NewGuid();
        }
    }
}
