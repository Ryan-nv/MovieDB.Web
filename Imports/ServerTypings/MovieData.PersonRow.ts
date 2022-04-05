namespace MovieDB.MovieData {
    export interface PersonRow {
        PersonId?: number;
        FullName?: string;
        FirstName?: string;
        Lastname?: string;
        BirthDate?: string;
        BirthPlace?: string;
        Gender?: Gender;
        Height?: number;
    }

    export namespace PersonRow {
        export const idProperty = 'PersonId';
        export const nameProperty = 'FullName';
        export const localTextPrefix = 'MovieData.Person';
        export const lookupKey = 'MovieData.Person';

        export function getLookup(): Q.Lookup<PersonRow> {
            return Q.getLookup<PersonRow>('MovieData.Person');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            PersonId = "PersonId",
            FullName = "FullName",
            FirstName = "FirstName",
            Lastname = "Lastname",
            BirthDate = "BirthDate",
            BirthPlace = "BirthPlace",
            Gender = "Gender",
            Height = "Height"
        }
    }
}
