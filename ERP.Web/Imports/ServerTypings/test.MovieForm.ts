namespace ERP.test {
    export interface MovieForm {
        Title: Serenity.StringEditor;
        Description: Serenity.StringEditor;
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
                var w1 = MovieCastEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.DateEditor;
                var w4 = s.EnumEditor;
                var w5 = s.LookupEditor;

                Q.initFormType(MovieForm, [
                    'Title', w0,
                    'Description', w0,
                    'CastList', w1,
                    'Storyline', w0,
                    'Year', w2,
                    'Releasedate', w3,
                    'Kind', w4,
                    'GenreList', w5,
                    'Runtime', w2
                ]);
            }
        }
    }
}
