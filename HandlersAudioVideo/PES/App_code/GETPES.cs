using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PES.App_code
{
    public class GETPES : IHttpHandler
    {
        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            context.Response.AddHeader("X-PES", "Egor Pomazai");

            context.Response.Write("<html><head><title>GETPES</title>");
            context.Response.Write("<head><link rel = \"stylesheet\" href = \"css1pes.css\" />");
            context.Response.Write("<link rel = \"stylesheet\" href = \"css2pes.css\" />");
            context.Response.Write($"<p>param value is {context.Request.Params.Get("getPESparm")}</p>");
            context.Response.Write("<script src=\"js1pes.js\"></script>");
            context.Response.Write("<script src=\"js2pes.js\"></script>");
            context.Response.Write("<a class=\"a\" href=\"htmlpes.html\">HTML</a>");
            context.Response.Write("<br/><img class=\"img\" src = \"imgpes.jpg\" />");
            context.Response.Write("<form method=\"post\" action=\"post.pes\"><input type=\"text\" name=\"postparm\"/>");
            context.Response.Write("<input type = \"submit\" /></form>");
            context.Response.Write("<br/><video width=\"400\" height=\"300\" controls=\"controls\"><source src=\"cats.mp4\" type='video/mp4; codecs=\"avc1.42E01E, mp4a.40.2\"'></video>");
            context.Response.Write("<br/><audio controls><source src = \"tears.mp3\" type = \"audio/mpeg\"></audio>");

        }
    }
}