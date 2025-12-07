using System.Text.Json;
using System.Text.Json.Serialization;

namespace INF1_EX1_Group02.Classes
{
    public static class Serializer
    {
        private class SerializationContainer
        {
            public List<Use> Uses { get; set; }
            public List<Building> Buildings { get; set; }
        }

        // Configure JsonSerializer options
        private static JsonSerializerOptions GetOptions() => new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true,
            IncludeFields = true,
            ReferenceHandler = ReferenceHandler.Preserve
        };

        public static void ExportJSON(string path)
        {
            // Safe the data in a container object
            var data = new SerializationContainer
            {
                Uses = AppData.Uses,
                Buildings = AppData.Buildings
            };

            // Serialization
            string json = JsonSerializer.Serialize(data, GetOptions());

            File.WriteAllText(path, json);
        }

        public static void ImportJSON(string path) {
            
            string json = File.ReadAllText(path);

            using JsonDocument doc = JsonDocument.Parse(json);
            JsonElement root = doc.RootElement;

            // map json $id -> Use instance
            var idToUse = new Dictionary<string, Use>();

            // Clear existing data
            AppData.Uses.Clear();
            AppData.Buildings.Clear();

            // Read Uses
            if (root.TryGetProperty("Uses", out JsonElement usesProp)
                && usesProp.TryGetProperty("$values", out JsonElement usesArray))
            {
                foreach (JsonElement useEl in usesArray.EnumerateArray())
                {
                    string jsonId = useEl.GetProperty("$id").GetString()!;
                    string name = useEl.GetProperty("Name").GetString() ?? string.Empty;
                    double qk = useEl.GetProperty("Qk").GetDouble();

                    var use = new Use(name, qk);
                    idToUse[jsonId] = use;
                    AppData.Uses.Add(use);
                }
            }

            // Read Buildings -> Floors -> Rooms
            if (root.TryGetProperty("Buildings", out JsonElement buildingsProp)
                && buildingsProp.TryGetProperty("$values", out JsonElement buildingsArray))
            {
                foreach (JsonElement bEl in buildingsArray.EnumerateArray())
                {
                    string name = bEl.GetProperty("Name").GetString() ?? string.Empty;
                    double area = bEl.GetProperty("Area").GetDouble();
                    double costPerCubicMeter = bEl.GetProperty("CostPerCubicMeter").GetDouble();

                    var building = new Building(name, area, costPerCubicMeter);
                    AppData.Buildings.Add(building);

                    // floors if the building
                    if (bEl.TryGetProperty("Floors", out JsonElement floorsProp)
                        && floorsProp.TryGetProperty("$values", out JsonElement floorsArray))
                    {
                        foreach (JsonElement fEl in floorsArray.EnumerateArray())
                        {
                            int level = fEl.GetProperty("Level").GetInt32();
                            double height = fEl.GetProperty("Height").GetDouble();

                            var floor = new Floor(level, height);
                            building.Floors.Add(floor);

                            //rooms  of the floor
                            if (fEl.TryGetProperty("Rooms", out JsonElement roomsProp)
                                && roomsProp.TryGetProperty("$values", out JsonElement roomsArray))
                            {
                                foreach (JsonElement rEl in roomsArray.EnumerateArray())
                                {
                                    string roomNr = rEl.GetProperty("RoomNr").GetString() ?? string.Empty;
                                    double rArea = rEl.GetProperty("Area").GetDouble();
                                    double slabThickness = rEl.GetProperty("SlabThickness").GetDouble();

                                    // Resolve Use: either a $ref or an inline object with $id
                                    Use? roomUse = null;
                                    if (rEl.TryGetProperty("Use", out JsonElement useProp))
                                    {
                                        if (useProp.ValueKind == JsonValueKind.Object && useProp.TryGetProperty("$ref", out JsonElement refEl))
                                        {
                                            string refId = refEl.GetString()!;
                                            idToUse.TryGetValue(refId, out roomUse);
                                        }
                                        else if (useProp.ValueKind == JsonValueKind.Object && useProp.TryGetProperty("$id", out JsonElement inlineIdEl))
                                        {
                                            // inline Use object: create and map
                                            string inlineId = inlineIdEl.GetString()!;
                                            string uname = useProp.GetProperty("Name").GetString() ?? string.Empty;
                                            double uqk = useProp.GetProperty("Qk").GetDouble();
                                            roomUse = new Use(uname, uqk);
                                            idToUse[inlineId] = roomUse;
                                            AppData.Uses.Add(roomUse);
                                        }
                                    }

                                    // fallback if Use not found
                                    if (roomUse == null)
                                        roomUse = AppData.Uses.FirstOrDefault();

                                    var room = new Room(roomNr, rArea, roomUse!, slabThickness, building);

                                    // Furnitures ($values array)
                                    if (rEl.TryGetProperty("Furnitures", out JsonElement furnProp)
                                        && furnProp.TryGetProperty("$values", out JsonElement furnArray))
                                    {
                                        foreach (JsonElement f in furnArray.EnumerateArray())
                                        {
                                            string type = f.GetProperty("Type").GetString() ?? string.Empty;
                                            int amount = f.GetProperty("Amount").GetInt32();
                                            room.Furnitures.Add(new Furniture(type, amount));
                                        }
                                    }

                                    floor.Rooms.Add(room);
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
