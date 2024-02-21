using MediatR;

namespace Internship.Business.Suppliers.Commands.Update
{
    public class UpdateSupplierCommand : IRequest<string>
    {
        public string Name { get; set; }
        public string NewLocation { get; set; }

        public UpdateSupplierCommand(string name, string newLocation)
        {
            Name = name;
            NewLocation = newLocation;
        }
    }
}
