namespace FirstProject {
    internal class Product {
        public string _name;
        public double Price { get; private set; }

        public Product(string name, double price) {
            _name = name;
            Price = price;
        }
    }
}