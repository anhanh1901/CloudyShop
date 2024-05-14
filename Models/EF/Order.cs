﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudyShop.Models.EF
{
    [Table("tb_Order")]
    public class Order : CommonAbstract
    {
        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required(ErrorMessage = "Tên khách hàng không được để trống!")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Số điện thoại không được để trống!")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Địa chỉ không được để trống!")]
        public string Email { get; set; }
        public string Address { get; set; }
        public decimal TotalAmount { get; set; }
        public int Quatity { get; set; }
        public int TypePayment { get; set; }
        public string CustomerId { get; set; }
        public int Status { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}