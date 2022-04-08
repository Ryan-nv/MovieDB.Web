namespace MovieDB.MovieData
{
    @Serenity.Decorators.registerFormatter ()
    export class GenreListFormatter implements Slick.Formatter
    {
        format(ctx: Slick.FormatterContext){ 
            let idList = ctx.value as number[]; //get the genreId's from movie table
            
            if(!idList || !idList.length) return ""; //if emptu then return null string
        
            let byIdList = GenreRow.getLookup().itemById; //reference the lookupscript from genre row to get genre rows
            
            return idList.map(x => {
                const g = byIdList[x]; //get genreName using the genreId wich used in the movie genre

                if (!g) return x.toString(); //if the genreid doesn't have name attr then return x as a string

                return Q.htmlEncode(g.Name); //return the genrename
            }).join(" | "); //serparator for each genre
        }
    } 
}
