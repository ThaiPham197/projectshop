﻿namespace Shop.Data.Infrastructure
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private ShopDbContext dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public ShopDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}