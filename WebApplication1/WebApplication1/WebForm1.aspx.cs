using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
   
    public partial class WebForm1 : System.Web.UI.Page
    {
        IFirebaseClient client;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "IOPdADRVrgptFuHeLnaOrCfcKBwgpNtaszu5WfOt",
            BasePath= "https://aspnet-d6f2e.firebaseio.com/"
        };
        protected void Page_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if(client != null)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
                 
            }
        }
    }
}