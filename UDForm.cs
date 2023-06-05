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
    public partial class UDForm : Form
    {
        // Define a mongo collection of rooms 
        IMongoCollection<RoomManagement> roomsManagementCollection;


        public UDForm(MongoDB.Driver.IMongoCollection<RoomManagement> rooms)
        {
            InitializeComponent();
            this.roomsManagementCollection = rooms;
        }

        // Function to Delete a Room
        private void btn_UD_Delete_Click(object sender, EventArgs e)
        {
            int roomNo =Convert.ToInt32( textBox_UD_Room_No.Text);

            // Using the DeleteOne command according to the Room Number
            try
            {
                // Get the Collection 
                // the collection is called "rooms" - in the first time it will create it
                FilterDefinition<RoomManagement> filter = Builders<RoomManagement>.Filter.Eq(room => room.RoomNumber, roomNo);
                DeleteResult deleteResult = roomsManagementCollection.DeleteOne(filter);

                // Check if we managed to delete the requested Room Number
                if (deleteResult != null && deleteResult.DeletedCount == 1)
                {
                    MessageBox.Show("Room Number :" + roomNo + " Successfuly deleted!\n\nPress OK to close this window",
                        "Item Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Room Number :" + roomNo + " Failed to be deleted\n\nPress OK to close this window",
                       "Item Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Room Number :" + roomNo + " Failed to be deleted, we got the following exception: \n\n" + ex.Message + "\n\nPress OK to close this window",
                       "Item Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        // Function to Update a Room

        private void btn_UD_Update_Click(object sender, EventArgs e)
        {
            // Using the UpdateOne command according to the MongoID
            // Retrieve the room details
            
            int roomNo = Convert.ToInt32(textBox_UD_Room_No.Text);
            int roomFloor = Convert.ToInt32(textBox_UD_Room_Floor.Text);
            int roomType = Convert.ToInt32(comboBox_UD_Room_Type.SelectedItem);
            int roomStatus = Convert.ToInt32(comboBox_UD_Room_Status.SelectedItem);
            double roomPrice = Convert.ToDouble(textBox_UD_Room_Price.Text);

            // Create a filter to find the product with the given ID
            FilterDefinition<RoomManagement> filter = Builders<RoomManagement>.Filter.Eq(room => room.RoomNumber, roomNo);


            // Create an update definition to update the product's fields
            UpdateDefinition<RoomManagement> updateDefinition = Builders<RoomManagement>.Update
                .Set(room => room.RoomNumber, roomNo)
                .Set(room => room.RoomFloor, roomFloor)
                .Set(room => room.RoomType, roomType)
                .Set(room => room.RoomStatus, roomStatus)
                .Set(room => room.RoomPrice, roomPrice);

            try
            {
                // Use the UpdateOne method to update the product in the database
                UpdateResult updateResult = roomsManagementCollection.UpdateOne(filter, updateDefinition);

                if (updateResult != null && updateResult.ModifiedCount == 1)
                {
                    MessageBox.Show("Room Number:" + roomNo + " Successfuly updated!\n\nPress OK to close this window",
                    "Item Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Room Number" + roomNo + " Failed to be updated\n\nPress OK to close this window",
                       "Item Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

