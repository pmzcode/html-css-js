using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PES.App_code
{
    public class POSTPES: IHttpHandler
    {
        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("<html><head><title>POSTPES</title><body>");

    
            foreach (var item in context.Request.Headers.AllKeys)
            {
                context.Response.Write($"<b>{item}</b>{context.Request.Headers[item]}");
                context.Response.Write("<br>");
            }

            foreach (var item in context.Request.Params.AllKeys)
            {
                context.Response.Write($"<b>{item}</b>{context.Request.Params.Get(item)}");
                context.Response.Write("<br>");
            }

        }
    }
}