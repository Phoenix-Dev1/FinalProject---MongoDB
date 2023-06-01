using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    [Serializable]

    public class RoomTypes
    {


        // TypeId will be the coding name, and it will be mapped to the PK _id of the table
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string TypeId { get; set; }


        //represent the room type ID
        [BsonElement("room_type_id"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int RoomTypeId { get; set; }


        //represent the description of the room type
        [BsonElement("type_description"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string TypeDescription { get; set; }


        //CTOR
        public RoomTypes(int roomTypeId, string typeDescription)
        {
            this.RoomTypeId = roomTypeId;
            this.TypeDescription = typeDescription;
   
        }


        public override string ToString()
        {
            string str = "";

            str += "Room Type ID: " + this.RoomTypeId.ToString() +
                "\nRoom Type Description: " + this.TypeDescription;

            return str;
        }

    }
}
