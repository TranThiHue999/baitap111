using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace baitap111.Models
{
    [Table ("bài1")]
    public class bai1
    {
        [Key]
        public int mã { get; set; }
        public string tên { get; set; }
        //bài 1
    }

}