namespace E_Ticaret.Application.ViewModels.Products
{
    public class VM_Product_Update
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public short UnitsInStock { get; set; }
    }
}