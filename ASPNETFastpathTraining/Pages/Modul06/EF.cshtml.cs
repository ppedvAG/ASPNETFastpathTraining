using ASPNETFastpathTraining.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;

namespace ASPNETFastpathTraining.Pages.Modul06
{
    public class EFModel : PageModel
    {

        public void OnGet([FromServices] KundenContext db)
        {
            string par1 = "e";
            // FormattableString sql = $"select name from kunden where name like '%{par1}%' "; //verhinder SQLINjecton
            FormattableString sql = $@"SELECT dbo.Kunde.Name, COUNT(dbo.Auftrag.AuftragId) AS Anzahl
                FROM  dbo.Kunde INNER JOIN
                dbo.Auftrag ON dbo.Kunde.KundeId = dbo.Auftrag.KundeId
                Where name like '%'+{par1}+'%'
                GROUP BY dbo.Kunde.Name ";
            var x = sql.ToString();
            var liste = db.Database.SqlQuery<KundeAuftragCount>(sql).ToList();
           //db.Database.SqlQueryRaw
            var liste2 = db.Set<KundeAuftragCount>().FromSqlInterpolated<KundeAuftragCount>(sql).ToList();
            var liste3 = db.Set<KundeAuftragCount>().FromSql<KundeAuftragCount>(sql).ToList();

           // var liste3 = db.Set<KundeAuftragCount>().<KundeAuftragCount>(sql).ToList();
        }
    }
    [Keyless]
    public class KundeAuftragCount
    {
        public string Name { get; set; }
        public int Anzahl { get; set; }
    }
}
