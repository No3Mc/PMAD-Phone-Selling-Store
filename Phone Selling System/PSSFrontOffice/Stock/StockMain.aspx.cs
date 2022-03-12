﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSSClasses;

public partial class Stock_StockMain : System.Web.UI.Page
{
    //For quick copy paste StockName, WarehouseNo, Location, Quantity, Barcode

    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStocks();
        }

    }
    void DisplayStocks()
        {
            //create an instance of the county collection
            PSSClasses.clsStockCollection StockBook = new PSSClasses.clsStockCollection();
            //set the data source to the list of warehouse in the collection
            lstStocks.DataSource = StockBook.StockList;
            //set the name of the primary key
            lstStocks.DataValueField = "StockID";
            //set the data field to display
            lstStocks.DataTextField = "WarehouseNo";
            //bind the data to the list
            lstStocks.DataBind();

        }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StockID"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockAdd.aspx");
    }



    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StockID"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockEdit.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StockID"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockDel.aspx");
    }




    //For quick copy paste StockName, WarehouseNo, Location, Quantity, Barcode







    protected void btnApply_Click(object sender, EventArgs e)
    {

    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {

    }



}