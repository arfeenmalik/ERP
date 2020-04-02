namespace ERP.Northwind {
    export enum OrderShippingState {
        NotShipped = 0,
        Shipped = 1
    }
    Serenity.Decorators.registerEnumType(OrderShippingState, 'ERP.Northwind.OrderShippingState', 'Northwind.OrderShippingState');
}
