﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSSClasses;

public partial class _Default : System.Web.UI.Page
{
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
            PSSClasses.clsStockCollection Stocks = new PSSClasses.clsStockCollection();
            //set the data source to the list of warehouse in the collection
            lstStocks.DataSource = Stocks.StockList;
            //set the name of the primary key
            lstStocks.DataValueField = "StockID";
            //set the data field to display
            lstStocks.DataTextField = "WarehouseNo";
            //bind the data to the list
            lstStocks.DataBind();
        }
    }
