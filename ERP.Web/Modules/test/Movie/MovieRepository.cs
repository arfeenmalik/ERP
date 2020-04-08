
namespace ERP.test.Repositories
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System;
    using System.Data;
    using MyRow = Entities.MovieRow;

    public class MovieRepository
    {
        private static MyRow.RowFields fld { get { return MyRow.Fields; } }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MySaveHandler().Process(uow, request, SaveRequestType.Create);
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MySaveHandler().Process(uow, request, SaveRequestType.Update);
        }

        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MyDeleteHandler().Process(uow, request);
        }

        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRetrieveHandler().Process(connection, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, MovieListRequest request)
        {
            return new MyListHandler().Process(connection, request);
        }

        private class MySaveHandler : SaveRequestHandler<MyRow> {
            protected override void AfterSave()
            {
                base.AfterSave();

                if (Row.CastList != null)
                {
                    var mc = Entities.MoviecastRow.Fields;
                    var oldList = IsCreate ? null :
                        Connection.List<Entities.MoviecastRow>(
                            mc.Movieid == this.Row.Movieid.Value);

                    new Common.DetailListSaveHandler<Entities.MoviecastRow>(
                        oldList, Row.CastList,
                        x => x.Movieid = Row.Movieid.Value).Process(this.UnitOfWork);
                }
            }


        }
        private class MyDeleteHandler : DeleteRequestHandler<MyRow> {
            protected override void OnBeforeDelete()
            {
                base.OnBeforeDelete();

                var mc = Entities.MoviecastRow.Fields;
                foreach (var detailID in Connection.Query<Int32>(
                    new SqlQuery()
                        .From(mc)
                        .Select(mc.Moviecastid)
                        .Where(mc.Movieid == Row.Movieid.Value)))
                {
                    new DeleteRequestHandler<Entities.MoviecastRow>().Process(this.UnitOfWork,
                        new DeleteRequest
                        {
                            EntityId = detailID
                        });
                }
            }
        }
        private class MyRetrieveHandler : RetrieveRequestHandler<MyRow> {
            protected override void OnReturn()
            {
                base.OnReturn();

                var mc = Entities.MoviecastRow.Fields;
                Row.CastList = Connection.List<Entities.MoviecastRow>(q => q
                    .SelectTableFields()
                    .Select(mc.PersonFullname)
                    .Where(mc.Movieid == Row.Movieid.Value));
            }
        }
      //  private class MyListHandler : ListRequestHandler<MyRow> { }
        private class MyListHandler : ListRequestHandler<MyRow, MovieListRequest> {
            protected override void ApplyFilters(SqlQuery query)
            {
                base.ApplyFilters(query);

                if (!Request.Genres.IsEmptyOrNull())
                {
                    var mg = Entities.MoviegenresRow.Fields.As("mg");

                    query.Where(Criteria.Exists(
                        query.SubQuery()
                            .From(mg)
                            .Select("1")
                            .Where(
                                mg.Movieid == fld.Movieid &&
                                mg.Genreid.In(Request.Genres))
                            .ToString()));
                }
            }

        }

    }
}