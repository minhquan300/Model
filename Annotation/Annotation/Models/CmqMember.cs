using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Annotation.Models
{
    // model class member
    public class CmqMember
    {
        public int ID { get; set; }
        [DisplayName("tài khoản")]
        [Required(ErrorMessage = "tài khoản không được để trống")]
        [StringLength(20,MinimumLength = 6 , ErrorMessage = "Tài khoản có độ dài lớn hơn 20")]
        public string UserName { get; set; }
        [DisplayName("Password")]
        [StringLength(100,MinimumLength = 8,ErrorMessage = " tài khoản tối thiểu 8 kí tự")]
        // kiểm tra định dạng
        [RegularExpression(@"^[A-Z](?=.*\d)(?=.*[a-zA-Z0-9]).+$",ErrorMessage = "Mật khẩu phải bắt đàu bằng một chữ hoa và tối thiểu 1 số và 1 ký tự đặc biệt")]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "email không được để trống")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DisplayName("số điện thoại")]
        [Required(ErrorMessage = "điện thoại không được để trống")]
        [RegularExpression(@"^0\d{9,9}$", ErrorMessage = "điện thoại phải là 10 kí tự số bắt đầu bằng số 0")]
        public string Phone { get; set; }
    }
}
