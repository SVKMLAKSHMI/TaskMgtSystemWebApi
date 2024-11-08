﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TaskMgtSystemWebApi.Models
{
    public class UserTb
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        [ForeignKey("RoleId")]
        public int RoleId { get; set; }
        public virtual RoleTb? Role_Obj { get; set; }
        
        public virtual ICollection<TaskTb> Tasks { get; set; } = new List<TaskTb>();
    }
}
