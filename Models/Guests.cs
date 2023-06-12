using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    [Serializable]

    public class Guests
    {
        // RoomId will be the coding name, and it will be mapped to the PK _id of the table
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string GuestId { get; set; }


        //represent the Guests's number
        [BsonElement("guest_number"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int GuestNumber { get; set; }


        //represent the Guests's first name
        [BsonElement("first_name"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string FirstName { get; set; }


        //represent the Guests's last name
        [BsonElement("last_name"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string LastName { get; set; }

        //represent the Guests's phone number
        [BsonElement("phone_number"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string PhoneNumber { get; set; }

        //represent the Guests's room type(FK)
        [BsonElement("guest_room_type"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int GuestRoomType { get; set; }

        //represent the Guests's room number
        [BsonElement("guest_room_number"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int GuestRoomNumber { get; set; }

        //represent how many guests are staying in the room
        [BsonElement("persons"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int Persons { get; set; }

        //represent how many guests are staying in the room
        [BsonElement("number_of_rooms"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int NumberOfRooms { get; set; }

        //represent the Guests's check in date
        [BsonElement("check_in_date"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string CheckInDate { get; set; }

        //represent the Guests's check out date
        [BsonElement("check_out_date"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string CheckOutDate { get; set; }



        /* Not used currently
        //CTOR
        public Guests(int guestNumber, string firstName, string lastName, string phoneNumber, int guestRoomType, 
            int guestRoomNumber, int persons, string checkInDate, string checkOutDate)
        {
            this.GuestNumber = guestNumber;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.GuestRoomType = guestRoomType;
            this.GuestRoomNumber = guestRoomNumber;
            this.Persons = persons;
            this.CheckInDate = checkInDate;
            this.CheckOutDate = checkOutDate;

        }

        */

        // User screen constructor
        public Guests(int guestNumber, string firstName, string lastName, string phoneNumber,int numberOfRooms, int persons, string checkInDate, string checkOutDate) {

            this.GuestNumber = guestNumber;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.Persons = persons;
            this.NumberOfRooms = numberOfRooms;
            this.CheckInDate = checkInDate;
            this.CheckOutDate = checkOutDate;
        }


        public override string ToString()
        {
            string str = "";

            str += "Guest's Unique ID Number: " + this.GuestNumber.ToString() +
                "\nGuest Full Name: " + this.FirstName + " " + this.LastName +
                "\nGuest Phone Number: " + this.PhoneNumber +
                "\nNumber of persons Booked in the room: " + this.Persons.ToString()+
                "\nCheck-in Date: " + this.CheckInDate.ToString() + " Check-out Date: " + this.CheckOutDate.ToString();
            return str;
        }

    }

}
