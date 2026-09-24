using Microsoft.AspNetCore.Mvc;
using Model.Models;

namespace Model.Controllers
{
    public class CMQMemberController : Controller
    {
        // mốc data
        private static readonly List<CMQmember> _cmqMembers = new List<CMQmember>
        {
            new CMQmember
            {
                CMQMemberID = Guid.NewGuid().ToString(),
                CMQMemberUserName = "quan123",
                CMQMemberPassWord = "Quan@123",
                CMQMemberEmail = "quan@gmail.com",
                CMQMemberFullName = "Chu Quân"
            },

            new CMQmember
            {
                CMQMemberID = Guid.NewGuid().ToString(),
                CMQMemberUserName = "nguyenan",
                CMQMemberPassWord = "An@123",
                CMQMemberEmail = "an@gmail.com",
                CMQMemberFullName = "Nguyễn Văn An"
            },

            new CMQmember
            {
                CMQMemberID = Guid.NewGuid().ToString(),
                CMQMemberUserName = "tranminh",
                CMQMemberPassWord = "Minh@123",
                CMQMemberEmail = "minh@gmail.com",
                CMQMemberFullName = "Trần Minh"
            },

            new CMQmember
            {
                CMQMemberID = Guid.NewGuid().ToString(),
                CMQMemberUserName = "lethao",
                CMQMemberPassWord = "Thao@123",
                CMQMemberEmail = "thao@gmail.com",
                CMQMemberFullName = "Lê Thu Thảo"
            },

            new CMQmember
            {
                CMQMemberID = Guid.NewGuid().ToString(),
                CMQMemberUserName = "phamduc",
                CMQMemberPassWord = "Duc@123",
                CMQMemberEmail = "duc@gmail.com",
                CMQMemberFullName = "Phạm Đức"
            },

            new CMQmember
            {
                CMQMemberID = Guid.NewGuid().ToString(),
                CMQMemberUserName = "hoangnam",
                CMQMemberPassWord = "Nam@123",
                CMQMemberEmail = "nam@gmail.com",
                CMQMemberFullName = "Hoàng Nam"
            },

            new CMQmember
            {
                CMQMemberID = Guid.NewGuid().ToString(),
                CMQMemberUserName = "doanhthu",
                CMQMemberPassWord = "Thu@123",
                CMQMemberEmail = "thu@gmail.com",
                CMQMemberFullName = "Đoàn Anh Thư"
            },

            new CMQmember
            {
                CMQMemberID = Guid.NewGuid().ToString(),
                CMQMemberUserName = "vuminh",
                CMQMemberPassWord = "Minh@123",
                CMQMemberEmail = "vuminh@gmail.com",
                CMQMemberFullName = "Vũ Minh"
            },

            new CMQmember
            {
                CMQMemberID = Guid.NewGuid().ToString(),
                CMQMemberUserName = "danglong",
                CMQMemberPassWord = "Long@123",
                CMQMemberEmail = "long@gmail.com",
                CMQMemberFullName = "Đặng Long"
            },

            new CMQmember
            {
                CMQMemberID = Guid.NewGuid().ToString(),
                CMQMemberUserName = "buihoa",
                CMQMemberPassWord = "Hoa@123",
                CMQMemberEmail = "hoa@gmail.com",
                CMQMemberFullName = "Bùi Ngọc Hoa"
            }
        };
        public IActionResult Index()
        {
            return View(_cmqMembers);
        }
        public IActionResult Create()
        {
            return View();
        }
        // muốn add vào mốc data thì 
        [HttpPost]
        public IActionResult Create(CMQmember cmqmember)
        {
            cmqmember.CMQMemberID = Guid.NewGuid().ToString();
            _cmqMembers.Add(cmqmember);
            return RedirectToAction("Index");
        }
        // tính năng edit
        public IActionResult Edit(string id)
        {
            var cmqMember = _cmqMembers.FirstOrDefault(x=>x.CMQMemberID.Equals(id));
            return View(cmqMember);
        }
        // edit - submit form
        [HttpPost]
        public IActionResult Edit(string id , CMQmember cmqmember)
        {
            for ( int i = 0 ; i < _cmqMembers.Count; i++)
            {
                if(_cmqMembers[i].CMQMemberID == id)
                {
                    _cmqMembers[i].CMQMemberID = cmqmember.CMQMemberID;
                    _cmqMembers[i].CMQMemberUserName = cmqmember.CMQMemberUserName;
                    _cmqMembers[i].CMQMemberPassWord = cmqmember.CMQMemberPassWord;
                    _cmqMembers[i].CMQMemberEmail = cmqmember.CMQMemberEmail;
                    _cmqMembers[i].CMQMemberFullName = cmqmember.CMQMemberFullName;
                    break;
                }
            }
            return RedirectToAction("Index");
        }
        public IActionResult GetDetail()
        {
            var cmqMember = new CMQmember()
            {
                CMQMemberID = Guid.NewGuid().ToString(),
                CMQMemberUserName = "Minh QUân",
                CMQMemberPassWord = "minhquan3004",
                CMQMemberEmail = "mquan304206@gmail.com",
                CMQMemberFullName = "Chu Minh Quân"
            };
            return View(cmqMember);
        }
    }
}
