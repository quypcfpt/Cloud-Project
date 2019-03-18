using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VBC.DatabaseManagement.Utils
{
    public enum StoryStatusEnum
    {
        [Display(Name = "Chờ duyệt")]
        Waiting = 0,
        [Display(Name = "Duyệt và hiển thị")]
        Approved = 1,
        [Display(Name = "Từ chối")]
        Disapproved = 2,
    }

    public enum ChapterStatusEnum
    {
        [Display(Name = "Chờ duyệt")]
        Waiting = 0,
        [Display(Name = "Duyệt")]
        Approved = 1,
        [Display(Name = "Từ chối")]
        Disapproved = 2,
    }

    public enum AccountStatusEnum
    {
        [Display(Name = "Chờ xác nhận")]
        Waiting = 0,
        [Display(Name = "Đang hoạt động")]
        Active = 1,
        [Display(Name = "Ngừng hoạt động")]
        Deactive = 2,
    }
}
