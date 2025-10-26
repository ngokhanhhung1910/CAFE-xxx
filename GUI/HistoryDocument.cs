using DAL.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Collections.Generic;

namespace GUI
{
    public class HistoryDocument : IDocument
    {
        public List<LichSuHoaDon> HistoryList { get; }

        public HistoryDocument(List<LichSuHoaDon> historyList)
        {
            HistoryList = historyList;
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
        public DocumentSettings GetSettings() => DocumentSettings.Default;

        public void Compose(IDocumentContainer container)
        {
            container
                .Page(page =>
                {
                    page.Margin(30);
                    page.Header().Element(ComposeHeader);
                    page.Content().Element(ComposeContent);
                    page.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.Span("Trang ");
                            x.CurrentPageNumber();
                        });
                });
        }

        // --- CÁC HÀM STYLE (Không đổi) ---
        static IContainer HeaderCellStyle(IContainer container)
        {
            return container.BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                            .Padding(5);
        }

        static IContainer BodyCellStyle(IContainer container)
        {
            return container.BorderBottom(1).BorderColor(Colors.Grey.Lighten1)
                            .Padding(5);
        }

        // --- CÁC HÀM VẼ ---
        void ComposeHeader(IContainer container)
        {
            container.Column(column =>
            {
                column.Item().Text(text =>
                {
                    text.Span("BÁO CÁO LỊCH SỬ HÓA ĐƠN")
                        .SemiBold().FontSize(24).FontColor(Colors.Blue.Medium);
                });

                column.Item().Text($"Ngày tạo: {System.DateTime.Now:dd/MM/yyyy HH:mm}")
                    .FontSize(10);

                column.Item().PaddingVertical(10);
            });
        }

        // --- HÀM NỘI DUNG (ĐÃ SỬA) ---
        void ComposeContent(IContainer container)
        {
            container.Table(table =>
            {
                // <-- SỬA ĐỔI 1: Đảo thứ tự 2 cột
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn(3); // Cột Tên Cà Phê
                    columns.RelativeColumn(2); // Cột Số Lượng (món)
                    columns.RelativeColumn(2); // <-- ĐẢO LÊN: Cột Số LƯỢNG Bàn
                    columns.RelativeColumn(2); // <-- ĐẢO XUỐNG: Cột Số Bàn
                    columns.RelativeColumn(2); // Cột Tổng Tiền
                });

                // <-- SỬA ĐỔI 2: Đảo thứ tự 2 tiêu đề
                table.Header(header =>
                {
                    header.Cell().Element(HeaderCellStyle).Text(text => text.Span("Tên Cà Phê").SemiBold());
                    header.Cell().Element(HeaderCellStyle).Text(text => text.Span("Số Lượng").SemiBold());
                    header.Cell().Element(HeaderCellStyle).Text(text => text.Span("SL Bàn").SemiBold());   // <-- ĐẢO LÊN
                    header.Cell().Element(HeaderCellStyle).Text(text => text.Span("Số Bàn").SemiBold()); // <-- ĐẢO XUỐNG
                    header.Cell().Element(HeaderCellStyle).Text(text => text.Span("Tổng Tiền").SemiBold());
                });

                // <-- SỬA ĐỔI 3: Đảo thứ tự 2 cột dữ liệu
                foreach (var item in HistoryList)
                {
                    table.Cell().Element(BodyCellStyle).Text(item.TenCaPhe);
                    table.Cell().Element(BodyCellStyle).Text(item.SoLuong.ToString());
                    table.Cell().Element(BodyCellStyle).Text(item.SoLuongBan.ToString());  // <-- ĐẢO LÊN (Số Lượng Bàn)
                    table.Cell().Element(BodyCellStyle).Text(item.Soban);                     // <-- ĐẢO XUỐNG (Số Bàn)
                    table.Cell().Element(BodyCellStyle).Text(item.TongTien.ToString("N0") + " VND");
                }
            });
        }
    }
}