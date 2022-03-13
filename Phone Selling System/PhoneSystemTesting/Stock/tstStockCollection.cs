﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PSSClasses;

//Written by Syed || P2652259 || No3Mc(https://github.com/No3Mc)
//Repository Link : https://github.com/No3Mc/PMAD-Phone-Selling-Store


namespace PhoneSystemTesting
{

    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //test to see that it exist;
            Assert.IsNotNull(AllStocks);
        }

        [TestMethod]
        public void StockListOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.StockID = 1;
            TestItem.StockName = "a";
            TestItem.WarehouseNo = "a";
            TestItem.Location = "a";
            TestItem.Quantity = "a";
            TestItem.Barcode = "a";
            //add the item to the test list
            TestList.Add(TestItem);
            AllStocks.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.StockList, TestList);
        }


        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    //create an instance of the class we want to create
        //    clsStockCollection AllStocks = new clsStockCollection();
        //    //create some test data to assign to the proeprty
        //    Int32 SomeCount = 0;
        //    //assign the data to the property
        //    AllStocks.Count = SomeCount;
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllStocks.Count, SomeCount);
        //}
        //For quick copy paste StockName, WarehouseNo, Location, Quantity, Barcode

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //set the properties of the test object
            TestStock.StockID = 1;
            TestStock.StockName = "1";
            TestStock.Location = "1";
            TestStock.Quantity = "1";
            TestStock.WarehouseNo = "1";
            TestStock.Barcode = "1";
            //assign the data to the property
            AllStocks.ThisStock = TestStock;
            Assert.AreEqual(AllStocks.ThisStock, TestStock);

        }







        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StockID = 1;
            TestItem.StockName = "1";
            TestItem.WarehouseNo = "1";
            TestItem.Location = "1";
            TestItem.Quantity = "1";
            TestItem.Barcode = "1";
            //set ThisStock to the test data
            AllStocks.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStocks.Add();
            //set the primary key of the test data
            TestItem.StockID = PrimaryKey;
            //find the record
            AllStocks.ThisStock.Find(PrimaryKey);
            //test to see the two values are the same
            Assert.AreEqual(AllStocks.ThisStock, TestItem);

        }



        [TestMethod]
        public void DelMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StockID = 1;
            TestItem.StockName = "1";
            TestItem.WarehouseNo = "1";
            TestItem.Location = "1";
            TestItem.Quantity = "1";
            TestItem.Barcode = "1";
            //set ThisStock to the test data
            AllStocks.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStocks.Add();
            //set the primary key of the test data
            TestItem.StockID = PrimaryKey;
            //find the record
            AllStocks.ThisStock.Find(PrimaryKey);
            //test to see the two values are the same
            AllStocks.Del();
            Assert.AreEqual(AllStocks.ThisStock, TestItem);

        }


        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign for the property
            //in this case the data need to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.StockID = 1;
            TestItem.StockName = "1";
            TestItem.WarehouseNo = "1";
            TestItem.Location = "1";
            TestItem.Quantity = "1";
            TestItem.Barcode = "1";
 
            //add the item to the property
            TestList.Add(TestItem);
            //assign the data to the property
            AllStocks.StockList = TestList;
            //test to see that two values are the same
            Assert.AreEqual(AllStocks.Count, TestList.Count);
        }
        //For quick copy paste StockName, WarehouseNo, Location, Quantity, Barcode


        [TestMethod]
        public void UpdateMethodOK()
        {
            //create ab instance of teh class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StockName = "1";
            TestItem.WarehouseNo = "1";
            TestItem.Location = "1";
            TestItem.Quantity = "1";
            TestItem.Barcode = "1";
            //set thisstock to the test data
            AllStocks.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStocks.Add();
            //set the primary key of the test data
            TestItem.StockID = PrimaryKey;
            //modify the test data
            TestItem.StockName = "1111";
            TestItem.WarehouseNo = "11111";
            TestItem.Location = "11111";
            TestItem.Quantity = "1111";
            TestItem.Barcode = "11111";
            //set the record based on the new test data
            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }

        //For quick copy paste StockName, WarehouseNo, Location, Quantity, Barcode


        [TestMethod]
        public void ReportByLocationMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStockCollection AllStocks = new clsStockCollection();
            //create an instance of the filtered data
            clsStockCollection FilteredStocks = new clsStockCollection();
            //apply a blank string (should return all records)
            FilteredStocks.ReportByLocation("2222");
            //test to see ThisBook mathces the test data
            Assert.AreEqual(AllStocks.Count, FilteredStocks.Count);
        }

        //[TestMethod]
        //public void ReportByLocationTestDataFound()
        //{
 
        //    //create an instance of the filtered data
        //    clsStockCollection FilteredStocks = new clsStockCollection();
        //    //var to store outcome
        //    bool OK = true;
        //    //apply a post code that doesn't exist
        //    FilteredStocks.ReportByLocation("aaaaa");
        //    //check that the correct number of record are found
        //    if (FilteredStocks.Count == 2)
        //    {
        //        //check that the first record is ID 21
        //        if (FilteredStocks.StockList[0].StockID != 21)
        //        {
        //            OK = false;

        //        }
        //        //check that the first record is ID 26
        //        if (FilteredStocks.StockList[1].StockID != 26)
        //        {
        //            OK = false;
        //        }

        //    }
        //    else
        //    {
        //        OK = false;
        //    }
        //    //test to see that there are no records
        //    Assert.IsTrue(OK);
        //}


        //got rid of these two tests according to the lab 23

        //[TestMethod]
        //public void ListAndCountOK()
        //{
        //    //create an instance of the class we want to create
        //    clsStockCollection AllStocks = new clsStockCollection();
        //    //create some test data to assign to the property
        //    //in this case the data needs to be a list of objects
        //    List<clsStock> TestList = new List<clsStock>();
        //    //add an item to the list
        //    //create the item of test data
        //    clsStock TestItem = new clsStock();
        //    //set its properties
        //    TestItem.StockID = 1;
        //    TestItem.StockName = "1";
        //    TestItem.Location = "1";
        //    TestItem.Quantity = "1";
        //    TestItem.WarehouseNo = "1";
        //    TestItem.Barcode = "1";
        //    //add the item to the test list
        //    TestList.Add(TestItem);
        //    //assign the data of the property
        //    AllStocks.StockList = TestList;
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllStocks.Count, TestList.Count);

        //}


        //[TestMethod]
        //public void TwoRecordsPresent()
        //{
        //    //create an instance of the class we want to create
        //    clsStockCollection AllStocks = new clsStockCollection();
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllStocks.Count, 2);
        //}












    }


}
