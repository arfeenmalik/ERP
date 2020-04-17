namespace ERP.test {
    export interface PersonRow {
        Personid?: number;
        Firstname?: string;
        Lastname?: string;
        Fullname?: string;
        Birthdate?: string;
        Birthplace?: string;
        Gender?: Gender;
        Height?: number;
        PrimaryImage?: string;
        GalleryImages?: string;
    }

    export namespace PersonRow {
        export const idProperty = 'Personid';
        export const nameProperty = 'Fullname';
        export const localTextPrefix = 'test.Person';
        export const lookupKey = 'test.Person';

        export function getLookup(): Q.Lookup<PersonRow> {
            return Q.getLookup<PersonRow>('test.Person');
        }
        export const deletePermission = 'test:Person:PersonDelete';
        export const insertPermission = 'test:Person:PersonInsert';
        export const readPermission = 'test:Person:PersonRead';
        export const updatePermission = 'test:Person:PersonUpdate';

        export declare const enum Fields {
            Personid = "Personid",
            Firstname = "Firstname",
            Lastname = "Lastname",
            Fullname = "Fullname",
            Birthdate = "Birthdate",
            Birthplace = "Birthplace",
            Gender = "Gender",
            Height = "Height",
            PrimaryImage = "PrimaryImage",
            GalleryImages = "GalleryImages"
        }
    }
}
