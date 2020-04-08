namespace ERP.test {
    export interface MoviecastRow {
        Moviecastid?: number;
        Movieid?: number;
        Personid?: number;
        Character?: string;
        MovieidTitle?: string;
        MovieidDescription?: string;
        MovieidStoryline?: string;
        MovieidYear?: number;
        MovieidReleasedate?: string;
        MovieidRuntime?: number;
        MovieidKind?: number;
        PersonidFirstname?: string;
        PersonidLastname?: string;
        PersonFullname?: string;
        PersonidBirthdate?: string;
        PersonidBirthplace?: string;
        PersonidGender?: number;
        PersonidHeight?: number;
    }

    export namespace MoviecastRow {
        export const idProperty = 'Moviecastid';
        export const nameProperty = 'Character';
        export const localTextPrefix = 'test.Moviecast';
        export const lookupKey = 'MoviecastRow';

        export function getLookup(): Q.Lookup<MoviecastRow> {
            return Q.getLookup<MoviecastRow>('MoviecastRow');
        }
        export const deletePermission = 'test:Moviecast:MoviecastDelete';
        export const insertPermission = 'test:Moviecast:MoviecastInsert';
        export const readPermission = 'test:Moviecast:MoviecastRead';
        export const updatePermission = 'test:Moviecast:MoviecastUpdate';

        export declare const enum Fields {
            Moviecastid = "Moviecastid",
            Movieid = "Movieid",
            Personid = "Personid",
            Character = "Character",
            MovieidTitle = "MovieidTitle",
            MovieidDescription = "MovieidDescription",
            MovieidStoryline = "MovieidStoryline",
            MovieidYear = "MovieidYear",
            MovieidReleasedate = "MovieidReleasedate",
            MovieidRuntime = "MovieidRuntime",
            MovieidKind = "MovieidKind",
            PersonidFirstname = "PersonidFirstname",
            PersonidLastname = "PersonidLastname",
            PersonFullname = "PersonFullname",
            PersonidBirthdate = "PersonidBirthdate",
            PersonidBirthplace = "PersonidBirthplace",
            PersonidGender = "PersonidGender",
            PersonidHeight = "PersonidHeight"
        }
    }
}
