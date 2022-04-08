namespace MovieDB.MovieData {
    export interface PersonForm {
        FirstName: Serenity.StringEditor;
        Lastname: Serenity.StringEditor;
        Primary_Image: Serenity.ImageUploadEditor;
        Galery_Image: Serenity.MultipleImageUploadEditor;
        BirthDate: Serenity.DateEditor;
        BirthPlace: Serenity.StringEditor;
        Gender: Serenity.EnumEditor;
        Height: Serenity.IntegerEditor;
    }

    export class PersonForm extends Serenity.PrefixedContext {
        static formKey = 'MovieData.Person';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PersonForm.init)  {
                PersonForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.ImageUploadEditor;
                var w2 = s.MultipleImageUploadEditor;
                var w3 = s.DateEditor;
                var w4 = s.EnumEditor;
                var w5 = s.IntegerEditor;

                Q.initFormType(PersonForm, [
                    'FirstName', w0,
                    'Lastname', w0,
                    'Primary_Image', w1,
                    'Galery_Image', w2,
                    'BirthDate', w3,
                    'BirthPlace', w0,
                    'Gender', w4,
                    'Height', w5
                ]);
            }
        }
    }
}
