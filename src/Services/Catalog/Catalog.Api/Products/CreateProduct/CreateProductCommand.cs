using BuildingBlocks.CQRS;
using Catalog.Api.Models;

namespace Catalog.Api.Products.CreateProduct;

public record class CreateProductCommand(string Name, string Description, List<string> Category, string ImageFile, decimal Price)
    : ICommand<CreateProductCommandResponse>;
public record class CreateProductCommandResponse(Guid Id);

internal class CreateProductCommandHandler: ICommandHandler<CreateProductCommand, CreateProductCommandResponse>
{
    public async Task<CreateProductCommandResponse> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        // Map request to entity
        var product = new Product
        {
            Name = command.Name,
            Description = command.Description,
            Category = command.Category,
            ImageFile = command.ImageFile,
            Price = command.Price
        };
        // Save to database
        //using (var context = new CatalogDbContext())
        //{
        //    context.Products.Add(product);
        //    await context.SaveChangesAsync(cancellationToken);
        //}
        // return response
        return new CreateProductCommandResponse(Guid.NewGuid());
    }
}
