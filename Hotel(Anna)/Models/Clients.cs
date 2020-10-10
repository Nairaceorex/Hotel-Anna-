using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class Clients
    {
        public long ID { get; set; }
        [Display(Name ="ФИО")]
        public string FIO { get; set; }
        [Display(Name = "Возраст")]
        public int Age { get; set; }
        [Display(Name = "Дата заселения")]
        public DateTime Check_in_date { get; set; }
        [Display(Name = "Дата выезда")]
        public DateTime Check_out_date { get; set; }
        [Display(Name = "Стоимость")]
        public string Price { get; set; }
        [Display(Name = "Паспортные данные")]
        public string Passport_data { get; set; }
        public DbSet<Rooms> ID_Room { get; set; }
        public DbSet<Employee> ID_Employee { get; set; }
        public DbSet<Services> ID_Service1 { get; set; }
        public DbSet<Services> ID_Service2 { get; set; }
        public DbSet<Services> ID_Service3 { get; set; }

    }
}