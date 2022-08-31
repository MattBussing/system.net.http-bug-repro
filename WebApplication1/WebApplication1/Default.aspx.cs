using ClassLibrary1;
using System;
using System.Web.UI;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Class1.DoStuff().Wait();
        }
    }
}