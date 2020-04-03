﻿namespace ERP.test {
    export interface MovieForm {
        Title: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Storyline: Serenity.StringEditor;
        Year: Serenity.IntegerEditor;
        Releasedate: Serenity.StringEditor;
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
                var w1 = s.IntegerEditor;

                Q.initFormType(MovieForm, [
                    'Title', w0,
                    'Description', w0,
                    'Storyline', w0,
                    'Year', w1,
                    'Releasedate', w0,
                    'Runtime', w1
                ]);
            }
        }
    }
}