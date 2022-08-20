namespace resturant.productApi.Models
{
    public class ProductDto  //class wont go to DB, we create it to deal with ApiReq.
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string ImgUrl { get; set; }
    }
}
