using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Copygram.Models
{
    public class Post
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string PictureUrl { get; set; }
    }
}
