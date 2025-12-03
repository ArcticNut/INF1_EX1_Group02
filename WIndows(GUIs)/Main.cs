using INF1_EX1_Group02.Classes;

namespace INF1_EX1_Group02.Windows_GUIs_
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }

        private void buttonAddBuilding_Click(object sender, EventArgs e)
        {
            BuildingForm form = new BuildingForm();
            form.ShowDialog();
            FillBuildingListBox();
        }

        private void buttonBuildingDelete_Click(object sender, EventArgs e)
        {
            Building selectedBuilding = listBoxBuildings.SelectedItem as Building;

            if (selectedBuilding == null)
            {
                MessageBox.Show("Please select a building to delete.");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete '{selectedBuilding.Name}'?",
                "Delete Building",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }

            AppData.Buildings.Remove(selectedBuilding);
            FillBuildingListBox();

            // Clear Floors + Rooms lists
            listBoxFloors.Items.Clear();
            listBoxRooms.Items.Clear();

            // Clear summaries
            labelBuildingSum.Text = "Building Summary:";
            labelFloorSum.Text = "Floor Summary:";
            labelRoomSum.Text = "Room Summary:";
        }
        
        private void listBoxBuildings_SelectedIndexChanged(object sender, EventArgs e)
        {
            Building selectedBuilding = listBoxBuildings.SelectedItem as Building;

            if (selectedBuilding == null)
                return;

            FillFloorListBox(selectedBuilding);
            UpdateBuildingSum(selectedBuilding);
        }

        private void buttonFloorsAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonFloorsDelete_Click(object sender, EventArgs e)
        {

        }

        private void listBoxFloors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonRoomsAdd_Click(object sender, EventArgs e)
        {
            if (listBoxFloors.SelectedItem == null)
            {
                MessageBox.Show("Please select the floor to which you want to add a room.", "No Floor Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Floor selectedFloor = listBoxFloors.SelectedItem as Floor;
            new RoomForm(selectedFloor).ShowDialog();
        }

        private void buttonRoomsDelete_Click(object sender, EventArgs e)
        {
            if (listBoxFloors.SelectedItem == null)
            {
                MessageBox.Show("Please select the floor from which you want to delte a room.", "No Floor Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Floor selectedFloor = listBoxFloors.SelectedItem as Floor;

            if (listBoxRooms.SelectedItem == null) 
            {
                MessageBox.Show("Please select a room to delete.", "No Room Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            
            Room selectedRoom = listBoxRooms.SelectedItem as Room;
            
            string message = $"Are you sure you want to delete the selected room: {selectedRoom} ?";
            DialogResult result = MessageBox.Show(message, "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }
            selectedFloor.Rooms.Remove(selectedRoom);
            FillRoomListBox(selectedFloor);
        }

        private void buttonRoomsEdit_Click(object sender, EventArgs e)
        {
            if (listBoxFloors.SelectedItem == null)
            {
                MessageBox.Show("Please select the floor on which you want to edit a room.", "No Floor Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (listBoxRooms.SelectedItem == null)
            { 
                MessageBox.Show("Please select a room to edit.", "No Room Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Floor selectedFloor = listBoxFloors.SelectedItem as Floor;           
            Room selectedRoom = listBoxRooms.SelectedItem as Room;
            new RoomForm(selectedFloor, selectedRoom).ShowDialog();
        }

        private void listBoxRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            Room selectedRoom = listBoxRooms.SelectedItem as Room;
            if (selectedRoom != null)
            {
                UpdateRoomSum(selectedRoom);
            }
        }

        private void buttonRoomAddFurniture_Click(object sender, EventArgs e)
        {
            Room selectedRoom = listBoxRooms.SelectedItem as Room;
            if (selectedRoom != null)
            {
                new FurnitureForm(selectedRoom).ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a room to add furniture to.", "No Room Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonManageUses_Click(object sender, EventArgs e)
        {
            new UseForm().ShowDialog();
        }

        public void FillBuildingListBox()
        {
            listBoxBuildings.Items.Clear();

            foreach (Building b in AppData.Buildings)
            {
                listBoxBuildings.Items.Add(b);
            }
        }


        private void FillFloorListBox(Building building)
        {
        }

        private void FillRoomListBox(Floor floor)
        {
            listBoxRooms.Items.Clear();
            // add all rooms of the Floor to the listBox
            foreach(Room room in floor.Rooms)
            {
                listBoxRooms.Items.Add(room);
            }
        }

        private void UpdateBuildingSum(Building building)
        {
            if (building == null)
            {
                labelBuildingSum.Text = "Building Summary:";
                return;
            }

            // Recalculate totals
            building.totalCost();
            building.totalFurniture();

            // Build the summary text
            string summary = "Building Summary:\n" +
                             $"Total Cost: {building.TotCost} €\n" +
                             $"Total Amount of Furniture: {building.TotFurniture}";

            // Show it in the label
            labelBuildingSum.Text = summary;

        }

        private void UpdateFloorSum(Floor floor)
        {
        }

        private void UpdateRoomSum(Room room)
        {
            if (room == null)
            {
                labelRoomSum.Text = "Room Summary:";
                return;
            }

            room.CalcLoad();
            room.CalcRoomCost();
            room.CalcSlabVol();

            string summary = "Room Summary:\n" +
                $"Room Nr.: {room.RoomNr}\n" +
                $"Area: {room.Area.ToString()} m²\n" +
                $"Use: {room.Use.ToString()}\n" +
                $"Load: {room.Load.ToString()} kN/m²\n" +
                $"Slab Volume: {room.SlabVol.ToString()} m³\n" +
                $"Concrete Cost: {room.Cost.ToString()} €\n" +
                "Furniture:\n";
            foreach (Furniture furniture in room.Furnitures)
            {
                summary += $"- {furniture.ToString()}\n";
            }

            labelRoomSum.Text = summary;
        }

    }
}
