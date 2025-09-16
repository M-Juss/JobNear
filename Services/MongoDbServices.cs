using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Windows.Forms;

namespace JobNear.Services
{
    public class MongoDbServices
    {
        private readonly IMongoClient _client;
        private readonly string _databaseName;

        public MongoDbServices(string connectionString, string databaseName) {
            _client = new MongoClient(connectionString);
            _databaseName = databaseName;
        }

        public IMongoDatabase GetDatabase() { 
            return _client.GetDatabase(_databaseName);
        }


        public IMongoCollection<BsonDocument> GetCollection(string collectionName) { 
            var database = GetDatabase();
            return database.GetCollection<BsonDocument>(collectionName);
        }

        public async Task CheckConnectionAsync() { 
            Console.WriteLine("Checking MongoDB connection...");
            var databases = await _client.ListDatabaseNamesAsync();
            Console.WriteLine("Connection succesfull!");
            await databases.ForEachAsync(db => Console.WriteLine($"- {db}"));
        }

        public async Task InsertSampleDocumentAsync(string collectionName) { 
            var collection = GetCollection(collectionName);
            var document = new BsonDocument
            {
                {"name", "Mark Justin"},
                { "createdAt", DateTime.UtcNow}
            };

            await collection.InsertOneAsync(document);
        }

        public async Task FindAndPrintSampleDocumentAsync(string collectionName)
        {
            var collection = GetCollection(collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq("name", "Mark Justin");
            var foundDocument = await collection.Find(filter).FirstOrDefaultAsync();

            if (foundDocument != null)
            {
                MessageBox.Show($"Found document: {foundDocument}");
            }
            else
            {
                MessageBox.Show("Document not found.");

            }
        }
    }
}
