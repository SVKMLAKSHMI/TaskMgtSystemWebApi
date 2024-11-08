using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskMgtSystemWebApi.Models
{
    public class TaskTb
    {
        [Key]
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public virtual UserTb? UserObj { get; set; }

        [ForeignKey("ProjectId")]
        public int ProjectId { get; set; }
        public virtual ProjectTb? ProjectObj { get; set; }

    }
}
