using Avanade.SubTCSE.Projeto.Domain.Base.Repository.MongoDB;
using MongoDB.Driver;

namespace Avanade.SubTCSE.Projeto.Data.Repository.Base.MongoDB
{
    public class MongoDBContext : IMongoDBContext
    {
        public IMongoCollection<TEntity> GetCollection<TEntity>(string Collection)
        {
            throw new System.NotImplementedException();
        }
    }
}
