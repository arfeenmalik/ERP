namespace ERP.test {
    export interface MovieForm {
        Title: Serenity.StringEditor;
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

                Q.initFormType(MovieForm, [
                    'Title', w0
                ]);
            }
        }
    }
}
