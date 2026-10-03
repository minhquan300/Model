using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BTHLab2.Models
{
    public class CmqAccount
    {
        [Key]
        public int Id { get; set; }
        [
            Display(Name ="Họ và Tên") ,
            Required(ErrorMessage = "họ tên không được để trống"),
            MinLength(6 , ErrorMessage = " họ tên không được ít hơn 6 kí tự"),
            MaxLength(20, ErrorMessage = " họ tên không được vượt quá 20 kí tự")
        ]
        public string FullName { get; set; }
        [
            Display(Name = "địa chỉ email"),
            Required(ErrorMessage ="email không được để trống"),
            EmailAddress(ErrorMessage = "địa chỉ email không đúng định dạng"),
            DataType(DataType.EmailAddress)
        ]
        public string Email { get; set; }
        [Display(Name = "Số điện thoại")]
        [DataType(DataType.PhoneNumber)]
        [Remote(action: "VerifyPhone", controller: "cmqAccount")]
        [Required(ErrorMessage = "Điện thoại không được để trống")]
        public string Phone { get; set; }
        [Display(Name = "Địa chỉ thường trú")]
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        [StringLength(35, ErrorMessage = "Địa chỉ không vượt quá 35 ký tự")]
        public string Address { get; set; }
        [Display(Name = "Ảnh đại diện")]
        public string Avatar { get; set; }
        [Display(Name = "Ngày sinh")]
        [Required(ErrorMessage = "Ngày sinh không được để trống")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        [Display(Name = "Giới tính")]
        public string Gender { get; set; }
        [Display(Name = "Mật khẩu")]
        [RegularExpression(@"^[A-Z](?=.*\d)(?=.*[a-zA-Z0-9]).+$",ErrorMessage = "Mật khẩu phải bắt đàu bằng một chữ hoa và tối thiểu 1 số và 1 ký tự đặc biệt")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Link Facebook cá nhân")]
        [Required(ErrorMessage = "Link Facebook không được để trống")]
        [Url(ErrorMessage = "Url phải đúng định dạng bao gồm http hoặc https, tên miền VD: https://facebook.com/itvnsoft")]
        public string Facebook { get; set; }
    }
}
