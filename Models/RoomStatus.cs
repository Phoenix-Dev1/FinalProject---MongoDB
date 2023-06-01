using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class RoomStatus
    {

        // StatusId will be the coding name, and it will be mapped to the PK _id of the table
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string StatusId { get; set; }


        //represent the room status ID
        [BsonElement("room_status_id"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int RoomStatusId { get; set; }


        //represent the description of the room status
        [BsonElement("status_description"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string StatusDescription { get; set; }


        //CTOR
        public RoomStatus(int roomStatusId, string statusDescription)
        {
            this.RoomStatusId = roomStatusId;
            this.StatusDescription = statusDescription;

        }


        public override string ToString()
        {
            string str = "";

            str += "Room Status ID: " + this.RoomStatusId.ToString() +
                "\nRoom Status Description: " + this.StatusDescription;

            return str;
        }
    }
}
