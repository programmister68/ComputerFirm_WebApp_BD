﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ComputerFirm.Data;
using Computerfirm.Models;

namespace ComputerFirm.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly ComputerFirm.Data.ComputerFirmContext _context;

        public IndexModel(ComputerFirm.Data.ComputerFirmContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; }
        public IList<Customer> Customer { get;set; }
        public IList<Staff> Staff { get;set; }
        public IList<Component> Component { get;set; }
        public IList<Service> Service { get;set; }

        public async Task OnGetAsync()
        {
            Order = await _context.Order.ToListAsync();
            Customer = await _context.Customer.ToListAsync();
            Staff = await _context.Staff.ToListAsync();
            Service = await _context.Service.ToListAsync();
        }
    }
}
