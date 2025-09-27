using System;
using System.Web;
using CompoundInterestDLL;

public partial class api : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.HttpMethod == "POST")
        {
            double principal = double.Parse(Request.Form["principal"]);
            double rate = double.Parse(Request.Form["rate"]);
            int years = int.Parse(Request.Form["years"]);

            InterestCalculator calculator = new InterestCalculator();
            calculator.Principal = principal;
            calculator.Rate = rate;
            calculator.Years = years;

            string result = calculator.CalculateInterest();

            Response.ContentType = "application/json";
            Response.Write("{ \"result\": \"" + result + "\" }");
            Response.End();
        }
    }
}