namespace ERP.test {
    export interface MoviegenresRow {
        Moviegenreid?: number;
        Movieid?: number;
        Genreid?: number;
        MovieidTitle?: string;
        MovieidDescription?: string;
        MovieidStoryline?: string;
        MovieidYear?: number;
        MovieidReleasedate?: string;
        MovieidRuntime?: number;
        MovieidKind?: number;
        GenreidName?: string;
    }

    export namespace MoviegenresRow {
        export const idProperty = 'Moviegenreid';
        export const localTextPrefix = 'test.Moviegenres';
        export const lookupKey = 'MoviegenresRow';

        export function getLookup(): Q.Lookup<MoviegenresRow> {
            return Q.getLookup<MoviegenresRow>('MoviegenresRow');
        }
        export const deletePermission = 'test:Moviegenres:MoviegenresDelete';
        export const insertPermission = 'test:Moviegenres:MoviegenresInsert';
        export const readPermission = 'test:Moviegenres:MoviegenresRead';
        export const updatePermission = 'test:Moviegenres:MoviegenresUpdate';

        export declare const enum Fields {
            Moviegenreid = "Moviegenreid",
            Movieid = "Movieid",
            Genreid = "Genreid",
            MovieidTitle = "MovieidTitle",
            MovieidDescription = "MovieidDescription",
            MovieidStoryline = "MovieidStoryline",
            MovieidYear = "MovieidYear",
            MovieidReleasedate = "MovieidReleasedate",
            MovieidRuntime = "MovieidRuntime",
            MovieidKind = "MovieidKind",
            GenreidName = "GenreidName"
        }
    }
}
