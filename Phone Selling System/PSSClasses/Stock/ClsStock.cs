﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
//Written by Syed || P2652259 || No3Mc(https://github.com/No3Mc)
//Repository Link : https://github.com/No3Mc/PMAD-Phone-Selling-Store

namespace PSSClasses
{
    public class clsStock
    {
        public bool Active;
        private int NStockID;
        private string NStockName;
        private string NWarehouseNo;
        private string NLocation;
        private string NQuantity;
        private string NBarcode;


        public int StockID
        {
            get
            {
                //this line of code send data out of the property
                return NStockID;
            }
            set
            {
                //this line of code allows data into the property
                NStockID = value;
            }

        }

        public bool Find(int StockID)
        {
            //create an instance of the data connectin
            clsDataConnection DB = new clsDataConnection();
            //add the parametrs for the Stock to search for it
            DB.AddParameter("@StockID", StockID);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByStockID");


            //if one record if found (there should either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                NStockID = Convert.ToInt32(DB.DataTable.Rows[0]["StockID"]);
                NStockName = Convert.ToString(DB.DataTable.Rows[0]["StockName"]);
                NWarehouseNo = Convert.ToString(DB.DataTable.Rows[0]["WarehouseNo"]);
                NLocation = Convert.ToString(DB.DataTable.Rows[0]["Location"]);
                NQuantity = Convert.ToString(DB.DataTable.Rows[0]["Quantity"]);
                NBarcode = Convert.ToString(DB.DataTable.Rows[0]["Barcode"]);

                //return everyting worked OK
                return true;
            }

            //if no records was found
            else
            {
                //return false indicating a problem
                return false;
            }

        }



        //    //if (string.IsNullOrEmpty(StockName))
        //    //{
        //    //    throw new ArgumentException($"'{nameof(StockName)}' cannot be null or empty.", nameof(StockName));
        //    //}
        //    //if (string.IsNullOrEmpty(WarehouseNo))
        //    //{
        //    //    throw new ArgumentException($"'{nameof(WarehouseNo)}' cannot be null or empty.", nameof(WarehouseNo));
        //    //}
        //    //if (string.IsNullOrEmpty(Location))
        //    //{
        //    //    throw new ArgumentException($"'{nameof(Location)}' cannot be null or empty.", nameof(Location));
        //    //}
        //    //if (string.IsNullOrEmpty(Quantity))
        //    //{
        //    //    throw new ArgumentException($"'{nameof(Quantity)}' cannot be null or empty.", nameof(Quantity));
        //    //}
        //    //if (string.IsNullOrEmpty(Barcode))
        //    //{
        //    //    throw new ArgumentException($"'{nameof(Barcode)}' cannot be null or empty.", nameof(Barcode));
        //    //}





        public string Valid(string StockName, string WarehouseNo, string Location, string Quantity, string Barcode)
        {
            //create a string variable to store the error
            String Error = "";

            //if the StockName is blank
            if (StockName.Length == 0)
            {
                //record the error
                Error += "The StockName may not be blank    ";

            }
            //if the StockName is greater than 6 characters
            if (StockName.Length > 50)
            {
                //record the error
                Error += "The StockName must be less than 6 characters    ";

            }
            //is the WarehouseNo blank
            if (WarehouseNo.Length == 0)
            {
                //record the error
                Error += "The WarehouseNo may not be blank    ";

            }
            //if the WarehouseNo is too long
            if (WarehouseNo.Length > 50)
            {
                //record the error
                Error += "The WarehouseNo must be less than 9 characters    ";

            }
            //is the Location blank
            if (Location.Length == 0)
            {
                //record the error
                Error += "The Location may not be blank    ";

            }
            //if the Location is too long
            if (Location.Length > 50)
            {
                //record the error
                Error += "The Location must be less than 50 characters    ";

            }
            //is the Quantity blank
            if (Quantity.Length == 0)
            {
                //record the error
                Error += "The Quantity may not be blank    ";

            }
            //if the Quantity is too long
            if (Quantity.Length > 50)
            {
                //record the error
                Error += "The Quantity must be less than 50 characters    ";

            }
            //is the Barcode blank
            if (Barcode.Length == 0)
            {
                //record the error
                Error += "The Barcode may not be blank    ";

            }
            //if the Barcode is too long
            if (Barcode.Length > 50)
            {
                //record the error
                Error += "The Barcode may not be blank    ";

            }
            //return any error messages
            return Error;

        }

