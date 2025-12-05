using INF1_EX1_Group02.Windows_GUIs_;
using INF1_EX1_Group02.Classes;
using System.Windows.Forms;

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
            int index = listBoxBuildings.SelectedIndex;

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
            listBoxBuildings.SelectedIndex = index - 1;

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
            listBoxFloors.Items.Clear();

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

            using (FloorForm form = new FloorForm(selectedBuilding, 1))
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
            Floor selectedFloor = listBoxFloors.SelectedItem as Floor;
            int index = listBoxFloors.SelectedIndex;

            if (index + 1 != selectedBuilding.Floors.Count())
            {
                MessageBox.Show("You can only delete the top floor of a Building", "Error",
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
            listBoxFloors.SelectedIndex = index - 1;

            // update summaries and clear room list
            listBoxRooms.Items.Clear();
            UpdateFloorSummary(null);
            UpdateBuildingSum(selectedBuilding);
        }

        private void listBoxFloors_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxRooms.Items.Clear();

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
            Room selectedRoom = listBoxRooms.SelectedItem as Room;
            int index = listBoxRooms.SelectedIndex;
            Floor selectedFloor = listBoxFloors.SelectedItem as Floor;

            if (selectedRoom == null)
            {
                MessageBox.Show("Please select a room to delete.", "No Room Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm Deletion
            string message = $"Are you sure you want to delete the selected room: {selectedRoom} ?";
            DialogResult result = MessageBox.Show(message, "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }

            // delete the room from the floor
            selectedFloor.Rooms.Remove(selectedRoom);

            // Update Information
            FillListBoxRoom(selectedFloor);
            listBoxRooms.SelectedIndex = index - 1;
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
            int index = -1;

            foreach (Building b in AppData.Buildings)
            {
                listBoxBuildings.Items.Add(b);
                index++;
            }

            // select the latest added building
            listBoxBuildings.SelectedIndex = index;
        }


        private void FillListBoxFloor(Building building)
        {
            listBoxFloors.Items.Clear();
            if (building == null) return;
            int index = -1;

            foreach (Floor floor in building.Floors)
            {
                listBoxFloors.Items.Add(floor);
                index++;
            }
            listBoxFloors.SelectedIndex = index;
        }


        private void FillListBoxRoom(Floor floor)
        {
            listBoxRooms.Items.Clear();
            if (floor == null) return;
            int index = -1;

            // add all rooms of the Floor to the listBox
            foreach (Room room in floor.Rooms)
            {
                listBoxRooms.Items.Add(room);
                index++;
            }
            listBoxRooms.SelectedIndex = index;
        }

        private void UpdateBuildingSum(Building building)
        {
            if (building == null)
            {
                textBoxBuildingSum.Text = "Building Summary:";
                return;
            }

            // Recalculate totals
            building.totalCost();
            building.totalFurniture();
            building.totalHeight();

            // Build the summary text
            string summary = "Building Summary:" + Environment.NewLine +
                             $"Heigth: {building.Height}" + Environment.NewLine +
                             $"Total Cost: {building.TotCost} €" + Environment.NewLine +
                             $"Total Amount of Furniture: {building.TotFurniture}";

            textBoxBuildingSum.Text = summary;

        }

        private void UpdateFloorSummary(Floor floor)
        {
            if (floor == null)
            {
                textBoxFloorSum.Text = "Floor Summary:";
                return;
            }

            // take the calculations from the Floor class
            double totalCost = floor.CalcTotalCost();
            int totalFurniture = floor.CalcTotFurniture();

            string summary = "Floor Summary:" + Environment.NewLine +
                             $"Total Cost: {totalCost} €" + Environment.NewLine +
                             $"Total Amount of Furniture: {totalFurniture}";

            textBoxFloorSum.Text = summary;
        }

        private void UpdateRoomSum(Room room)
        {
            if (room == null)
            {
                textBoxRoomSum.Text = "Room Summary:";
                return;
            }

            room.CalcLoad();
            room.CalcRoomCost();
            room.CalcSlabVol();

            string summary = "Room Summary:" + Environment.NewLine +
                $"Room Nr.: {room.RoomNr}" + Environment.NewLine +
                $"Area: {room.Area.ToString()} m²" + Environment.NewLine +
                $"Use: {room.Use.ToString()}" + Environment.NewLine +
                $"Load: {room.Load.ToString()} kN/m²" + Environment.NewLine +
                $"Slab Volume: {room.SlabVol.ToString()} m³" + Environment.NewLine +
                $"Concrete Cost: {room.Cost.ToString()} €" + Environment.NewLine +
                "Furniture:" + Environment.NewLine;
            foreach (Furniture furniture in room.Furnitures)
            {
                summary += $" - {furniture.ToString()}" + Environment.NewLine;
            }

            textBoxRoomSum.Text = summary;
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            DialogResult result = saveFileDialog.ShowDialog();
            saveFileDialog.Title = "Export Data";
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            
            if (result == DialogResult.OK) {
                string path = saveFileDialog.FileName;
                Serializer.ExportJSON(path);
                MessageBox.Show("Export Successful!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); 
            DialogResult result = openFileDialog.ShowDialog();
            openFileDialog.Title = "Import Data";
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Filter = "JSON files (*.json)|*.json";

            if (result == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                Serializer.ImportJSON(path);
                FillBuildingListBox();
                FillListBoxFloor(listBoxBuildings.SelectedItem as Building);
                FillListBoxRoom(listBoxFloors.SelectedItem as Floor);
                MessageBox.Show("Import Successful!", "Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
