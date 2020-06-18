using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using YLongNieKDam_lab4.Models;

namespace YLongNieKDam_lab4.DTOs
{
    public class FollowingDto
    {
        [Key]
        [Column(Order=1)]
        public string FollowerId { get; set; }
        [Key]
        [Column(Order=2)]
        public string FolloweeId { get; set; }
        public ApplicationUser Follower { get; set; }
        public ApplicationUser Followee { get; set; }
    }
}