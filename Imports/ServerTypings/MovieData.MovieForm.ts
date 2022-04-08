namespace MovieDB.MovieData {
    export interface MovieForm {
        Title: Serenity.StringEditor;
        Description: Serenity.TextAreaEditor;
        Storyline: Serenity.TextAreaEditor;
        Primary_Image: Serenity.ImageUploadEditor;
        Galery_Image: Serenity.MultipleImageUploadEditor;
        Year: Serenity.IntegerEditor;
        ReleaseDate: Serenity.DateEditor;
        Runtime: Serenity.IntegerEditor;
        Genres: Serenity.LookupEditor;
        Kind: Serenity.EnumEditor;
    }

    export class MovieForm extends Serenity.PrefixedContext {
        static formKey = 'MovieData.Movie';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MovieForm.init)  {
                MovieForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.TextAreaEditor;
                var w2 = s.ImageUploadEditor;
                var w3 = s.MultipleImageUploadEditor;
                var w4 = s.IntegerEditor;
                var w5 = s.DateEditor;
                var w6 = s.LookupEditor;
                var w7 = s.EnumEditor;

                Q.initFormType(MovieForm, [
                    'Title', w0,
                    'Description', w1,
                    'Storyline', w1,
                    'Primary_Image', w2,
                    'Galery_Image', w3,
                    'Year', w4,
                    'ReleaseDate', w5,
                    'Runtime', w4,
                    'Genres', w6,
                    'Kind', w7
                ]);
            }
        }
    }
}
