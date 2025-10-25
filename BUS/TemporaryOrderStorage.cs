using System.Collections.Generic;

public static class TemporaryOrderStorage
{
    public static List<OrderItem> CurrentOrder { get; set; } = new List<OrderItem>();
    public static decimal TongTien { get; set; } = 0;
}

public class OrderItem
{
    public string TenCaPhe { get; set; }
    public int SoLuong { get; set; }
    public decimal DonGia { get; set; }
    public decimal ThanhTien { get; set; }
}
