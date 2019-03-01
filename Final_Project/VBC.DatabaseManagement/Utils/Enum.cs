using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VBC.DatabaseManagement.Utils
{
    public enum EventStatusEnum
    {
        [Display(Name = "Chưa diễn ra")]
        Waiting = 0,
        [Display(Name = "Đang diễn ra")]
        Processing = 1,
        [Display(Name = "Đã dừng")]
        Stop = 2,
        [Display(Name = "Tạm dừng")]
        Pause = 3
    }

    public enum OrganizationStatusEnum
    {
        [Display(Name = "Disapproved")]
        Disapproved = 0,
        [Display(Name = "Approved")]
        Approved = 1,             
    }
}
