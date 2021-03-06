﻿using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class chartsubmit : System.Web.UI.Page
{

    private void Page_Load(object Sender, EventArgs e)
    {
        if (!IsPostBack && !GridWebchart.IsPostBack)
        {
            LoadData();


        }
    }
    private void LoadData()
    {
        // Gets the web application's path.
        string path = Server.MapPath("~");
        path = path.Substring(0, path.LastIndexOf("\\"));
        string fileName = path + "\\File\\charttest.xls";

        // Imports from a excel file.
        GridWebchart.ImportExcelFile(fileName);
    }
    protected void submitaction(object sender, EventArgs e)
    {
        GridWebchart.RefreshChartShape();

    }
}
