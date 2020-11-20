using MediatR;

namespace Application.Products.Commands
{
    public class CreateProductCommand : IRequest<int>
    {
        public CreateProductDto NewProduct { get; set; }
    }
}
