namespace INF1_EX1_Group02.Classes
{
    public class Furniture
    {
        // Define Attributes
        private string type;
        private string id;
        private string levelId;
        private string roomId;

        // Constructors
        public Furniture()
        {
        }
        // Constructors
        public Furniture(string type, string id, string levelId, string roomId)
        {
            this.type = type;
            this.id = id;
            this.levelId = levelId;
            this.roomId = roomId;
        }

        // Define Properties
        public string Type { get => type; set => type = value; }
        public string Id { get => id; set => id = value; }
        public string LevelId { get => levelId; set => levelId = value; }
        public string RoomId { get => roomId; set => roomId = value; }

    }
}
