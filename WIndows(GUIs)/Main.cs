using INF1_EX1_Group02.Windows_GUIs_;
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
                MessageBox.Show("Please select a building to delete.", "No Building Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            UpdateBuildingSum(null);
            UpdateFloorSummary(null);
            UpdateRoomSum(null);
        }
        
        private void listBoxBuildings_SelectedIndexChanged(object sender, EventArgs e)
        {
            Building selectedBuilding = listBoxBuildings.SelectedItem as Building;

            if (selectedBuilding == null)
                return;

            FillListBoxFloor(selectedBuilding);
            UpdateBuildingSum(selectedBuilding);
        }

        private void buttonFloorsAdd_Click(object sender, EventArgs e)
        {
            Building selectedBuilding = listBoxBuildings.SelectedItem as Building;

            if (selectedBuilding == null)
            {
                MessageBox.Show("Please select a building first.",
                                "No Building Selected",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            using (FloorForm form = new FloorForm(selectedBuilding))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    FillListBoxFloor(selectedBuilding);
                    UpdateBuildingSum(selectedBuilding);
                }
            }
        }


        private void buttonFloorsDelete_Click(object sender, EventArgs e)
        {
            Building selectedBuilding = listBoxBuildings.SelectedItem as Building;
            if (selectedBuilding == null)
            {
                MessageBox.Show("Please select a building first.",
                                "No Building Selected",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            Floor selectedFloor = listBoxFloors.SelectedItem as Floor;
            if (selectedFloor == null)
            {
                MessageBox.Show("Please select a floor to delete.",
                                "No Floor Selected",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete floor {selectedFloor.Level}?",
                "Delete Floor",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                return;

            // deleting the floor from the building
            selectedBuilding.Floors.Remove(selectedFloor);

            // renewing the floor list
            FillListBoxFloor(selectedBuilding);

            // update summaries and clear room list
            listBoxRooms.Items.Clear();
            UpdateFloorSummary(null);
            UpdateBuildingSum(selectedBuilding);
        }

        private void listBoxFloors_SelectedIndexChanged(object sender, EventArgs e)
        {
            Floor selectedFloor = listBoxFloors.SelectedItem as Floor;

            if (selectedFloor == null)
            {
                // when no floor is selected, clear room list and floor summary
                listBoxRooms.Items.Clear();
                UpdateFloorSummary(null);
                return;
            }

            // show rooms of the selected floor
            FillListBoxRoom(selectedFloor);

            // update floor summary
            UpdateFloorSummary(selectedFloor);
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
            FillListBoxRoom(selectedFloor);
            UpdateFloorSummary(selectedFloor);
            UpdateBuildingSum(listBoxBuildings.SelectedItem as Building);
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
            FillListBoxRoom(selectedFloor);
            UpdateRoomSum(null);
            UpdateFloorSummary(selectedFloor);
            UpdateBuildingSum(listBoxBuildings.SelectedItem as Building);
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
            UpdateRoomSum(selectedRoom);
            UpdateFloorSummary(selectedFloor);
            UpdateBuildingSum(listBoxBuildings.SelectedItem as Building);
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

            UpdateRoomSum(selectedRoom);
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


        private void FillListBoxFloor(Building building)
        {
            listBoxFloors.Items.Clear();
            if (building == null) return;

            foreach (Floor floor in building.Floors)
            {
                listBoxFloors.Items.Add(floor);
            }
        }


        private void FillListBoxRoom(Floor floor)
        {
            listBoxRooms.Items.Clear();
            if (floor == null) return;

            // add all rooms of the Floor to the listBox
            foreach (Room room in floor.Rooms)
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
            building.totalHeight();

            // Build the summary text
            string summary = "Building Summary:\n" +
                             $"Total Cost: {building.TotCost} €\n" +
                             $"Heigth of the Building: {building.Height}\n" +
                             $"Total Amount of Furniture: {building.TotFurniture}\n";
                             
            // Show it in the label
            labelBuildingSum.Text = summary;

        }

        private void UpdateFloorSummary(Floor floor)
        {
            if (floor == null)
            {
                labelFloorSum.Text = "Floor Summary:";
                return;
            }

            // take the calculations from the Floor class
            double totalCost = floor.CalcTotalCost();
            int totalFurniture = floor.CalcTotFurniture();

            string summary = "Floor Summary:\n" +
                             $"Total Cost: {totalCost} €\n" +
                             $"Total Amount of Furniture: {totalFurniture}";

            labelFloorSum.Text = summary;
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
