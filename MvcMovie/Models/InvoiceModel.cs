using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class InvoiceModel
    {
        [Required]
        [Range(1, 1000, ErrorMessage = "Số lượng phải từ 1 đến 1000")]
        public int Quantity { get; set; }

        [Required]
        [Range(1000, 100000000, ErrorMessage = "Đơn giá phải từ 1,000 đến 100,000,000 VND")]
        public decimal UnitPrice { get; set; }

        // Tính tổng tiền
        public decimal TotalPrice => Quantity * UnitPrice;
    }
}
