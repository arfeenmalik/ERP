/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace ERP.test {
    @Serenity.Decorators.registerEditor()
    export class MovieCastEditor
        extends Common.GridEditorBase<MoviecastRow> {
       
        protected getColumnsKey() { return "test.Moviecast"; }
        protected getDialogType() { return MovieCastEditDialog; }
        protected getLocalTextPrefix() { return MoviecastRow.localTextPrefix; }

        protected validateEntity(row: MoviecastRow, id: number) {
            if (!super.validateEntity(row, id))
                return false;

            row.PersonFullname = PersonRow.getLookup()
                .itemById[row.Personid].Fullname;

            return true;
        }        

        constructor(container: JQuery) {
            super(container);
        }

        protected getAddButtonCaption() {
            return "Add";
        }
    }
}