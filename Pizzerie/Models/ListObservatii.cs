using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

 namespace Pizzerie.Models
{
    public class ListObservatii
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [ForeignKey(typeof(ObservatiiList))]
        public int ObservatiiListID { get; set; }
        public int ObservatiiID { get; set; }
    }
}
