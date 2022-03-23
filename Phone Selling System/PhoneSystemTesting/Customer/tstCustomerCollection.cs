﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PSSClasses;



namespace PhoneSystemTesting
{


    [TestClass]
    public class tstCustomerCollection
    {
        //Dbo.tblCustomer Values
        //[CustID]
        //[Address]
        //[DOB]     
        //[Name]  
        //[Email] 
        //[PhoneNo]
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exist;
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustID = 1;
            TestItem.Address = "abracadabra";
            TestItem.DOB = "abracadabra";
            TestItem.Name = "abracadabra";
            TestItem.Email = "abracadabra";
            TestItem.PhoneNo = "abracadabra";
            //add the item to the test list
            TestList.Add(TestItem);
            AllCustomers.CustList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustList, TestList);
        }

        //[CustID]
        //[Address]
        //[DOB]     
        //[Name]  
        //[Email] 
        //[PhoneNo]
        [TestMethod]
        public void ThisCustPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //create some test data to assign to the property
            clsCustomer TestStock = new clsCustomer();
            //set the properties of the test object
            TestStock.CustID = 1;
            TestStock.Address = "abracadabra";
            TestStock.DOB = "abracadabra";
            TestStock.Name = "abracadabra";
            TestStock.Email = "abracadabra1";
            TestStock.PhoneNo = "abracadabra";
            //assign the data to the property
            AllCustomers.ThisCust = TestStock;
            Assert.AreEqual(AllCustomers.ThisCust, TestStock);

        }

   


        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that two values are the same
            Assert.AreEqual(AllCustomers.Count, 5);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustID = 111;
            TestItem.Address = "abracadabraa";
            TestItem.DOB = "abracadabra";
            TestItem.Name = "abracadabra";
            TestItem.Email = "abracadabra";
            TestItem.PhoneNo = "abracadabra";
            //set ThisStock to the test data
            AllCustomers.ThisCust = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustID = PrimaryKey;
            //find the record
            AllCustomers.ThisCust.Find(PrimaryKey);
            //test to see the two values are the same
            Assert.AreEqual(AllCustomers.ThisCust, TestItem);

        }



        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustID = 1;
            TestItem.Address = "abracadabra";
            TestItem.DOB = "abracadabra";
            TestItem.Name = "abracadabra";
            TestItem.Email = "abracadabra";
            TestItem.PhoneNo = "abracadabra";
            //set ThisStock to the test data
            AllCustomers.ThisCust = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustID = PrimaryKey;
            //find the record
            AllCustomers.ThisCust.Find(PrimaryKey);
            //test to see the two values are the same
            AllCustomers.Delete();
            Assert.AreEqual(AllCustomers.ThisCust, TestItem);

        }
        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a title that doesn't exist
            FilteredCustomers.ReportByName("ItDoesNotExist");
            //check that the correct number of records found
            if (FilteredCustomers.Count == 2)
            {
                //check that the first record is ID 1
                if (FilteredCustomers.CustList[0].CustID != 1)
                {
                    OK = false;
                }
                //check that the second record is ID 2
                if (FilteredCustomers.CustList[1].CustID != 2)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
            }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //create some test data to assign for the property
            //in this case the data need to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustID = 1;
            TestItem.Address = "abracadabra";
            TestItem.DOB = "abracadabra";
            TestItem.Name = "abracadabra";
            TestItem.Email = "abracadabra";
            TestItem.PhoneNo = "abracadabra";

            //add the item to the property
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustList = TestList;
            //test to see that two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

            [TestMethod]
            public void CountPropertyOK()
            {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //craete some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllCustomers.Count = SomeCount;
            //test to see that two values are the same
            Assert.AreEqual(AllCustomers.Count, SomeCount);
            }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create ab instance of teh class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustID = 1;
            TestItem.Address = "abracadabra";
            TestItem.DOB = "abracadabra";
            TestItem.Name = "abracadabra";
            TestItem.Email = "abracadabra";
            TestItem.PhoneNo = "abracadabra";
            //set thisstock to the test data
            AllCustomers.ThisCust = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustID = PrimaryKey;
            //modify the test data
            TestItem.Address = "abracadabra";
            TestItem.DOB = "abracadabra";
            TestItem.Name = "abracadabra";
            TestItem.Email = "abracadabra";
            TestItem.PhoneNo = "abracadabra";
            //set the record based on the new test data
            Assert.AreEqual(AllCustomers.ThisCust, TestItem);
        }


    }

}
