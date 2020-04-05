namespace ERP.test {

    @Serenity.Decorators.registerClass()
    export class MovieGrid extends Serenity.EntityGrid<MovieRow, any> {
        protected getColumnsKey() { return 'test.Movie'; }
        protected getDialogType() { return MovieDialog; }
        protected getIdProperty() { return MovieRow.idProperty; }
        protected getInsertPermission() { return MovieRow.insertPermission; }
        protected getLocalTextPrefix() { return MovieRow.localTextPrefix; }
        protected getService() { return MovieService.baseUrl; }

        protected getQuickSearchFields(): Serenity.QuickSearchField[] {
            
            return [
                { name: "", title: "all" },
                { name: MovieRow.Fields.Description, title: "description" },
                { name: MovieRow.Fields.Storyline, title: "storyline" },
                { name: MovieRow.Fields.Year, title: "year" }
            ];
        }

        constructor(container: JQuery) {
            super(container);
        }
    }
}
