using Internship.Controllers.Suppliers.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.Suppliers.Commands.Create
{
    public class PostSupplierCommand: IRequest<PostSupplierResult>
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public bool Active { get; set; }

        public PostSupplierCommand(string name, string location, bool active)
        {
            Name = name;
            Location = location;
            Active = active;
        }
    }
}
