namespace KonSchool_Models
{
    public partial class School
    {
        private string mobilenum;
        public string MobileNum
        {
            get => mobilenum;
            set => mobilenum = value.Contains("+880") ? (value) : (value.StartsWith("0") ? "+88" + value : "+880" + value);
        }

        private int eiin;
        public int EIIN { get => eiin; set => eiin = value; }

        private string name;
        public string Name { get => name; set => name = value; }
        
        private double age;
        public double Age { get => age; set => age = value; }

        private Address location;
        public Address Location { get => location; set => location = value; }

        private double distance;
        public double Distance { get => distance; set => distance = value; }

        private string streetaddr;
        public string StreetAddr { get => streetaddr; set => streetaddr = value; }
        
        private string type; // boys'/girls'/co-ed
        public string Type { get => type; set => type = value; }

        private string level; // ju-sec/sec/hi-sec
        public string Level { get => level; set => level = value; }

        private double[] averAge;
        public double[] AverAge { get => averAge; set => averAge = value; }

        private double smfRatio;
        public double MFRatio { get => smfRatio; set => smfRatio = value; }

        private double tsRatio;
        public double TSRatio { get => tsRatio; set => tsRatio = value; }
        
        private double[] seScore;
        public double[] SEScore { get => seScore; set => seScore = value; }

        private double ses;
        // Stores Area-Score while reading from dataset. Will store actual SES after Query objct modifies the class instance.
        public double SES { get => ses; set => ses = value; }

        private double ads;
        // Actual age difference, stored when Query objct modifies the class instance.
        public double ADS { get => ads; set => ads = value; }

        public double Score { get; internal set; }

        public School(int EIIN) => eiin = EIIN;
    }
}