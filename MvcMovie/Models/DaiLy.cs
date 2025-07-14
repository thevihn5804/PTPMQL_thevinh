using System.Reflection.Metadata.Ecma335;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models;
[Table("DaiLy")]
public class DaiLy
{
    [Key]
    public string MaDaiLy { get; set; }
    public string TenDaiLy { get; set; }
    public string DiaChi { get; set; }
    public string NguoiDaiDien { get; set; }
    public string DienThoai { get; set; }
    [ForeignKey("HeThongPhanPhoi")]
    public string MaHTPP { get; set; }
    public HeThongPhanPhoi HeThongPhanPhoi { get; set; }
}
