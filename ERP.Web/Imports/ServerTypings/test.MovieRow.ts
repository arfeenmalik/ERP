namespace ERP.test {
    export interface MovieRow {
        Movieid?: number;
        Title?: string;
        Description?: string;
        Storyline?: string;
        Year?: number;
        Releasedate?: string;
        Runtime?: number;
        Kind?: MovieKind;
        GenreId?: number;
        GenreName?: string;
    }

    export namespace MovieRow {
        export const idProperty = 'Movieid';
        export const nameProperty = 'Title';
        export const localTextPrefix = 'test.Movie';
        export const lookupKey = 'MovieRow';

        export function getLookup(): Q.Lookup<MovieRow> {
            return Q.getLookup<MovieRow>('MovieRow');
        }
        export const deletePermission = 'test:Movie:MovieDelete';
        export const insertPermission = 'test:Movie:MovieInsert';
        export const readPermission = 'test:Movie:MovieRead';
        export const updatePermission = 'test:Movie:MovieUpdate';

        export declare const enum Fields {
            Movieid = "Movieid",
            Title = "Title",
            Description = "Description",
            Storyline = "Storyline",
            Year = "Year",
            Releasedate = "Releasedate",
            Runtime = "Runtime",
            Kind = "Kind",
            GenreId = "GenreId",
            GenreName = "GenreName"
        }
    }
}
