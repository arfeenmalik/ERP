
namespace ERP.test {

    @Serenity.Decorators.registerClass()
    export class PersonMovieGrid extends Serenity.EntityGrid<MoviecastRow, any>
    {
        protected getColumnsKey() { return "test.PersonMovie"; }
        protected getIdProperty() { return MoviecastRow.idProperty; }
        protected getLocalTextPrefix() { return MoviecastRow.localTextPrefix; }
        protected getService() { return MoviecastService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getButtons() {
            return [];
        }

        protected getInitialTitle() {
            return null;
        }

        protected usePager() {
            return false;
        }

        protected getGridCanLoad() {
            return this.personID != null;
        }

        private _personID: number;

        get personID() {
            return this._personID;
        }


        set personID(value: number) {
            if (this._personID != value) {
                this._personID = value;
                this.setEquality(MoviecastRow.Fields.Personid, value);
                this.refresh();
            }
        }
    }
}