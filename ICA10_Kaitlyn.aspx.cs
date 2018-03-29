using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;

public partial class ICA10_Kaitlyn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void ShowProd_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        
        if(e.Row==null || e.Row.DataItem == null)
            return;
        DataRowView data = e.Row.DataItem as DataRowView;
        if((short)data["UnitsInStock"] < 25)
        {
            e.Row.BackColor = Color.LightSalmon;
        }
        if ((decimal)data["UnitPrice"] > 25)
        {
            e.Row.Cells[2].BackColor = Color.Yellow;
        }
        if((short)data["UnitsInStock"] < 20 && (short)data["UnitsOnOrder"] < 5)
        {
            e.Row.BackColor = Color.Cyan;
            e.Row.Cells[4].BackColor = Color.GreenYellow;
        }
    }

    protected void EditEmp_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
    }
}