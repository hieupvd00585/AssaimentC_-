namespace BaitapCsah
{
    public class Product
    {
        private string id;
        private string name;
        private string price;

        public Product()
        {
        }

        public Product(string id, string name, string price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public string Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Price
        {
            get => price;
            set => price = value;
        }
    }
}