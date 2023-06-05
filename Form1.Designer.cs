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
            this.Insert_Room_s = new System.Windows.Forms.TabPage();
            this.Rooms_Management = new System.Windows.Forms.TabPage();
            this.Insert_Room = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Room_no = new System.Windows.Forms.TextBox();
            this.textBox_Room_Floor = new System.Windows.Forms.TextBox();
            this.textBox_Room_Price = new System.Windows.Forms.TextBox();
            this.comboBox_Room_Type = new System.Windows.Forms.ComboBox();
            this.comboBox_Room_Status = new System.Windows.Forms.ComboBox();
            this.btn_Insert_Room = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Filter_By_Floor = new System.Windows.Forms.Button();
            this.textBox_Filter_By_Floor = new System.Windows.Forms.TextBox();
            this.btn_Filter_By_Type = new System.Windows.Forms.Button();
            this.textBox_Filter_By_Type = new System.Windows.Forms.TextBox();
            this.btn_Filter_By_Status = new System.Windows.Forms.Button();
            this.textBox_Filter_By_Status = new System.Windows.Forms.TextBox();
            this.btn_Filter_By_Price = new System.Windows.Forms.Button();
            this.textBox_Filter_By_Price = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.Insert_Room_s.SuspendLayout();
            this.Rooms_Management.SuspendLayout();
            this.Insert_Room.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Insert_Room_s);
            this.tabControl1.Controls.Add(this.Rooms_Management);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1309, 574);
            this.tabControl1.TabIndex = 0;
            // 
            // Insert_Room_s
            // 
            this.Insert_Room_s.Controls.Add(this.Insert_Room);
            this.Insert_Room_s.Location = new System.Drawing.Point(4, 25);
            this.Insert_Room_s.Name = "Insert_Room_s";
            this.Insert_Room_s.Padding = new System.Windows.Forms.Padding(3);
            this.Insert_Room_s.Size = new System.Drawing.Size(1301, 454);
            this.Insert_Room_s.TabIndex = 0;
            this.Insert_Room_s.Text = "Insert Room(s)";
            this.Insert_Room_s.UseVisualStyleBackColor = true;
            // 
            // Rooms_Management
            // 
            this.Rooms_Management.Controls.Add(this.textBox_Filter_By_Price);
            this.Rooms_Management.Controls.Add(this.btn_Filter_By_Price);
            this.Rooms_Management.Controls.Add(this.textBox_Filter_By_Status);
            this.Rooms_Management.Controls.Add(this.btn_Filter_By_Status);
            this.Rooms_Management.Controls.Add(this.textBox_Filter_By_Type);
            this.Rooms_Management.Controls.Add(this.btn_Filter_By_Type);
            this.Rooms_Management.Controls.Add(this.textBox_Filter_By_Floor);
            this.Rooms_Management.Controls.Add(this.btn_Filter_By_Floor);
            this.Rooms_Management.Controls.Add(this.groupBox1);
            this.Rooms_Management.Location = new System.Drawing.Point(4, 25);
            this.Rooms_Management.Name = "Rooms_Management";
            this.Rooms_Management.Padding = new System.Windows.Forms.Padding(3);
            this.Rooms_Management.Size = new System.Drawing.Size(1301, 545);
            this.Rooms_Management.TabIndex = 1;
            this.Rooms_Management.Text = "Rooms Management";
            this.Rooms_Management.UseVisualStyleBackColor = true;
            // 
            // Insert_Room
            // 
            this.Insert_Room.Controls.Add(this.btn_Insert_Room);
            this.Insert_Room.Controls.Add(this.comboBox_Room_Status);
            this.Insert_Room.Controls.Add(this.comboBox_Room_Type);
            this.Insert_Room.Controls.Add(this.textBox_Room_Price);
            this.Insert_Room.Controls.Add(this.textBox_Room_Floor);
            this.Insert_Room.Controls.Add(this.textBox_Room_no);
            this.Insert_Room.Controls.Add(this.label5);
            this.Insert_Room.Controls.Add(this.label4);
            this.Insert_Room.Controls.Add(this.label3);
            this.Insert_Room.Controls.Add(this.label2);
            this.Insert_Room.Controls.Add(this.label1);
            this.Insert_Room.Location = new System.Drawing.Point(61, 51);
            this.Insert_Room.Name = "Insert_Room";
            this.Insert_Room.Size = new System.Drawing.Size(1182, 364);
            this.Insert_Room.TabIndex = 0;
            this.Insert_Room.TabStop = false;
            this.Insert_Room.Text = "Insert Room";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room No` : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room floor :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Room Type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Room Price :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Room Status :";
            // 
            // textBox_Room_no
            // 
            this.textBox_Room_no.Location = new System.Drawing.Point(197, 56);
            this.textBox_Room_no.Name = "textBox_Room_no";
            this.textBox_Room_no.Size = new System.Drawing.Size(123, 22);
            this.textBox_Room_no.TabIndex = 5;
            // 
            // textBox_Room_Floor
            // 
            this.textBox_Room_Floor.Location = new System.Drawing.Point(207, 101);
            this.textBox_Room_Floor.Name = "textBox_Room_Floor";
            this.textBox_Room_Floor.Size = new System.Drawing.Size(123, 22);
            this.textBox_Room_Floor.TabIndex = 6;
            // 
            // textBox_Room_Price
            // 
            this.textBox_Room_Price.Location = new System.Drawing.Point(213, 250);
            this.textBox_Room_Price.Name = "textBox_Room_Price";
            this.textBox_Room_Price.Size = new System.Drawing.Size(123, 22);
            this.textBox_Room_Price.TabIndex = 8;
            // 
            // comboBox_Room_Type
            // 
            this.comboBox_Room_Type.FormattingEnabled = true;
            this.comboBox_Room_Type.Location = new System.Drawing.Point(215, 147);
            this.comboBox_Room_Type.Name = "comboBox_Room_Type";
            this.comboBox_Room_Type.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Room_Type.TabIndex = 9;
            // 
            // comboBox_Room_Status
            // 
            this.comboBox_Room_Status.FormattingEnabled = true;
            this.comboBox_Room_Status.Location = new System.Drawing.Point(227, 197);
            this.comboBox_Room_Status.Name = "comboBox_Room_Status";
            this.comboBox_Room_Status.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Room_Status.TabIndex = 10;
            // 
            // btn_Insert_Room
            // 
            this.btn_Insert_Room.Location = new System.Drawing.Point(537, 147);
            this.btn_Insert_Room.Name = "btn_Insert_Room";
            this.btn_Insert_Room.Size = new System.Drawing.Size(458, 50);
            this.btn_Insert_Room.TabIndex = 11;
            this.btn_Insert_Room.Text = "Insert Room";
            this.btn_Insert_Room.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Refresh);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 327);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Balilo Rooms";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(798, 249);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(257, 277);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(312, 40);
            this.btn_Refresh.TabIndex = 1;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            // 
            // btn_Filter_By_Floor
            // 
            this.btn_Filter_By_Floor.Location = new System.Drawing.Point(838, 15);
            this.btn_Filter_By_Floor.Name = "btn_Filter_By_Floor";
            this.btn_Filter_By_Floor.Size = new System.Drawing.Size(142, 45);
            this.btn_Filter_By_Floor.TabIndex = 1;
            this.btn_Filter_By_Floor.Text = "Filter By Floor :";
            this.btn_Filter_By_Floor.UseVisualStyleBackColor = true;
            // 
            // textBox_Filter_By_Floor
            // 
            this.textBox_Filter_By_Floor.Location = new System.Drawing.Point(986, 38);
            this.textBox_Filter_By_Floor.Name = "textBox_Filter_By_Floor";
            this.textBox_Filter_By_Floor.Size = new System.Drawing.Size(212, 22);
            this.textBox_Filter_By_Floor.TabIndex = 2;
            // 
            // btn_Filter_By_Type
            // 
            this.btn_Filter_By_Type.Location = new System.Drawing.Point(838, 81);
            this.btn_Filter_By_Type.Name = "btn_Filter_By_Type";
            this.btn_Filter_By_Type.Size = new System.Drawing.Size(142, 45);
            this.btn_Filter_By_Type.TabIndex = 3;
            this.btn_Filter_By_Type.Text = "Filter By Type :";
            this.btn_Filter_By_Type.UseVisualStyleBackColor = true;
            // 
            // textBox_Filter_By_Type
            // 
            this.textBox_Filter_By_Type.Location = new System.Drawing.Point(986, 104);
            this.textBox_Filter_By_Type.Name = "textBox_Filter_By_Type";
            this.textBox_Filter_By_Type.Size = new System.Drawing.Size(212, 22);
            this.textBox_Filter_By_Type.TabIndex = 4;
            // 
            // btn_Filter_By_Status
            // 
            this.btn_Filter_By_Status.Location = new System.Drawing.Point(838, 156);
            this.btn_Filter_By_Status.Name = "btn_Filter_By_Status";
            this.btn_Filter_By_Status.Size = new System.Drawing.Size(142, 45);
            this.btn_Filter_By_Status.TabIndex = 5;
            this.btn_Filter_By_Status.Text = "Filter By Status :";
            this.btn_Filter_By_Status.UseVisualStyleBackColor = true;
            // 
            // textBox_Filter_By_Status
            // 
            this.textBox_Filter_By_Status.Location = new System.Drawing.Point(986, 179);
            this.textBox_Filter_By_Status.Name = "textBox_Filter_By_Status";
            this.textBox_Filter_By_Status.Size = new System.Drawing.Size(212, 22);
            this.textBox_Filter_By_Status.TabIndex = 6;
            // 
            // btn_Filter_By_Price
            // 
            this.btn_Filter_By_Price.Location = new System.Drawing.Point(838, 240);
            this.btn_Filter_By_Price.Name = "btn_Filter_By_Price";
            this.btn_Filter_By_Price.Size = new System.Drawing.Size(142, 45);
            this.btn_Filter_By_Price.TabIndex = 7;
            this.btn_Filter_By_Price.Text = "Filter By Price :";
            this.btn_Filter_By_Price.UseVisualStyleBackColor = true;
            // 
            // textBox_Filter_By_Price
            // 
            this.textBox_Filter_By_Price.Location = new System.Drawing.Point(986, 263);
            this.textBox_Filter_By_Price.Name = "textBox_Filter_By_Price";
            this.textBox_Filter_By_Price.Size = new System.Drawing.Size(212, 22);
            this.textBox_Filter_By_Price.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 598);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Insert_Room_s.ResumeLayout(false);
            this.Rooms_Management.ResumeLayout(false);
            this.Rooms_Management.PerformLayout();
            this.Insert_Room.ResumeLayout(false);
            this.Insert_Room.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Insert_Room_s;
        private System.Windows.Forms.TabPage Rooms_Management;
        private System.Windows.Forms.GroupBox Insert_Room;
        private System.Windows.Forms.Button btn_Insert_Room;
        private System.Windows.Forms.ComboBox comboBox_Room_Status;
        private System.Windows.Forms.ComboBox comboBox_Room_Type;
        private System.Windows.Forms.TextBox textBox_Room_Price;
        private System.Windows.Forms.TextBox textBox_Room_Floor;
        private System.Windows.Forms.TextBox textBox_Room_no;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_Filter_By_Price;
        private System.Windows.Forms.Button btn_Filter_By_Price;
        private System.Windows.Forms.TextBox textBox_Filter_By_Status;
        private System.Windows.Forms.Button btn_Filter_By_Status;
        private System.Windows.Forms.TextBox textBox_Filter_By_Type;
        private System.Windows.Forms.Button btn_Filter_By_Type;
        private System.Windows.Forms.TextBox textBox_Filter_By_Floor;
        private System.Windows.Forms.Button btn_Filter_By_Floor;
        private System.Windows.Forms.Button btn_Refresh;
    }
}

