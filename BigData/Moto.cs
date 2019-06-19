using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigData
{
    public class Moto
    {
        public ObjectId Id { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
