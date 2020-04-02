namespace ERP.Northwind {
    export enum Gender {
        Male = 1,
        Female = 2
    }
    Serenity.Decorators.registerEnumType(Gender, 'ERP.Northwind.Gender', 'ERP.Northwind.Entities.Gender');
}
