using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ArquiteturaDemo.Infra.Repositories.EF
{
    public class ContextManager
    {
        private const string Contextkey = "ContextManager.Context";

        public DbContext Context
        {
            get
            {
                if (HttpContext.Current.Items[Contextkey] == null)
                {
                    HttpContext.Current.Items[Contextkey] = new ArquiteturaContext();
                }
                return (ArquiteturaContext)HttpContext.Current.Items[Contextkey];
            }
        }
    }
}
