namespace FinalProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_number_of_rooms = new System.Windows.Forms.TextBox();
            this.btn_Refresh_Guests_Click = new System.Windows.Forms.Button();
            this.dateTimePicker_check_out = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_check_in = new System.Windows.Forms.DateTimePicker();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_last_name = new System.Windows.Forms.TextBox();
            this.textBox_first_name = new System.Windows.Forms.TextBox();
            this.dataGridView_guests = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_insert_guests_table = new System.Windows.Forms.Button();
            this.textBox_persons = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Refresh_Rooms = new System.Windows.Forms.Button();
            this.dataGridView_rooms = new System.Windows.Forms.DataGridView();
            this.comboBox_Room_No = new System.Windows.Forms.ComboBox();
            this.comboBox_Room_Floors = new System.Windows.Forms.ComboBox();
            this.btn_Insert_Room = new System.Windows.Forms.Button();
            this.textBox_Room_Price = new System.Windows.Forms.TextBox();
            this.comboBox_Room_Status = new System.Windows.Forms.ComboBox();
            this.comboBox_Room_Type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.comboBox_Filter_Room_Floor = new System.Windows.Forms.ComboBox();
            this.comboBox_Filter_By_Status = new System.Windows.Forms.ComboBox();
            this.comboBox_Filter_By_Type = new System.Windows.Forms.ComboBox();
            this.textBox_Filert_By_Price = new System.Windows.Forms.TextBox();
            this.btn_Filter_By_Price = new System.Windows.Forms.Button();
            this.btn_Filter_By_Status = new System.Windows.Forms.Button();
            this.btn_Filter_By_Type = new System.Windows.Forms.Button();
            this.btn_Filter_By_Floor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_guests)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rooms)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(981, 695);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(973, 669);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hotel Management";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBox_number_of_rooms);
            this.groupBox3.Controls.Add(this.btn_Refresh_Guests_Click);
            this.groupBox3.Controls.Add(this.dateTimePicker_check_out);
            this.groupBox3.Controls.Add(this.dateTimePicker_check_in);
            this.groupBox3.Controls.Add(this.textBox_phone);
            this.groupBox3.Controls.Add(this.textBox_last_name);
            this.groupBox3.Controls.Add(this.textBox_first_name);
            this.groupBox3.Controls.Add(this.dataGridView_guests);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btn_insert_guests_table);
            this.groupBox3.Controls.Add(this.textBox_persons);
            this.groupBox3.Location = new System.Drawing.Point(56, 324);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(864, 299);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Guests";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Rooms:";
            // 
            // textBox_number_of_rooms
            // 
            this.textBox_number_of_rooms.Location = new System.Drawing.Point(97, 134);
            this.textBox_number_of_rooms.MaxLength = 2;
            this.textBox_number_of_rooms.Name = "textBox_number_of_rooms";
            this.textBox_number_of_rooms.Size = new System.Drawing.Size(121, 20);
            this.textBox_number_of_rooms.TabIndex = 36;
            // 
            // btn_Refresh_Guests_Click
            // 
            this.btn_Refresh_Guests_Click.Location = new System.Drawing.Point(618, 56);
            this.btn_Refresh_Guests_Click.Name = "btn_Refresh_Guests_Click";
            this.btn_Refresh_Guests_Click.Size = new System.Drawing.Size(120, 27);
            this.btn_Refresh_Guests_Click.TabIndex = 34;
            this.btn_Refresh_Guests_Click.Text = "Refresh";
            this.btn_Refresh_Guests_Click.UseVisualStyleBackColor = true;
            this.btn_Refresh_Guests_Click.Click += new System.EventHandler(this.btn_Refresh_Guests_Click_Click);
            // 
            // dateTimePicker_check_out
            // 
            this.dateTimePicker_check_out.Location = new System.Drawing.Point(340, 49);
            this.dateTimePicker_check_out.Name = "dateTimePicker_check_out";
            this.dateTimePicker_check_out.Size = new System.Drawing.Size(217, 20);
            this.dateTimePicker_check_out.TabIndex = 33;
            // 
            // dateTimePicker_check_in
            // 
            this.dateTimePicker_check_in.Location = new System.Drawing.Point(340, 23);
            this.dateTimePicker_check_in.Name = "dateTimePicker_check_in";
            this.dateTimePicker_check_in.Size = new System.Drawing.Size(217, 20);
            this.dateTimePicker_check_in.TabIndex = 32;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(97, 77);
            this.textBox_phone.MaxLength = 10;
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(120, 20);
            this.textBox_phone.TabIndex = 31;
            // 
            // textBox_last_name
            // 
            this.textBox_last_name.Location = new System.Drawing.Point(97, 51);
            this.textBox_last_name.MaxLength = 20;
            this.textBox_last_name.Name = "textBox_last_name";
            this.textBox_last_name.Size = new System.Drawing.Size(121, 20);
            this.textBox_last_name.TabIndex = 30;
            // 
            // textBox_first_name
            // 
            this.textBox_first_name.Location = new System.Drawing.Point(97, 22);
            this.textBox_first_name.MaxLength = 20;
            this.textBox_first_name.Name = "textBox_first_name";
            this.textBox_first_name.Size = new System.Drawing.Size(120, 20);
            this.textBox_first_name.TabIndex = 29;
            // 
            // dataGridView_guests
            // 
            this.dataGridView_guests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_guests.Location = new System.Drawing.Point(9, 174);
            this.dataGridView_guests.Name = "dataGridView_guests";
            this.dataGridView_guests.Size = new System.Drawing.Size(846, 125);
            this.dataGridView_guests.TabIndex = 24;
            this.dataGridView_guests.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_guests_CellDoubleClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(249, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Check Out:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(6, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "First Name: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(249, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Check In:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(6, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Last Name: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Persons:";
            // 
            // btn_insert_guests_table
            // 
            this.btn_insert_guests_table.Location = new System.Drawing.Point(618, 23);
            this.btn_insert_guests_table.Name = "btn_insert_guests_table";
            this.btn_insert_guests_table.Size = new System.Drawing.Size(120, 27);
            this.btn_insert_guests_table.TabIndex = 22;
            this.btn_insert_guests_table.Text = "Insert";
            this.btn_insert_guests_table.UseVisualStyleBackColor = true;
            this.btn_insert_guests_table.Click += new System.EventHandler(this.btn_insert_guests_table_Click);
            // 
            // textBox_persons
            // 
            this.textBox_persons.Location = new System.Drawing.Point(97, 105);
            this.textBox_persons.MaxLength = 3;
            this.textBox_persons.Name = "textBox_persons";
            this.textBox_persons.Size = new System.Drawing.Size(121, 20);
            this.textBox_persons.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Refresh_Rooms);
            this.groupBox1.Controls.Add(this.dataGridView_rooms);
            this.groupBox1.Controls.Add(this.comboBox_Room_No);
            this.groupBox1.Controls.Add(this.comboBox_Room_Floors);
            this.groupBox1.Controls.Add(this.btn_Insert_Room);
            this.groupBox1.Controls.Add(this.textBox_Room_Price);
            this.groupBox1.Controls.Add(this.comboBox_Room_Status);
            this.groupBox1.Controls.Add(this.comboBox_Room_Type);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(56, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(864, 312);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rooms";
            // 
            // btn_Refresh_Rooms
            // 
            this.btn_Refresh_Rooms.Location = new System.Drawing.Point(252, 115);
            this.btn_Refresh_Rooms.Name = "btn_Refresh_Rooms";
            this.btn_Refresh_Rooms.Size = new System.Drawing.Size(120, 27);
            this.btn_Refresh_Rooms.TabIndex = 13;
            this.btn_Refresh_Rooms.Text = "Refresh";
            this.btn_Refresh_Rooms.UseVisualStyleBackColor = true;
            this.btn_Refresh_Rooms.Click += new System.EventHandler(this.btn_Refresh_Rooms_Click);
            // 
            // dataGridView_rooms
            // 
            this.dataGridView_rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_rooms.Location = new System.Drawing.Point(9, 165);
            this.dataGridView_rooms.Name = "dataGridView_rooms";
            this.dataGridView_rooms.Size = new System.Drawing.Size(846, 125);
            this.dataGridView_rooms.TabIndex = 12;
            this.dataGridView_rooms.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_rooms_CellDoubleClick);
            this.dataGridView_rooms.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_rooms_CellFormatting);
            // 
            // comboBox_Room_No
            // 
            this.comboBox_Room_No.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Room_No.FormattingEnabled = true;
            this.comboBox_Room_No.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox_Room_No.Location = new System.Drawing.Point(91, 30);
            this.comboBox_Room_No.Name = "comboBox_Room_No";
            this.comboBox_Room_No.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Room_No.TabIndex = 11;
            // 
            // comboBox_Room_Floors
            // 
            this.comboBox_Room_Floors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Room_Floors.FormattingEnabled = true;
            this.comboBox_Room_Floors.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBox_Room_Floors.Location = new System.Drawing.Point(91, 57);
            this.comboBox_Room_Floors.Name = "comboBox_Room_Floors";
            this.comboBox_Room_Floors.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Room_Floors.TabIndex = 11;
            // 
            // btn_Insert_Room
            // 
            this.btn_Insert_Room.Location = new System.Drawing.Point(252, 78);
            this.btn_Insert_Room.Name = "btn_Insert_Room";
            this.btn_Insert_Room.Size = new System.Drawing.Size(120, 27);
            this.btn_Insert_Room.TabIndex = 10;
            this.btn_Insert_Room.Text = "Insert";
            this.btn_Insert_Room.UseVisualStyleBackColor = true;
            this.btn_Insert_Room.Click += new System.EventHandler(this.btn_Insert_Room_Click);
            // 
            // textBox_Room_Price
            // 
            this.textBox_Room_Price.Location = new System.Drawing.Point(91, 139);
            this.textBox_Room_Price.Name = "textBox_Room_Price";
            this.textBox_Room_Price.Size = new System.Drawing.Size(121, 20);
            this.textBox_Room_Price.TabIndex = 9;
            this.textBox_Room_Price.UseWaitCursor = true;
            // 
            // comboBox_Room_Status
            // 
            this.comboBox_Room_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Room_Status.FormattingEnabled = true;
            this.comboBox_Room_Status.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox_Room_Status.Location = new System.Drawing.Point(91, 112);
            this.comboBox_Room_Status.Name = "comboBox_Room_Status";
            this.comboBox_Room_Status.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Room_Status.TabIndex = 8;
            // 
            // comboBox_Room_Type
            // 
            this.comboBox_Room_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Room_Type.FormattingEnabled = true;
            this.comboBox_Room_Type.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBox_Room_Type.Location = new System.Drawing.Point(91, 82);
            this.comboBox_Room_Type.Name = "comboBox_Room_Type";
            this.comboBox_Room_Type.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Room_Type.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Room Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Room Status :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Room Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Floor :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room No` :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_refresh);
            this.tabPage2.Controls.Add(this.comboBox_Filter_Room_Floor);
            this.tabPage2.Controls.Add(this.comboBox_Filter_By_Status);
            this.tabPage2.Controls.Add(this.comboBox_Filter_By_Type);
            this.tabPage2.Controls.Add(this.textBox_Filert_By_Price);
            this.tabPage2.Controls.Add(this.btn_Filter_By_Price);
            this.tabPage2.Controls.Add(this.btn_Filter_By_Status);
            this.tabPage2.Controls.Add(this.btn_Filter_By_Type);
            this.tabPage2.Controls.Add(this.btn_Filter_By_Floor);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(973, 669);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Room Management";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(667, 204);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(289, 28);
            this.btn_refresh.TabIndex = 10;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // comboBox_Filter_Room_Floor
            // 
            this.comboBox_Filter_Room_Floor.FormattingEnabled = true;
            this.comboBox_Filter_Room_Floor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBox_Filter_Room_Floor.Location = new System.Drawing.Point(771, 27);
            this.comboBox_Filter_Room_Floor.Name = "comboBox_Filter_Room_Floor";
            this.comboBox_Filter_Room_Floor.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Filter_Room_Floor.TabIndex = 9;
            // 
            // comboBox_Filter_By_Status
            // 
            this.comboBox_Filter_By_Status.FormattingEnabled = true;
            this.comboBox_Filter_By_Status.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox_Filter_By_Status.Location = new System.Drawing.Point(771, 105);
            this.comboBox_Filter_By_Status.Name = "comboBox_Filter_By_Status";
            this.comboBox_Filter_By_Status.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Filter_By_Status.TabIndex = 8;
            // 
            // comboBox_Filter_By_Type
            // 
            this.comboBox_Filter_By_Type.FormattingEnabled = true;
            this.comboBox_Filter_By_Type.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBox_Filter_By_Type.Location = new System.Drawing.Point(772, 65);
            this.comboBox_Filter_By_Type.Name = "comboBox_Filter_By_Type";
            this.comboBox_Filter_By_Type.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Filter_By_Type.TabIndex = 7;
            // 
            // textBox_Filert_By_Price
            // 
            this.textBox_Filert_By_Price.Location = new System.Drawing.Point(772, 145);
            this.textBox_Filert_By_Price.Name = "textBox_Filert_By_Price";
            this.textBox_Filert_By_Price.Size = new System.Drawing.Size(100, 20);
            this.textBox_Filert_By_Price.TabIndex = 6;
            // 
            // btn_Filter_By_Price
            // 
            this.btn_Filter_By_Price.Location = new System.Drawing.Point(630, 132);
            this.btn_Filter_By_Price.Name = "btn_Filter_By_Price";
            this.btn_Filter_By_Price.Size = new System.Drawing.Size(135, 33);
            this.btn_Filter_By_Price.TabIndex = 4;
            this.btn_Filter_By_Price.Text = "Filer By Price ( Lte )";
            this.btn_Filter_By_Price.UseVisualStyleBackColor = true;
            this.btn_Filter_By_Price.Click += new System.EventHandler(this.btn_Filter_By_Price_Click);
            // 
            // btn_Filter_By_Status
            // 
            this.btn_Filter_By_Status.Location = new System.Drawing.Point(630, 93);
            this.btn_Filter_By_Status.Name = "btn_Filter_By_Status";
            this.btn_Filter_By_Status.Size = new System.Drawing.Size(135, 33);
            this.btn_Filter_By_Status.TabIndex = 3;
            this.btn_Filter_By_Status.Text = "Filter By Status";
            this.btn_Filter_By_Status.UseVisualStyleBackColor = true;
            this.btn_Filter_By_Status.Click += new System.EventHandler(this.btn_Filter_By_Status_Click);
            // 
            // btn_Filter_By_Type
            // 
            this.btn_Filter_By_Type.Location = new System.Drawing.Point(630, 54);
            this.btn_Filter_By_Type.Name = "btn_Filter_By_Type";
            this.btn_Filter_By_Type.Size = new System.Drawing.Size(135, 33);
            this.btn_Filter_By_Type.TabIndex = 2;
            this.btn_Filter_By_Type.Text = "Filter By Type";
            this.btn_Filter_By_Type.UseVisualStyleBackColor = true;
            this.btn_Filter_By_Type.Click += new System.EventHandler(this.btn_Filter_By_Type_Click);
            // 
            // btn_Filter_By_Floor
            // 
            this.btn_Filter_By_Floor.Location = new System.Drawing.Point(630, 14);
            this.btn_Filter_By_Floor.Name = "btn_Filter_By_Floor";
            this.btn_Filter_By_Floor.Size = new System.Drawing.Size(135, 33);
            this.btn_Filter_By_Floor.TabIndex = 1;
            this.btn_Filter_By_Floor.Text = "Filter By Floor ";
            this.btn_Filter_By_Floor.UseVisualStyleBackColor = true;
            this.btn_Filter_By_Floor.Click += new System.EventHandler(this.btn_Filter_By_Floor_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView);
            this.groupBox2.Location = new System.Drawing.Point(29, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 380);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rooms";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(18, 21);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(542, 347);
            this.dataGridView.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 718);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_guests)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rooms)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Insert_Room;
        private System.Windows.Forms.TextBox textBox_Room_Price;
        private System.Windows.Forms.ComboBox comboBox_Room_Status;
        private System.Windows.Forms.ComboBox comboBox_Room_Type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Filter_By_Status;
        private System.Windows.Forms.ComboBox comboBox_Filter_By_Type;
        private System.Windows.Forms.TextBox textBox_Filert_By_Price;
        private System.Windows.Forms.Button btn_Filter_By_Price;
        private System.Windows.Forms.Button btn_Filter_By_Status;
        private System.Windows.Forms.Button btn_Filter_By_Type;
        private System.Windows.Forms.Button btn_Filter_By_Floor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox comboBox_Room_Floors;
        private System.Windows.Forms.ComboBox comboBox_Filter_Room_Floor;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataGridView dataGridView_rooms;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView_guests;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_insert_guests_table;
        private System.Windows.Forms.TextBox textBox_persons;
        private System.Windows.Forms.TextBox textBox_last_name;
        private System.Windows.Forms.TextBox textBox_first_name;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.DateTimePicker dateTimePicker_check_out;
        private System.Windows.Forms.DateTimePicker dateTimePicker_check_in;
        private System.Windows.Forms.Button btn_Refresh_Guests_Click;
        private System.Windows.Forms.Button btn_Refresh_Rooms;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_number_of_rooms;
        private System.Windows.Forms.ComboBox comboBox_Room_No;
    }
}

