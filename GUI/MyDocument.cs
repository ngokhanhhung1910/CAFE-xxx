using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestPDF.Fluent; // <-- Thêm using này
using QuestPDF.Helpers; // <-- Thêm using này
using QuestPDF.Infrastructure; // <-- Thêm using này

namespace GUI // <-- Đảm bảo đúng namespace của bạn
{
    // Đây là class định nghĩa tài liệu PDF
    public class MyDocument : IDocument
    {
        // Bạn có thể truyền dữ liệu vào đây, ví dụ:
        // public string TenNguoiDung { get; }
        // public MyDocument(string tenNguoiDung)
        // {
        //    TenNguoiDung = tenNguoiDung;
        // }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
        public DocumentSettings GetSettings() => DocumentSettings.Default;

        // Đây là nơi bạn "vẽ" tài liệu của mình
        public void Compose(IDocumentContainer container)
        {
            container
                .Page(page =>
                {
                    // Thiết lập lề cho trang
                    page.Margin(50);

                    // Header (Đầu trang)
                    page.Header()
                        .Text("Báo Cáo Cafe") // Tiêu đề đầu trang
                        .SemiBold().FontSize(20).FontColor(Colors.Blue.Medium);

                    // Content (Nội dung)
                    page.Content()
                        .Column(col =>
                        {
                            col.Item().Text("Xin chào!"); // Dòng 1
                            col.Item().Text("Đây là file PDF đầu tiên của bạn."); // Dòng 2

                            // Thêm một ít khoảng cách
                            col.Item().PaddingVertical(10);

                            // Bạn có thể dùng Text() để thêm bất cứ thứ gì
                            // Ví dụ: col.Item().Text(TenNguoiDung);

                            col.Item().Text(Placeholders.LoremIpsum()); // Thêm 1 đoạn văn bản mẫu
                        });

                    // Footer (Chân trang)
                    page.Footer()
                        .AlignCenter()
                        .Text(text =>
                        {
                            text.Span("Trang ");
                            text.CurrentPageNumber(); // Tự động thêm số trang
                        });
                });
        }
    }
}