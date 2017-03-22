using System;
using System.ComponentModel.DataAnnotations;

namespace RepairShop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderDate { get; set; }
        public string DeviceBrand { get; set; }
        public string DeviceSerialNumber { get; set; }
        public string DeviceCondition { get; set; }
        public string ProblemInfo { get; set; }
        public int ClientId { get; set; }
    }
}