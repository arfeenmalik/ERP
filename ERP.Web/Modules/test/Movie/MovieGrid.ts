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

        protected getQuickFilters() {
            let items = super.getQuickFilters();

            var genreListFilter = Q.first(items, x =>
                x.field == MovieRow.Fields.GenreList);

            genreListFilter.handler = h => {
                var request = (h.request as MovieListRequest);
                var values = (h.widget as Serenity.LookupEditor).values;
                request.Genres = values.map(x => parseInt(x, 10));
                h.handled = true;
            };

            return items;
        }

        constructor(container: JQuery) {
            super(container);
        }
    }
}
