namespace MovieDB.MovieData 
{
    @Serenity.Decorators.registerEditor("MovieDB.MovieData.MovieCastEditor")
    export class MovieCastEditor extends Serenity.Extensions.GridEditorBase<MovieCastRow> {
        protected getColunmsKey () { return MovieCastColumns.columnsKey; }
        protected getDialogType () { return MovieCastEditorDialog; }
        protected getLocalTextPrefix () { return MovieCastRow.localTextPrefix; }

        constructor (container: JQuery)
        {
            super(container); 
        }
        
        protected getAddButtonCaption() {
            return "Add";
        }

        protected validateEntity(row: MovieCastRow, id: number) {
            if (!super.validateEntity(row, id)) return false;        

            row.PersonFullName = PersonRow.getLookup().itemById[row.PersonId].FullName;

            return true;
        }
    } 
}