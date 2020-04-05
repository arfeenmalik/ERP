namespace ERP.test {
    export interface GenreRow {
        Genreid?: number;
        Name?: string;
    }

    export namespace GenreRow {
        export const idProperty = 'Genreid';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'test.Genre';
        export const lookupKey = 'test.Genre';

        export function getLookup(): Q.Lookup<GenreRow> {
            return Q.getLookup<GenreRow>('test.Genre');
        }
        export const deletePermission = 'test:Genre:GenreDelete';
        export const insertPermission = 'test:Genre:GenreInsert';
        export const readPermission = 'test:Genre:GenreRead';
        export const updatePermission = 'test:Genre:GenreUpdate';

        export declare const enum Fields {
            Genreid = "Genreid",
            Name = "Name"
        }
    }
}
