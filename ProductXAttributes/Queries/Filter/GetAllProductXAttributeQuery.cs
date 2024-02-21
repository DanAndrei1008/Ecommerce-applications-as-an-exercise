using Internship.Data;
using MediatR;

namespace Internship.Business.ProductXAttributes.Queries.Filter
{
    public class GetAllProductXAttributeQuery:IRequest<List<ProductXAttribute>>
    {
    }
}
