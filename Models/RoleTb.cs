using System.ComponentModel.DataAnnotations;

namespace TaskMgtSystemWebApi.Models
{
    public class RoleTb
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<UserTb> Users { get; set; }

    }
}
