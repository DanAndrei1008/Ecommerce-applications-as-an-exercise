﻿namespace Internship.Controllers.Addresses.Models
{
    public class UpdateAddressResult
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public int CountryId { get; set; }

        public int CountyId { get; set; }

        public int CityId { get; set; }

        public string Street { get; set; }

        public string OtherDetails { get; set; }
    }
}
