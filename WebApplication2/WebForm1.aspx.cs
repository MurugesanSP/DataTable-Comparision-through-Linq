using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataSet ds1 = new DataSet();
            ds.ReadXml(@"D:\Books.xml");


            bookgrd.DataSource = ds.Tables[0];
            bookgrd.DataBind();

            IEnumerable<DataRow> tbl1row = ds.Tables[0].AsEnumerable();
            ds1.ReadXml(@"D:\Books2.xml");


            
            IEnumerable<DataRow> tbl2row = ds1.Tables[0].AsEnumerable();
            GridView1.DataSource = ds1.Tables[0];
            GridView1.DataBind();
           
            var items = tbl2row.AsEnumerable().Select(r => r.Field<string>("id"))
        .Except(tbl1row.AsEnumerable().Select(r => r.Field<string>("id")));



            DataTable TableC = (from row in tbl2row.AsEnumerable()
                                join id in items
                                on row.Field<string>("id") equals id
                                select row).CopyToDataTable();

            GridView2.DataSource = TableC;
            GridView2.DataBind();

            
        }
    }
}