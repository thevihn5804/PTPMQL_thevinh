using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace MvcMovie.Models;

public class HeThongPhanPhoi
{
    [Key]
    public string MaHTPP { get; set; }
    [Required(ErrorMessage = "Tên hệ thống phân phối không được để trống")]
    public string TenHTPP { get; set; }
    public ICollection<DaiLy> DaiLy { get; set; }
}
