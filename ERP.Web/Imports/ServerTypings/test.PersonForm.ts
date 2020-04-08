namespace ERP.test {
    export interface PersonForm {
        Firstname: Serenity.StringEditor;
        Lastname: Serenity.StringEditor;
        Birthdate: Serenity.DateEditor;
        Birthplace: Serenity.StringEditor;
        Gender: Serenity.EnumEditor;
        Height: Serenity.IntegerEditor;
    }

    export class PersonForm extends Serenity.PrefixedContext {
        static formKey = 'test.Person';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PersonForm.init)  {
                PersonForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;
                var w2 = s.EnumEditor;
                var w3 = s.IntegerEditor;

                Q.initFormType(PersonForm, [
                    'Firstname', w0,
                    'Lastname', w0,
                    'Birthdate', w1,
                    'Birthplace', w0,
                    'Gender', w2,
                    'Height', w3
                ]);
            }
        }
    }
}
