using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YLongNieKDam_lab4.Models;

namespace YLongNieKDam_lab4.ViewModels
{
    public class FollowingViewModel
    {
        public IEnumerable<ApplicationUser> Followings { get; set; }
        public bool ShowAction { get; set; }
    }
}