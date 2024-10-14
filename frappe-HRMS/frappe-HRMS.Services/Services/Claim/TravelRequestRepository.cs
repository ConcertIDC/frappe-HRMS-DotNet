﻿using frappe_HRMS.Domain.Claim;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Services.Interfaces.Claim;

namespace frappe_HRMS.Services.Services.Claim
{
    public class TravelRequestRepository : GenericRepository<TravelRequest>, ITravelRequestRepository
    {
        public TravelRequestRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}