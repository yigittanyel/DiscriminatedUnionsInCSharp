using DiscriminatedUnionsInCSharp.Enums;
using DiscriminatedUnionsInCSharp.Models;
using OneOf;

namespace DiscriminatedUnionsInCSharp.Services;

public interface IOrdersService
{
    OneOf<Receipt, PlaceOrderError> PlaceOrder(Order order);
}
