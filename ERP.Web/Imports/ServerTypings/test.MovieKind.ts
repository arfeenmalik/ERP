namespace ERP.test {
    export enum MovieKind {
        Film = 1,
        TvSeries = 2,
        MiniSeries = 3
    }
    Serenity.Decorators.registerEnumType(MovieKind, 'ERP.test.MovieKind', 'test.MovieKind');
}
