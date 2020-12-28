﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLiNhaSach.Models
{
    public class AppUser : IdentityUser
    {

        public AppUser()
        {
            BillApplicationUser = new HashSet<Bill>();
            BillStaff = new HashSet<Bill>();
            DebitDetail = new HashSet<DebitDetail>();
            Receipt = new HashSet<Receipt>();
            Dept = 0;
        }
        public string FullName { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }

        public float Dept { get; set; }

        public virtual ICollection<Bill> BillApplicationUser { get; set; }
        public virtual ICollection<Bill> BillStaff { get; set; }
        public virtual ICollection<DebitDetail> DebitDetail { get; set; }
        public virtual ICollection<Receipt> Receipt { get; set; }


    }
}
