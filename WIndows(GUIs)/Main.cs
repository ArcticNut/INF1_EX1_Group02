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

        }

        private void buttonBuildingDelete_Click(object sender, EventArgs e)
        {

        }
        private void listBoxBuildings_SelectedIndexChanged(object sender, EventArgs e)
        {

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
           //new RoomForm(Floor floor).ShowDialog();
        }

        private void buttonRoomsDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonRoomsEdit_Click(object sender, EventArgs e)
        {

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
        }
        private void buttonManageUses_Click(object sender, EventArgs e)
        {
            new UseForm().ShowDialog();
        }

        private void FillBuildingListBox()
        {

        }

        private void FillFloorListBox(Building building)
        {
        }

        private void FillRoomListBox(Floor floor)
        {
            listBoxRooms.Items.Clear();
            // add all rooms of the Floor to the listBox
            //foreach(Room room in floor.Rooms)
            //{
            //    listBoxRooms.Items.Add(room);
            //}
        }

        private void UpdateBuildingSum(BuildingForm building)
        {

        }

        private void UpdateFloorSum(Floor floor)
        {
        }

        private void UpdateRoomSum(Room room)
        {
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
