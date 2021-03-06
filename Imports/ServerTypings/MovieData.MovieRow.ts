namespace MovieDB.MovieData {
    export interface MovieRow {
        MovieId?: number;
        Title?: string;
        Description?: string;
        Storyline?: string;
        Year?: number;
        ReleaseDate?: string;
        Runtime?: number;
        Kind?: number;
        Genres?: number[];
        CastList?: MovieCastRow[];
        Primary_Image?: string;
        Galery_Image?: string;
    }

    export namespace MovieRow {
        export const idProperty = 'MovieId';
        export const nameProperty = 'Title';
        export const localTextPrefix = 'MovieData.Movie';
        export const lookupKey = 'MovieDB.MovieData';

        export function getLookup(): Q.Lookup<MovieRow> {
            return Q.getLookup<MovieRow>('MovieDB.MovieData');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            MovieId = "MovieId",
            Title = "Title",
            Description = "Description",
            Storyline = "Storyline",
            Year = "Year",
            ReleaseDate = "ReleaseDate",
            Runtime = "Runtime",
            Kind = "Kind",
            Genres = "Genres",
            CastList = "CastList",
            Primary_Image = "Primary_Image",
            Galery_Image = "Galery_Image"
        }
    }
}
