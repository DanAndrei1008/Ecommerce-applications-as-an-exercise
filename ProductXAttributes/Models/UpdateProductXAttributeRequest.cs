﻿namespace Internship.Controllers.ProductXAttributes.Models
{
    public class UpdateProductXAttributeRequest
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int AttributeId { get; set; }
        public double Value { get; set; }
    }
}
