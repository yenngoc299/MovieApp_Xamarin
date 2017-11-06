using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MovieApp.Model
{
    public class Token
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Access_token { get; set; }
        public string Error_description { get; set; }
        public DateTime Exprire_date { get; set; }
        public int Expire_in { get; set; }

        public Token(){}
    }
}
 