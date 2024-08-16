using MongoDB.Driver;

namespace MongoDBMVC.Models
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _mongoDb;
        public MongoDbContext()
        {
            var client = new MongoClient("mongodb+srv://MABRIO:Toco2273@cluster0.ne2gv.mongodb.net/");
            _mongoDb = client.GetDatabase("SarathDB");
        }
        public IMongoCollection<Employee> Employee
        {
            get
            {
                return _mongoDb.GetCollection<Employee>("Employee");
            }
        }
    }
}