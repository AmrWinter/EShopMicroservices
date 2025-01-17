using BuildingBlocks.CQRS;

namespace Catalog.Api.Products.CreateProduct;

public record class CreateProductCommand(string Name, string Description, List<string> Category, string ImageFile, decimal Price)
    : ICommand<CreateProductCommandResponse>;
public record class CreateProductCommandResponse(Guid Id);

internal class CreateProductCommandHandler: ICommandHandler<CreateProductCommand, CreateProductCommandResponse>
{
    public async Task<CreateProductCommandResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
