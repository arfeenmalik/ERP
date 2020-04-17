namespace ERP.test {
    export interface MovieForm {
        Title: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        PrimaryImage: Serenity.ImageUploadEditor;
        GalleryImages: Serenity.MultipleImageUploadEditor;
        CastList: MovieCastEditor;
        Storyline: Serenity.StringEditor;
        Year: Serenity.IntegerEditor;
        Releasedate: Serenity.DateEditor;
        Kind: Serenity.EnumEditor;
        GenreList: Serenity.LookupEditor;
        Runtime: Serenity.IntegerEditor;
    }

    export class MovieForm extends Serenity.PrefixedContext {
        static formKey = 'test.Movie';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MovieForm.init)  {
                MovieForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.ImageUploadEditor;
                var w2 = s.MultipleImageUploadEditor;
                var w3 = MovieCastEditor;
                var w4 = s.IntegerEditor;
                var w5 = s.DateEditor;
                var w6 = s.EnumEditor;
                var w7 = s.LookupEditor;

                Q.initFormType(MovieForm, [
                    'Title', w0,
                    'Description', w0,
                    'PrimaryImage', w1,
                    'GalleryImages', w2,
                    'CastList', w3,
                    'Storyline', w0,
                    'Year', w4,
                    'Releasedate', w5,
                    'Kind', w6,
                    'GenreList', w7,
                    'Runtime', w4
                ]);
            }
        }
    }
}
