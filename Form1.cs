﻿using System;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.Models;
using System.Globalization;

namespace FinalProject
{

    public partial class Form1 : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyMongo"].ConnectionString;
        private IMongoCollection<RoomManagement> roomsManagementCollection;
        private IMongoCollection<Guests> GuestsCollection;
        private IMongoCollection<Orders> OrdersCollection;


        public Form1()
        {
            InitializeComponent();
        }

        // Upon loading the program
        private void Form1_Load(object sender, EventArgs e)
        {
            // Get the DB Name(As a string)
            MongoDB.Driver.MongoUrl mongoUrl = MongoUrl.Create(connectionString);
            string dbName = mongoUrl.DatabaseName;

            // Create Mongo Client
            MongoDB.Driver.MongoClient mongoClient;

            try
            {
                // we will work on a database in this manner
                mongoClient = new MongoClient(connectionString);

                // Get the DB OBJECT
                IMongoDatabase db = mongoClient.GetDatabase(dbName);

                // Get the Collection 
                // the collection is called "Rooms" - in the first time it will create it
                roomsManagementCollection = db.GetCollection<RoomManagement>("Rooms");
                GuestsCollection = db.GetCollection<Guests>("Guests");
                OrdersCollection = db.GetCollection<Orders>("Orders");

                // When the form is loaded - we would like to get the list of all the tables
                // Rooms
                LoadRoomsUponScreen();
                // Guests
                LoadGuestsUponScreen();
                // Orders
                // LoadOrdersUponScreen();

            }
            catch (Exception ex)
            {
                mongoClient = null;
                MessageBox.Show("The following error occured:\n" + ex.Message,
                    "Siesta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Load all the rooms upon the user's screen
        private void LoadRoomsUponScreen()
        {
            // To hide _id by Mongo
            var results = roomsManagementCollection.Find(_ => true)
                .Project(r => new
                {
                    r.RoomFloor,
                    r.RoomNumber,
                    r.RoomType,
                    r.RoomStatus,
                    r.RoomPrice
                })
                .ToList();

            // Add the checkbox column only if it doesn't already exist
            if (!dataGridView_rooms.Columns.Contains("checkboxColumn"))
            {
                var checkboxColumn = new DataGridViewCheckBoxColumn
                {
                    HeaderText = "Select",
                    Name = "checkboxColumn",
                    DataPropertyName = "IsSelected"
                };
                dataGridView_rooms.Columns.Insert(0, checkboxColumn);
            }

            // Clear the text box values
            comboBox_Filter_Room_Floor.SelectedItem = null;
            comboBox_Filter_By_Type.SelectedItem = null;
            comboBox_Filter_By_Status.SelectedItem = null;
            textBox_Filert_By_Price.Clear();

            // Enable checkbox editing
            dataGridView_rooms.ReadOnly = false;
            dataGridView_rooms.Columns["checkboxColumn"].ReadOnly = false;


            dataGridView_rooms.DataSource = results;
        }



        // Load all the guests upon the user's screen
        private void LoadGuestsUponScreen()
        {
            // To hide _id by Mongo
            var results = GuestsCollection.Find(_ => true)
                .Project(g => new
                {
                    g.GuestId,
                    g.LastName,
                    g.FirstName,
                    g.PhoneNumber,
                    g.CheckInDate,
                    g.CheckOutDate
                })
                .ToList();

            // Add the checkbox column only if it doesn't already exist
            if (!dataGridView_guests.Columns.Contains("checkboxColumn"))
            {
                var checkboxColumn = new DataGridViewCheckBoxColumn
                {
                    HeaderText = "Select",
                    Name = "checkboxColumn",
                    DataPropertyName = "IsSelected"
            };
                dataGridView_guests.Columns.Insert(0, checkboxColumn);
            }

            // Clear the text box values
            textBox_Guest_id.Clear();
            textBox_first_name.Clear();
            textBox_last_name.Clear();
            textBox_phone.Clear();
            dateTimePicker_check_in.ResetText();
            dateTimePicker_check_out.ResetText();

            // Enable checkbox editing
            dataGridView_rooms.ReadOnly = false;
            dataGridView_rooms.Columns["checkboxColumn"].ReadOnly = false;


            dataGridView_guests.DataSource = results;
        }

        // Refresh the Data grid
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadRoomsUponScreen();
        }

        // Function to Insert a new room to the system
        private void btn_Insert_Room_Click(object sender, EventArgs e)
        {
            // To Do - Stage 1: Get the information from the screen
            FinalProject.Models.RoomManagement room = GetRoomDetailsFromScreen();

            // To Do - Stage2: Insert the data into the Collection(Into the MongoDB)
            try
            {
                if (roomCheck(room.RoomNumber))
                {
                    roomsManagementCollection.InsertOne(room);
                    MessageBox.Show("The Following Room was inserted:\n" + room.ToString(),
                        "Room was inserted",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    // If the insert succeeded - refresh the screen with the new information
                    LoadRoomsUponScreen();
                }
                else
                {
                    MessageBox.Show("This Room already exists, please choose a diferent Room number or " +
                        "a diferent floor\n", "siesta",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                    comboBox_Room_No.SelectedItem = null;
                    comboBox_Room_Floors.SelectedItem = null;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("The following error occured:\n" + ex.Message,
                   "Siesta",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            comboBox_Room_No.SelectedItem = null;
            comboBox_Room_Floors.SelectedItem = null;
            comboBox_Room_Type.SelectedItem = null;
            comboBox_Room_Status.SelectedItem = null;
            textBox_Room_Price.Clear();
        }


        // Function to Insert a new guest to the system
        private void btn_insert_guests_table_Click(object sender, EventArgs e)
        {
            // To Do - Stage 1: Get the information from the screen
            FinalProject.Models.Guests guest = GetGuestDetailsFromScreen();

            // To Do - Stage2: Insert the data into the Collection(Into the MongoDB)
            try
            {
                if (phoneNumberCheck(guest.PhoneNumber) && (CheckFirstAndLastNameValidity(guest.FirstName, guest.LastName))&&checkId(guest.GuestId))
                {
                    GuestsCollection.InsertOne(guest);
                    MessageBox.Show("The Following Guest was inserted:\n" + guest.ToString(),
                        "Guest was inserted",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    // If the insert succeeded - refresh the screen with the new information
                    LoadGuestsUponScreen();

                    textBox_first_name.Clear();
                    textBox_last_name.Clear();
                    textBox_phone.Clear();
                }
                else
                {
                    if (!phoneNumberCheck(guest.PhoneNumber))
                    {
                        MessageBox.Show("Phone number is incorrect , Please try again\n",
                    "Siesta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                        textBox_phone.Clear();
                    }

                    if (!CheckFirstAndLastNameValidity(guest.FirstName, guest.LastName))
                    {
                        MessageBox.Show("Guest name is incorrect , Please try again\n",
                    "Siesta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                        textBox_first_name.Clear();
                        textBox_last_name.Clear();
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("The following error occured:\n" + ex.Message,
                   "Siesta",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }


        }


        // Function to get room details from screen
        private RoomManagement GetRoomDetailsFromScreen()
        {
            int roomNo = Convert.ToInt32(comboBox_Room_No.SelectedItem);
            int roomFloor = Convert.ToInt32(comboBox_Room_Floors.SelectedItem);
            int roomType = Convert.ToInt32(comboBox_Room_Type.SelectedItem);
            int roomStatus = Convert.ToInt32(comboBox_Room_Status.SelectedItem);
            double roomPrice = Convert.ToDouble(textBox_Room_Price.Text);

            roomNo = roomFloor * 100 + roomNo;

            RoomManagement room = new RoomManagement(roomFloor, roomNo, roomType, roomStatus, roomPrice);

            return room;
        }

        // Function to get guest details from screen
        private Guests GetGuestDetailsFromScreen()
        {
            // Get the maximum guest number from Guests collection
            //int maxGuestNumber = GuestsCollection.Find(_ => true).SortByDescending(g => g.GuestId).Limit(1).FirstOrDefault()?.GuestId ?? 0;
            string guestId = textBox_Guest_id.Text;
            string firstName = textBox_first_name.Text;
            string lastName = textBox_last_name.Text;
            string phone = textBox_phone.Text;
            string checkInDate = dateTimePicker_check_in.Value.ToString("dd-MM-yyyy");
            string checkOutDate = dateTimePicker_check_out.Value.ToString("dd-MM-yyyy");

            Guests guest = new Guests(guestId, firstName, lastName, phone, checkInDate, checkOutDate);

            return guest;
        }

        // Filter by floor
        private void btn_Filter_By_Floor_Click(object sender, EventArgs e)
        {
            // Stage 1: Take the data out of the screen
            int floorToFilter = Convert.ToInt32(comboBox_Filter_Room_Floor.SelectedItem);

            // Stage 2: Build the filter
            FilterDefinition<RoomManagement> filter = Builders<RoomManagement>.Filter.Eq(r => r.RoomFloor, floorToFilter);

            // Stage 3: Perform the filter
            List<RoomManagement> results = roomsManagementCollection.Aggregate().Match(filter).ToList();

            // Show in Data Grid
            dataGridView.DataSource = results;

            comboBox_Filter_Room_Floor.SelectedItem = null;
        }

        // Filter by type
        private void btn_Filter_By_Type_Click(object sender, EventArgs e)
        {
            // Stage 1: Take the data out of the screen
            int typeToFilter = Convert.ToInt32(comboBox_Filter_By_Type.SelectedItem);

            // Stage 2: Build the filter
            FilterDefinition<RoomManagement> filter = Builders<RoomManagement>.Filter.Eq(r => r.RoomType, typeToFilter);

            // Stage 3: Perform the filter
            List<RoomManagement> results = roomsManagementCollection.Aggregate().Match(filter).ToList();

            // Show in Data Grid
            dataGridView.DataSource = results;

            comboBox_Filter_By_Type.SelectedItem = null;
        }

        // Filter by status
        private void btn_Filter_By_Status_Click(object sender, EventArgs e)
        {
            // Stage 1: Take the data out of the screen
            int statusToFilter = Convert.ToInt32(comboBox_Filter_By_Status.SelectedItem);

            // Stage 2: Build the filter
            FilterDefinition<RoomManagement> filter = Builders<RoomManagement>.Filter.Eq(r => r.RoomStatus, statusToFilter);

            // Stage 3: Perform the filter
            List<RoomManagement> results = roomsManagementCollection.Aggregate().Match(filter).ToList();

            // Show in Data Grid
            dataGridView.DataSource = results;

            comboBox_Filter_By_Status.SelectedItem = null;
        }

        // Filter by price
        private void btn_Filter_By_Price_Click(object sender, EventArgs e)
        {
            // Stage 1: Take the data out of the screen
            double priceToFilter = Convert.ToDouble(textBox_Filert_By_Price.Text);

            // Stage 2: Build the filter
            FilterDefinition<RoomManagement> filter = Builders<RoomManagement>.Filter.Lte(r => r.RoomPrice, priceToFilter);

            // Stage 3: Perform the filter
            List<RoomManagement> results = roomsManagementCollection.Aggregate().Match(filter).ToList();

            // Show in Data Grid
            dataGridView.DataSource = results;

            textBox_Filert_By_Price.Clear();
        }

        private void btn_Refresh_Rooms_Click(object sender, EventArgs e)
        {
            LoadRoomsUponScreen();
        }

        private void btn_Refresh_Guests_Click_Click(object sender, EventArgs e)
        {
            LoadGuestsUponScreen();
        }

        // Cell double click - open new Winform
        private void dataGridView_guests_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Gets a table
            GUForm guForm = new GUForm(GuestsCollection); // guestsCollection

            guForm.textBox_GU_Guest_Id.Text = dataGridView_guests.CurrentRow.Cells[1].Value.ToString();
            guForm.textBox_GU_First_Name.Text = dataGridView_guests.CurrentRow.Cells[2].Value.ToString();
            guForm.textBox_GU_Last_Name.Text = dataGridView_guests.CurrentRow.Cells[3].Value.ToString();
            guForm.textBox_GU_Phone.Text = dataGridView_guests.CurrentRow.Cells[4].Value.ToString();
            guForm.dateTimePicker_GU_CheckIn.Text = dataGridView_guests.CurrentRow.Cells[5].Value.ToString();
            guForm.dateTimePicker_GU_CheckOut.Text = dataGridView_guests.CurrentRow.Cells[6].Value.ToString();

            // Show the dialog after the fields have been filled
            guForm.ShowDialog(this);

            // To Do - Refresh the screen after we are coming back from the delete/update screen
            LoadGuestsUponScreen();
        }

        // Function for Cell double click window open
        private void dataGridView_rooms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Gets a table
            UDForm udForm = new UDForm(roomsManagementCollection); // roomsCollection


            //udForm.textBox_UD_Mongo_Id.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            udForm.textBox_UD_Room_No.Text = dataGridView_rooms.CurrentRow.Cells[2].Value.ToString();
            udForm.textBox_UD_Room_Floor.Text = dataGridView_rooms.CurrentRow.Cells[1].Value.ToString();
            udForm.comboBox_UD_Room_Type.SelectedItem = dataGridView_rooms.CurrentRow.Cells[3].Value.ToString();
            udForm.comboBox_UD_Room_Status.SelectedItem = dataGridView_rooms.CurrentRow.Cells[4].Value.ToString();
            udForm.textBox_UD_Room_Price.Text = dataGridView_rooms.CurrentRow.Cells[5].Value.ToString();

            // Show the dialog after the fields have been filled
            udForm.ShowDialog(this);

            // To Do - Refresh the screen after we are coming back from the delete/update screen
            LoadRoomsUponScreen();
        }


        // Checkings
        public bool phoneNumberCheck(string phoneNumber)
        {
            if (phoneNumber.Length != 10)
                return false;

            foreach (char c in phoneNumber)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            return true;
        }

        public bool CheckFirstAndLastNameValidity(string firstName, string lastName)
        {
            // Check if the first name or last name is empty
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
                return false;

            // Check if the first name contains only valid characters (a-z/A-Z)
            foreach (char c in firstName)
            {
                if (!char.IsLetter(c))
                    return false;
            }

            // Check if the last name contains only valid characters (a-z/A-Z)
            foreach (char c in lastName)
            {
                if (!char.IsLetter(c))
                    return false;
            }

            return true;
        }


        //function checks if there is no room with the number that inserted
        public bool roomCheck(int room)
        {
            var filter = Builders<RoomManagement>.Filter.Eq(r => r.RoomNumber, room);
            var count = roomsManagementCollection.CountDocuments(filter);

            if (count == 0)
                return true;
            return false;
        }

        private void dataGridView_rooms_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView_rooms.Columns[e.ColumnIndex].Name == "RoomPrice")
            {
                if (e.Value != null)
                {
                    double roomPrice = (double)e.Value;
                    e.Value = roomPrice.ToString() + "$"; 
                    e.FormattingApplied = true;
                }
            }
        }

        public bool checkId(string guestId)
        {
            var filter = Builders<Guests>.Filter.Eq(g => g.GuestId, guestId);
            if (guestId.Length == 9 || filter == null)
                return false;
            return true;
        }

        // Create Order - One to Many
        private void btn_createOrder_Click(object sender, EventArgs e)
        {
           

        }
    }
}