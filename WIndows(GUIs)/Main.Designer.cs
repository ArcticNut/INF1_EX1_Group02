namespace INF1_EX1_Group02.Windows_GUIs_
{
    partial class Main
    {
        /// <summary>S
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxBuildings = new ListBox();
            listBoxFloors = new ListBox();
            listBoxRooms = new ListBox();
            buttonBuildingAdd = new Button();
            buttonBuildingDelete = new Button();
            buttonFloorsDelete = new Button();
            buttonFloorsAdd = new Button();
            buttonRoomsDelete = new Button();
            buttonRoomsAdd = new Button();
            buttonRoomsEdit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonManageUses = new Button();
            buttonRoomAddFurniture = new Button();
            labelBuildingSum = new Label();
            labelFloorSum = new Label();
            labelRoomSum = new Label();
            SuspendLayout();
            // 
            // listBoxBuildings
            // 
            listBoxBuildings.FormattingEnabled = true;
            listBoxBuildings.Location = new Point(18, 71);
            listBoxBuildings.Name = "listBoxBuildings";
            listBoxBuildings.Size = new Size(176, 224);
            listBoxBuildings.TabIndex = 0;
            listBoxBuildings.SelectedIndexChanged += listBoxBuildings_SelectedIndexChanged;
            // 
            // listBoxFloors
            // 
            listBoxFloors.FormattingEnabled = true;
            listBoxFloors.Location = new Point(220, 71);
            listBoxFloors.Name = "listBoxFloors";
            listBoxFloors.Size = new Size(176, 224);
            listBoxFloors.TabIndex = 1;
            // 
            // listBoxRooms
            // 
            listBoxRooms.FormattingEnabled = true;
            listBoxRooms.Location = new Point(422, 71);
            listBoxRooms.Name = "listBoxRooms";
            listBoxRooms.Size = new Size(176, 224);
            listBoxRooms.TabIndex = 2;
            // 
            // buttonBuildingAdd
            // 
            buttonBuildingAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonBuildingAdd.Location = new Point(18, 311);
            buttonBuildingAdd.Name = "buttonBuildingAdd";
            buttonBuildingAdd.Size = new Size(55, 29);
            buttonBuildingAdd.TabIndex = 3;
            buttonBuildingAdd.Text = "+";
            buttonBuildingAdd.UseVisualStyleBackColor = true;
            buttonBuildingAdd.Click += buttonAddBuilding_Click;
            // 
            // buttonBuildingDelete
            // 
            buttonBuildingDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonBuildingDelete.Location = new Point(79, 311);
            buttonBuildingDelete.Name = "buttonBuildingDelete";
            buttonBuildingDelete.Size = new Size(55, 29);
            buttonBuildingDelete.TabIndex = 4;
            buttonBuildingDelete.Text = "-";
            buttonBuildingDelete.UseVisualStyleBackColor = true;
            buttonBuildingDelete.Click += buttonBuildingDelete_Click;
            // 
            // buttonFloorsDelete
            // 
            buttonFloorsDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonFloorsDelete.Location = new Point(281, 311);
            buttonFloorsDelete.Name = "buttonFloorsDelete";
            buttonFloorsDelete.Size = new Size(55, 29);
            buttonFloorsDelete.TabIndex = 6;
            buttonFloorsDelete.Text = "-";
            buttonFloorsDelete.UseVisualStyleBackColor = true;
            // 
            // buttonFloorsAdd
            // 
            buttonFloorsAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonFloorsAdd.Location = new Point(220, 311);
            buttonFloorsAdd.Name = "buttonFloorsAdd";
            buttonFloorsAdd.Size = new Size(55, 29);
            buttonFloorsAdd.TabIndex = 5;
            buttonFloorsAdd.Text = "+";
            buttonFloorsAdd.UseVisualStyleBackColor = true;
            // 
            // buttonRoomsDelete
            // 
            buttonRoomsDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonRoomsDelete.Location = new Point(482, 311);
            buttonRoomsDelete.Name = "buttonRoomsDelete";
            buttonRoomsDelete.Size = new Size(55, 29);
            buttonRoomsDelete.TabIndex = 8;
            buttonRoomsDelete.Text = "-";
            buttonRoomsDelete.UseVisualStyleBackColor = true;
            // 
            // buttonRoomsAdd
            // 
            buttonRoomsAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonRoomsAdd.Location = new Point(421, 311);
            buttonRoomsAdd.Name = "buttonRoomsAdd";
            buttonRoomsAdd.Size = new Size(55, 29);
            buttonRoomsAdd.TabIndex = 7;
            buttonRoomsAdd.Text = "+";
            buttonRoomsAdd.UseVisualStyleBackColor = true;
            // 
            // buttonRoomsEdit
            // 
            buttonRoomsEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonRoomsEdit.Location = new Point(543, 311);
            buttonRoomsEdit.Name = "buttonRoomsEdit";
            buttonRoomsEdit.Size = new Size(55, 29);
            buttonRoomsEdit.TabIndex = 9;
            buttonRoomsEdit.Text = "Edit";
            buttonRoomsEdit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 49);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 10;
            label1.Text = "Buildings";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 49);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 11;
            label2.Text = "Floors";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(421, 48);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 12;
            label3.Text = "Rooms";
            // 
            // buttonManageUses
            // 
            buttonManageUses.Location = new Point(18, 12);
            buttonManageUses.Name = "buttonManageUses";
            buttonManageUses.Size = new Size(116, 29);
            buttonManageUses.TabIndex = 13;
            buttonManageUses.Text = "Manage Uses";
            buttonManageUses.UseVisualStyleBackColor = true;
            // 
            // buttonRoomAddFurniture
            // 
            buttonRoomAddFurniture.Location = new Point(421, 343);
            buttonRoomAddFurniture.Name = "buttonRoomAddFurniture";
            buttonRoomAddFurniture.Size = new Size(176, 28);
            buttonRoomAddFurniture.TabIndex = 14;
            buttonRoomAddFurniture.Text = "Add Furniture";
            buttonRoomAddFurniture.UseVisualStyleBackColor = true;
            // 
            // labelBuildingSum
            // 
            labelBuildingSum.AutoSize = true;
            labelBuildingSum.Location = new Point(18, 383);
            labelBuildingSum.Name = "labelBuildingSum";
            labelBuildingSum.Size = new Size(133, 20);
            labelBuildingSum.TabIndex = 15;
            labelBuildingSum.Text = "Building Summary:";
            labelBuildingSum.Click += labelBuildingSum_Click;
            // 
            // labelFloorSum
            // 
            labelFloorSum.AutoSize = true;
            labelFloorSum.Location = new Point(220, 383);
            labelFloorSum.Name = "labelFloorSum";
            labelFloorSum.Size = new Size(112, 20);
            labelFloorSum.TabIndex = 16;
            labelFloorSum.Text = "Floor Summary:";
            // 
            // labelRoomSum
            // 
            labelRoomSum.AutoSize = true;
            labelRoomSum.Location = new Point(421, 383);
            labelRoomSum.Name = "labelRoomSum";
            labelRoomSum.Size = new Size(118, 20);
            labelRoomSum.TabIndex = 17;
            labelRoomSum.Text = "Room Summary:";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 560);
            Controls.Add(labelRoomSum);
            Controls.Add(labelFloorSum);
            Controls.Add(labelBuildingSum);
            Controls.Add(buttonRoomAddFurniture);
            Controls.Add(buttonManageUses);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonRoomsEdit);
            Controls.Add(buttonRoomsDelete);
            Controls.Add(buttonRoomsAdd);
            Controls.Add(buttonFloorsDelete);
            Controls.Add(buttonFloorsAdd);
            Controls.Add(buttonBuildingDelete);
            Controls.Add(buttonBuildingAdd);
            Controls.Add(listBoxRooms);
            Controls.Add(listBoxFloors);
            Controls.Add(listBoxBuildings);
            Name = "Main";
            Text = "Form1";
            Load += Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxBuildings;
        private ListBox listBoxFloors;
        private ListBox listBoxRooms;
        private Button buttonBuildingAdd;
        private Button buttonBuildingDelete;
        private Button buttonFloorsDelete;
        private Button buttonFloorsAdd;
        private Button buttonRoomsDelete;
        private Button buttonRoomsAdd;
        private Button buttonRoomsEdit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonManageUses;
        private Button buttonRoomAddFurniture;
        private Label labelBuildingSum;
        private Label labelFloorSum;
        private Label labelRoomSum;
    }
}
