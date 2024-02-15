using System;
using System.Collections.Generic;

using System.Data.Entity;
using System.Linq;
using System.Web;
using Koolitus.Models;

namespace Koolitus.Models
{
    public class KoolitusDBinitializer : CreateDatabaseIfNotExists<KoolitusContext>//DropCreateDatabaseAlways<GuestContext>
    {
        protected override void Seed(KoolitusContext db)
        {
            db.Koolituss.Add(
               new koolitused
               {
                   Koolitusnimetus = "Eesti keel",
                   Koolituskirjeldus ="Õpime eesti keelt",
                   koolitusemaht =12,
                   koolitusehind=100,
                   Opetajaid=1

               });
            base.Seed(db);
        }
    }
}