using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace FinalProject.Models
{
    [Serializable]
    public class Orders
    {
        // OrderId will be the coding name, and it will be mapped to the PK _id of the table
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string OrderId { get; set; }

        // Represent the Orders List
        [BsonElement("roomsList"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public List<string> RoomsList { get; set; }

        // Represent the Guest Id
        [BsonElement("guestId"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string GuestId { get; set; }

        // Constructor
        public Orders(string guestId, List<string> roomsList)
        {
            GuestId = guestId;
            RoomsList = roomsList;
        }

        // AddRange - להוסיף את החדרים לרשימה חדשה
    }
}
