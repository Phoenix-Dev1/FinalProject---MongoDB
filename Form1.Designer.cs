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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_Room_Floors = new System.Windows.Forms.ComboBox();
            this.btn_Insert_Room = new System.Windows.Forms.Button();
            this.textBox_Room_Price = new System.Windows.Forms.TextBox();
            this.comboBox_Room_Status = new System.Windows.Forms.ComboBox();
            this.comboBox_Room_Type = new System.Windows.Forms.ComboBox();
            this.textBox_Roon_No = new System.Windows.Forms.TextBox();
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
            this.groupBox1.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(1040, 412);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1032, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insert Room(s)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_Room_Floors);
            this.groupBox1.Controls.Add(this.btn_Insert_Room);
            this.groupBox1.Controls.Add(this.textBox_Room_Price);
            this.groupBox1.Controls.Add(this.comboBox_Room_Status);
            this.groupBox1.Controls.Add(this.comboBox_Room_Type);
            this.groupBox1.Controls.Add(this.textBox_Roon_No);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(97, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(863, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert Room";
            // 
            // comboBox_Room_Floors
            // 
            this.comboBox_Room_Floors.FormattingEnabled = true;
            this.comboBox_Room_Floors.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBox_Room_Floors.Location = new System.Drawing.Point(166, 77);
            this.comboBox_Room_Floors.Name = "comboBox_Room_Floors";
            this.comboBox_Room_Floors.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Room_Floors.TabIndex = 11;
            // 
            // btn_Insert_Room
            // 
            this.btn_Insert_Room.Location = new System.Drawing.Point(421, 95);
            this.btn_Insert_Room.Name = "btn_Insert_Room";
            this.btn_Insert_Room.Size = new System.Drawing.Size(238, 52);
            this.btn_Insert_Room.TabIndex = 10;
            this.btn_Insert_Room.Text = "Insert";
            this.btn_Insert_Room.UseVisualStyleBackColor = true;
            this.btn_Insert_Room.Click += new System.EventHandler(this.btn_Insert_Room_Click);
            // 
            // textBox_Room_Price
            // 
            this.textBox_Room_Price.Location = new System.Drawing.Point(166, 174);
            this.textBox_Room_Price.Name = "textBox_Room_Price";
            this.textBox_Room_Price.Size = new System.Drawing.Size(100, 20);
            this.textBox_Room_Price.TabIndex = 9;
            // 
            // comboBox_Room_Status
            // 
            this.comboBox_Room_Status.FormattingEnabled = true;
            this.comboBox_Room_Status.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox_Room_Status.Location = new System.Drawing.Point(178, 139);
            this.comboBox_Room_Status.Name = "comboBox_Room_Status";
            this.comboBox_Room_Status.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Room_Status.TabIndex = 8;
            // 
            // comboBox_Room_Type
            // 
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
            this.comboBox_Room_Type.Location = new System.Drawing.Point(163, 112);
            this.comboBox_Room_Type.Name = "comboBox_Room_Type";
            this.comboBox_Room_Type.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Room_Type.TabIndex = 7;
            // 
            // textBox_Roon_No
            // 
            this.textBox_Roon_No.Location = new System.Drawing.Point(153, 36);
            this.textBox_Roon_No.Name = "textBox_Roon_No";
            this.textBox_Roon_No.Size = new System.Drawing.Size(100, 20);
            this.textBox_Roon_No.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Room Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Room Status :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Room Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Floor :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
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
            this.tabPage2.Size = new System.Drawing.Size(1032, 386);
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
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 425);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox_Roon_No;
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
    }
}

