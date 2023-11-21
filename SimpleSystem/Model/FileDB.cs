namespace Model
{
    public class FileDB
        : IDB<God>
    {
        private readonly List<God> _gods;
        private readonly string _dbPath;
        public FileDB(string dbPath)
        {
            _gods = new List<God>();
            _dbPath = dbPath;
        }
        ~FileDB()
        {
            SaveFile();
        }
        private static God ConvertGod(string row)
        {
            string[] props = row.Split(new char[] { '|', '@', '|' }, StringSplitOptions.RemoveEmptyEntries);
            return new God(props[0], props[1], int.Parse(props[2]), bool.Parse(props[3]));
        }
        public void LoadFile()
        {
            string[] lines = File.ReadAllLines(_dbPath);
            foreach (string line in lines)
                _gods.Add(ConvertGod(line));
        }
        public void SaveFile()
        {
            File.WriteAllLines(_dbPath, _gods.Select(x => x.ToString()));
        }
        public void Create(God model)
        {
            if (Read(model.Id) != null)
                throw new ArgumentException("The model already exists!");
            _gods.Add(model);
        }
        public void Delete(Guid id)
        {
            God god = Read(id);
            if (god == null)
                throw new ArgumentException("The model does not exist!");
            _gods.Remove(god);
        }
        public God Read(Guid id)
        {
            return _gods.Find(x => x.Id == id);
        }
        public IList<God> ReadAll()
        {
            return _gods;
        }
        public void Update(God model)
        {
            God god = Read(model.Id);
            if (god == null)
                throw new ArgumentException("The model does not exist!");
            god.Name = model.Name;
            god.Mythology = model.Mythology;
            god.ChildrenCount = model.ChildrenCount;
            god.IsImmortal = model.IsImmortal;
        }
    }
}
