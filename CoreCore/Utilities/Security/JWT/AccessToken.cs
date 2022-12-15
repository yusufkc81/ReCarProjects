using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    public class AccessToken
    {
        //Erişim Anahtarı
        public string Token { get; set; }

        //Bitiş Zamaanı
        public DateTime Expiration { get; set; }

    }
}
