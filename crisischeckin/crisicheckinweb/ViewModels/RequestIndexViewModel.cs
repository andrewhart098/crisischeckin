﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using Models;

namespace crisicheckinweb.ViewModels
{
    public class RequestIndexPageViewModel
    {
        public RequestSearch RequestSearch { get; set; }
    }

    public class AdminRequestIndexViewModel : RequestIndexPageViewModel
    {
        public IEnumerable<Request> Requests { get; set; }
    }

    public class VolunteerRequestIndexViewModel
    {
        public IEnumerable<Request> RequestAssignedToVolunteer { get; set; }
        public IEnumerable<Request> OpenRequests { get; set; }

        // Empty Request object used for Razor templates 
        public Request Request { get; set; }
    }

    public class RequestSearch : Request
    {
        [DisplayName("Request Status")]
        public RequestStatus RequestStatus { get; set; }

        public DateTime? NullableEndDate { get; set; }
        public DateTime? NullableCreatedDate { get; set; }
    }

    public enum RequestStatus
    {
        All,
        Unassigned,
        Assigned,
        Completed
    }
}