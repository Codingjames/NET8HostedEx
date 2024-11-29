﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMgr.Shared
{
    public class Worker
    {
        [Key]
        public int Id { get; set; }
        public string  Name { get; set; }
        
        public string  Tel { get; set; }
        public string Zone { get; set; }  // โซนที่รับงาน
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
