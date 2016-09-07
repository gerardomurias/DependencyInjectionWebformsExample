using System;
using System.Web.UI;
using Clases;
using Microsoft.Practices.Unity;

namespace Webforms
{
    public partial class _Default : Page
    {
        [Dependency]
        public IDog Dog { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            int i = 1;

        }
    }
}