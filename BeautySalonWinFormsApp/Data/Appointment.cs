using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BeautySalonWinFormsApp.Data
{
    public class Appointment
    {
        public int id {  get; set; }

        [ForeignKey(nameof(Client))]
        public int ClientId { get; set; }
        public Client Client { get; set; }

        [ForeignKey(nameof(Master))]
        public int MasterId { get; set; }
        public Master Master { get; set; }

        [ForeignKey(nameof(Service))]
        public int ServiceId { get; set; }
        public Service Service { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public int BookedPrice {  get; set; }

        public string Status { get; set; }

        public string Date { get; set; }
    }
}
