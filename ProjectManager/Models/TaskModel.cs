﻿namespace ProjectManager.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<CommentModel> Comments { get; set; } = new List<CommentModel>();
    }

}
