using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace BigData
{
    public class Database
    {
        public IMongoDatabase database;
        public IMongoCollection<News> collectionNews;
        public IMongoCollection<Moto> collectionMoto;
        public void ConnectDB()
        {
            var client = new MongoClient(
                "mongodb://admin:admin@ds119258.mlab.com:19258/kidentertainment"
            );

            database = client.GetDatabase("kidentertainment");

            collectionNews = database.GetCollection<News>("news");
            collectionMoto = database.GetCollection<Moto>("motos");
        }

        public List<News> GetNews(string title)
        {
            

            if(string.IsNullOrEmpty(title))
                return collectionNews.Find(x => x.Title.Contains("")).ToList();

            return collectionNews.Find(x => x.Title.Contains(title)).ToList();
        }

        public List<News> SortNews(string type)
        {
            if (string.IsNullOrEmpty(type) || type.Equals("asc"))
                return collectionNews.Find(x => x.Title.Contains("")).SortBy(x => x.Title).ToList();

            return collectionNews.Find(x => x.Title.Contains("")).SortByDescending(x => x.Title).ToList();
        }

        public List<Moto> GetMotos(string title)
        {
            if (string.IsNullOrEmpty(title))
                return collectionMoto.Find(x => x.Title.Contains("")).ToList();

            return collectionMoto.Find(x => x.Title.Contains(title)).ToList();
        }

        public List<Moto> SortPriceMotos(string type)
        {
            if (string.IsNullOrEmpty(type) || type.Equals("asc"))
                return collectionMoto.Find(x => x.Title.Contains("")).SortBy(x => x.Price).ToList();

            return collectionMoto.Find(x => x.Title.Contains("")).SortByDescending(x => x.Price).ToList();
        }

        public async Task DeleteAllNews()
        {
            await collectionNews.DeleteManyAsync(x => x.Title.Contains(""));
        }

        public async Task DeleteAllMotos()
        {
            await collectionMoto.DeleteManyAsync(x => x.Title.Contains(""));
        }

        public async Task InsertNews(List<News> news)
        {
            await collectionNews.InsertManyAsync(news);
        }

        public async Task InsertMoto(List<Moto> moto)
        {
            await collectionMoto.InsertManyAsync(moto);
        }
    }
}
