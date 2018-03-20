using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace TimeSheet.Utilities
{
    public class GenericRepository<T> where T : class
    {
        #region Memeber Variables
        protected GenericContext databaseContext;
        protected DbSet<T> databaseSet;
        #endregion

        #region Constructors
        public GenericRepository(GenericContext dbContext)
        {
            this.databaseContext = dbContext;
            this.databaseSet = dbContext.Set<T>();
        }
        #endregion

        #region CRUD Methods
        public T create(T genericObject)
        {
            try
            {
                databaseSet.Add(genericObject);
                databaseContext.SaveChanges();
                return genericObject;
            }
            catch (Exception exception)
            {
                throw;
            }
        }

        public T update(object id, T genericObject)
        {
            try
            {
                databaseSet.Attach(genericObject);
                databaseContext.SaveChanges();
                return genericObject;
            }
            catch (Exception exception)
            {
                throw;
            }
        }

        public void delete(T genericObject)
        {
            try
            {
                databaseSet.Remove(genericObject);
                databaseContext.SaveChanges();
            }
            catch (Exception exception)
            {
                throw;
            }
        }
        #endregion
    }
}
