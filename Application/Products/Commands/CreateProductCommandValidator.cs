using Application.Common.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Application.Products.Commands
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator(IOnlineStoreDbContext context)
        {
            RuleFor(x => x.NewProduct.Name)
                .NotEmpty()
                .MustAsync(async (productName, cancellation) =>
                {
                    var existingProduct =
                        await context.Products.FirstOrDefaultAsync((x => x.ProductName == productName));
                    return existingProduct == null;
                }).WithMessage("Please specify an unique name");

            RuleFor(x => x.NewProduct.Price).NotEmpty().GreaterThan(0).WithMessage("Please specify an valid value for price"); ;
        }
    }
}