        public string ValidStocknmlbl(string StockName)
        {
            String Stocknmlbl = "";

            //if the StockName is blank
            if (StockName.Length == 0)
            {
                //record the error
                Stocknmlbl += "The StockName may not be blank    ";

            }
            //if the StockName is greater than 6 characters
            if (StockName.Length > 50)
            {
                //record the error
                Stocknmlbl += "The StockName must be less than 6 characters    ";

            }
            return Stocknmlbl;

        }

        public string Validwarehnolbl(string WarehouseNo)
            {
                String warehnolbl = "";

                //is the WarehouseNo blank
                if (WarehouseNo.Length == 0)
            {
                //record the error
                warehnolbl += "The WarehouseNo may not be blank    ";

            }
            //if the WarehouseNo is too long
            if (WarehouseNo.Length > 50)
            {
                //record the error
                warehnolbl += "The WarehouseNo must be less than 9 characters    ";

            }

            return warehnolbl;

        }
        public string Validlocalbl(string Location)
            {
            String localbl = "";

            //is the Location blank
            if (Location.Length == 0)
            {
                //record the error
                localbl += "The Location may not be blank    ";

            }
            //if the Location is too long
            if (Location.Length > 50)
            {
                //record the error
                localbl += "The Location must be less than 50 characters    ";

            }

            return localbl;

        }
        public string Validqualilbl(string Quantity)
            {
            String qualilbl = "";

            //is the Quantity blank
            if (Quantity.Length == 0)
            {
                //record the error
                qualilbl += "The Quantity may not be blank    ";

            }
            //if the Quantity is too long
            if (Quantity.Length > 50)
            {
                //record the error
                qualilbl += "The Quantity must be less than 50 characters    ";

            }

            return qualilbl;

        }
        public string Validbarclbl(string Barcode)
            {
            String barclbl = "";
            //is the Barcode blank
            if (Barcode.Length == 0)
            {
                //record the error
                barclbl += "The Barcode may not be blank    ";

            }
            //if the Barcode is too long
            if (Barcode.Length > 50)
            {
                //record the error
                barclbl += "The Barcode may not be blank    ";

            }
            //return any error messages

            return barclbl;
        }


        public string StockName
        {
            get
            {
                //this line of code send data out of the property
                return NStockName;
            }
            set
            {
                //this line of code allows data into the property
                NStockName = value;
            }

        }


        public string WarehouseNo
        {
            get
            {
                //this line of code send data out of the property
                return NWarehouseNo;
            }
            set
            {
                //this line of code allows data into the property
                NWarehouseNo = value;
            }

        }


        public string Location
        {
            get
            {
                //this line of code send data out of the property
                return NLocation;
            }
            set
            {
                //this line of code allows data into the property
                NLocation = value;
            }

        }


        public string Quantity
        {
            get
            {
                //this line of code send data out of the property
                return NQuantity;
            }
            set
            {
                //this line of code allows data into the property
                NQuantity = value;
            }

        }


        public string Barcode
        {
            get
            {
                //this line of code send data out of the property
                return NBarcode;
            }
            set
            {
                //this line of code allows data into the property
                NBarcode = value;
            }

        }



        public bool List()
        {
            //always return true
            return true;
        }




        //public string Valid(string StockName)
        //{
        //    String Stocknmlbl = "";
        //    if (StockName.Length == 0)
        //    {
        //        //record the error
        //        Stocknmlbl += "The StockName may not be blank    ";
        //    }
        //    //if the StockName is greater than 6 characters
        //    if (StockName.Length > 50)
        //    {
        //        //record the error
        //        Stocknmlbl += "The StockName must be less than 6 characters    ";
        //    }
        //    //return any error messages
        //    return Stocknmlbl;
        //}










    }


}
