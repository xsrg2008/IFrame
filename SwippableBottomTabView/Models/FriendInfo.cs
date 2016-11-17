using System;

namespace IFrame.Models
{
    public class FriendInfo
    {
        public String Name { get; set; }

        public String Job { get; set; }      //职称

        public String Profession { get; set; }   //科室

        public String Hospital { get; set; }

        public String Goodat { get; set; }

        public String FriendPhoto { get; set; }

        public String Gender { get; set; }

        public String Age { get; set; }

        public String Relationship { get; set; }

        public String Heart { get; set; }

        public String PhoneNumber { get; set; }

        public bool IsFriendInfo { get; set; }

        public bool IsRegister { get; set; }

        public String HosiptalPJob { get { return Hospital +"   "+Job; } }

        public String MayRelation { get { return "可能是你的" + Relationship; } }

        public string Register
        {
            get
            {
                if (IsRegister == true)
                    return "注册用户";
                else return "其他用户完善资料";
            }
        }
    }
}
