﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Comment : Post
    {
        public string ReplyId { get; set; }
        public int Indent { get; set; }
    }
}
