namespace ERP.test {
    export interface MoviecastForm {
        Personid: Serenity.LookupEditor;
        Character: Serenity.StringEditor;
    }

    export class MoviecastForm extends Serenity.PrefixedContext {
        static formKey = 'test.Moviecast';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MoviecastForm.init)  {
                MoviecastForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;

                Q.initFormType(MoviecastForm, [
                    'Personid', w0,
                    'Character', w1
                ]);
            }
        }
    }
}
