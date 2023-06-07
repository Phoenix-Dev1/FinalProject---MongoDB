using System;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.Models;

namespace FinalProject
{
    public partial class GUForm : Form
    {

        // Define a mongo collection of guests
        IMongoCollection<Guests> guestsManagementCollection;
        public GUForm(MongoDB.Driver.IMongoCollection<Guests> guests)
        {
            InitializeComponent();
            this.guestsManagementCollection = guests;
        }

        // Function to Delete Guest
        private void btn_GU_Delete_Click(object sender, EventArgs e)
        {
            int guestNo = Convert.ToInt32(textBox_GU_Guest_No.Text);

            // Using the DeleteOne command according to the Guest unique Number
            try
            {
                // Get the Collection 
                // the collection is called "guests" - in the first time it will create it
                FilterDefinition<Guests> filter = Builders<Guests>.Filter.Eq(guest => guest.GuestNumber, guestNo);
                DeleteResult deleteResult = guestsManagementCollection.DeleteOne(filter);

                // Check if we managed to delete the requested Guest Number
                if (deleteResult != null && deleteResult.DeletedCount == 1)
                {
                    MessageBox.Show("Guest Number :" + guestNo + " Successfuly deleted!\n\nPress OK to close this window",
                        "Guest Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Guest Number :" + guestNo + " Failed to be deleted\n\nPress OK to close this window",
                       "Guest Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Guest Number :" + guestNo + " Failed to be deleted, we got the following exception: \n\n" + ex.Message + "\n\nPress OK to close this window",
                       "Guest Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }



        // Function to Update Guest
        private void btn_GU_Update_Click(object sender, EventArgs e)
        {
            // Using the UpdateOne command according to the MongoID
            // Retrieve the Guest details

            int guestNo = Convert.ToInt32(textBox_GU_Guest_No.Text);
            string firstName = textBox_GU_First_Name.Text;
            string lastName = textBox_GU_Last_Name.Text;
            string phone = textBox_GU_Phone.Text;
            int persons = Convert.ToInt32(textBox_GU_Persons.Text);
            int numberOfRooms = Convert.ToInt32(textBox_GU_number_of_rooms);
            string checkIn = dateTimePicker_GU_CheckIn.Value.ToString("dd-MM-yyyy");
            string checkOut = dateTimePicker_GU_CheckOut.Value.ToString("dd-MM-yyyy");

            // Create a filter to find the guest with the given ID
            FilterDefinition<Guests> filter = Builders<Guests>.Filter.Eq(guest => guest.GuestNumber, guestNo);


            // Create an update definition to update the guests fields
            UpdateDefinition<Guests> updateDefinition = Builders<Guests>.Update
                .Set(guest => guest.GuestNumber, guestNo)
                .Set(guest => guest.FirstName, firstName)
                .Set(guest => guest.LastName, lastName)
                .Set(guest => guest.PhoneNumber, phone)
                .Set(guest => guest.Persons, persons)
                .Set(guest => guest.NumberOfRooms, numberOfRooms)
                .Set(guest => guest.CheckInDate, checkIn)
                .Set(guest => guest.CheckOutDate, checkOut); 

            try
            {
                // Use the UpdateOne method to update the guest in the database
                UpdateResult updateResult = guestsManagementCollection.UpdateOne(filter, updateDefinition);

                if (updateResult != null && updateResult.ModifiedCount == 1)
                {
                    MessageBox.Show("Guest Number:" + guestNo + " Successfuly updated!\n\nPress OK to close this window",
                    "Guest Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Guest Number" + guestNo + " Failed to be updated\n\nPress OK to close this window",
                       "Guest Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                // Display an error message to the user if an exception occurs
                MessageBox.Show("The following error occurred:\n" + ex.Message + "\n\nPress OK to close this window",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            // Close the form
            this.Close();
        }
    }
}
