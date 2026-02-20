using EcommerceDev.Application.Common;

namespace EcommerceDev.Application.Commands.Orders.CreateOrder;

public class CreateOrderCommandHandler
    : IHandler<CreateOrderCommand, ResultViewModel<Guid>>
{
    public Task<ResultViewModel<Guid>> HandleAsync(CreateOrderCommand request)
    {
        throw new NotImplementedException();
    }
}