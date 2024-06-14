using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnastiksalssystem
{
    public class Booking
    {
        private DateTime _date;
        private DateTime _start;
        private DateTime _end;
        private int _hallId;
        private int _id;

        public Booking(DateTime date, DateTime start, DateTime end, int hallId, int id)
        {
            _date = date;
            _start = start;
            _end = end;
            _hallId = hallId;
            Id = id;
        }
        private int Id { get => _id; set => _id = value; }
        private int HallId { get => _hallId; set => _hallId = value; }
        private DateTime Date { get; set; }
        private DateTime Start { get; set; }
        private DateTime End { get; set; }

       

        public void AddBoking(DateTime Start, DateTime End)
        {
            
        }

        public override string ToString()
        {
            return ($"Dato: {Date}, Tidspunkt: {Start}, Sluttidspunkt: {End}, Hall ID: {HallId}, Booking ID: {Id} ");
        }
    }
   
}
    
