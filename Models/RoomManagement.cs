using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    [Serializable]

    public class RoomManagement
    {
        // RoomId will be the coding name, and it will be mapped to the PK _id of the table
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string RoomId { get; set; }


        //represent the number of the room floor
        [BsonElement("floor"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int RoomFloor { get; set; }


        //represent the number of the room 
        [BsonElement("room_number"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int RoomNumber { get; set; }


        //represent the type of the room(FK) 
        [BsonElement("room_type"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int RoomType { get; set; }


        //represent the vacancy status of the room(FK)
        [BsonElement("status"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int RoomStatus { get; set; }


        //represent the price of the chosen room 
        [BsonElement("price"), BsonRepresentation(MongoDB.Bson.BsonType.Double)]
        public double RoomPrice { get; set; }


        //CTOR
        public RoomManagement(int roomFloor, int roomNumber, int roomType, int roomStatus, double roomPrice)
        {
            this.RoomFloor = roomFloor;
            this.RoomNumber = roomNumber;
            this.RoomType = roomType;
            this.RoomStatus = roomStatus;
            this.RoomPrice = roomPrice;
        }


        public override string ToString()
        {
            string str = "";

            str += "Room floor: " + this.RoomFloor.ToString() +
                "\nRoom Number: " + this.RoomNumber.ToString() +
                "\nRoom Type: " + this.RoomType.ToString() +
                "\nRoom Status: " + this.RoomStatus.ToString() +
                "\nRoom Price: " + this.RoomPrice.ToString();
            return str;
        }

    }

}
