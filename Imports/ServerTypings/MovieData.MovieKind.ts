namespace MovieDB.MovieData {
    export enum MovieKind {
        Film = 1,
        TVSeries = 2,
        MiniSeries = 3
    }
    Serenity.Decorators.registerEnumType(MovieKind, 'MovieDB.MovieData.MovieKind', 'MovieDB.MovieKind');
}
