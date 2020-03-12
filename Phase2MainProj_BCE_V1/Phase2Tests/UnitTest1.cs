using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Phase2MainProj_BCE_V1;

namespace Phase2Tests
{
    /// <summary>
    /// Tests for the Employee data program
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// tests the instantiation of all types of employees as well as if they are correctly 
        /// logged into the empData SortedDictionary in the BusinessRules class
        /// for test I added a List which can be passed to the business rules class
        /// this was done for easier iteration through the List used to test the dictionary
        /// </summary>
        [TestMethod]
        public void EmpDataTest()
        {
            //arrange
            List<Employee> testEmployees = new List<Employee>();
            //Hourly = 0
            //Salary = 1
            //Sales = 2
            //Contract = 3

            //Adding made up employees into the sorted dictionary
            testEmployees.Add(new Contract(1, (double)empType.Contract, 1500, "Dale Hendersen", "Dale", "Hendersen"));
            testEmployees.Add(new Sales(2, (double)empType.Sales, 1500, 25.50, 13, "Erik Wilson", "Erik", "Wilson"));
            testEmployees.Add(new Salary(3, (double)empType.Salary, 1500, "Mary Tilsson", "Mary", "Tilsson"));
            testEmployees.Add(new Hourly(4, (double)empType.Hourly, 22.33, 41, "Jill Smith", "Jill", "Smith"));
            BusinessRules businessRules = new BusinessRules(testEmployees);

            //act
            //checking if the empdata sortedDictionary does in fact have a given 
            //Employee with the given key

            //FAILS
            // businessRules.empData.TryGetValue("0", out Employee IsThisEmployee);

            //PASSES
            //Change first parameter from 1-4 to test each type of employee 
            businessRules.empData.TryGetValue("1", out Employee IsThisEmployee2);

            //assert
            //if the action part of the test is successful then these should both be of type Employee
            //Assert.AreEqual(testEmployees[0].GetType(), IsThisEmployee.GetType());
            Assert.AreEqual(testEmployees[0].GetType(), IsThisEmployee2.GetType());
        }//end EmpDataTest()

        /// <summary>
        /// This test creates an employee and adds it to the Business rules Instance
        /// Then tests the functionality of the searchEmployee method
        /// </summary>
        [TestMethod]
        public void SearchTest()
        {
            //arrange 
            Hourly testEmp2 = new Hourly(6, (double)empType.Hourly, 22.33, 41, "Bill Smithers", "Bill", "Smithers");
            BusinessRules.Instance.addEmployee("6", testEmp2);

            //act
            ////FAILS
            //var testResult = BusinessRules.Instance.searchEmployee("TED");
            ////FAILS
            //var testResult1 = BusinessRules.Instance.searchEmployee("0");
            //PASSES
            var testResult2 = BusinessRules.Instance.searchEmployee("Bill");


            //Assert
            //Assert.AreEqual(testEmp2, testResult);
            //Assert.AreEqual(testEmp2, testResult1);
            Assert.AreEqual(testEmp2, testResult2);
        }
    }
}
