using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzerie.Models
{
    class ObservatiiList
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
