using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsWebServer.Model
{
    public class Post
    {
        public int Id { get; set; }
        public int userId { get; set; }
        public string title { get; set; }
        public string body { get; set; }

        public Post()
        {

        }

        public Post( int userId, string title, string body)
        {
            this.userId = userId;
            this.title = title;
            this.body = body;
        }
    }
}
