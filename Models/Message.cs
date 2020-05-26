﻿namespace Global_Intern.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public User MessageFrom { get; set; }
        public User MessageTo { get; set; }

        public string MessageTitle { get; set; }
        public string MessageContent { get; set; }
        public bool MessageRead { get; set; }

        public InternStudent InternStudent { get; set;}
    }
}
