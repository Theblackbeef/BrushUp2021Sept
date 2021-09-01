using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryStudent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace ClassLibraryStudentTests
{
    [TestClass()]
    public class Tests
    {

        [TestMethod()]
        public void Nametest()
        {
            Student studentTest = new Student();
            studentTest.Name = "Martin";
            Assert.AreEqual("Martin", studentTest.Name);
        }

        [TestMethod()]
        public void AssertExceptionNametest()
        {
            Student studentTest = new Student();
            Assert.ThrowsException<ArgumentException>(
                () => studentTest.Name = "M");
        }


        [TestMethod()]
        public void Addresstest()
        {
            Student studentTest = new Student();
            studentTest.Address = "Møllehusvej 127";
            Assert.AreEqual("Møllehusvej 127", studentTest.Address );
        }
        [TestMethod()]
        public void AssertExceptionAddresstest()
        {
            Student studentTest = new Student();
            Assert.ThrowsException<ArgumentNullException>(
                () => studentTest.Address = null );
        }

        [TestMethod()]
        public void Semestertest()
        {
            Student studentTest = new Student();
            studentTest.Semester = 2;
            Assert.AreEqual(2, studentTest.Semester);
        }

        [TestMethod()]
        public void AssertExceptionSemesterTest()
        {
            Student studentTest = new Student();
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => studentTest.Semester = 9);
        }

        [TestMethod()]
        public void Gendertest()
        {
            Student studentTest = new Student();
            studentTest.GenderTypeMF = Person.GenderType.Male;
            Assert.AreEqual(Person.GenderType.Male
            , studentTest.GenderTypeMF);

        }

        [TestMethod()]
        public void NametestTeacher()
        {
            Teacher teacherTest = new Teacher();
            teacherTest.Name = "Martin";
            Assert.AreEqual("Martin", teacherTest.Name);
        }

        [TestMethod()]
        public void AssertExceptionNametestTeacher()
        {
            Teacher teacherTest = new Teacher();
            Assert.ThrowsException<ArgumentException>(
                () => teacherTest.Name = "M");
        }


        [TestMethod()]
        public void AddresstestTeacher()
        {
            Teacher teacherTest = new Teacher();
            teacherTest.Address = "Møllehusvej 127";
            Assert.AreEqual("Møllehusvej 127", teacherTest.Address);
        }
        [TestMethod()]
        public void AssertExceptionAddresstestTeacher()
        {
            Teacher teacherTest = new Teacher();
            Assert.ThrowsException<ArgumentNullException>(
                () => teacherTest.Address = null);
        }

        [TestMethod()]
        public void SalarytestTeacher()
        {
            Teacher teacherTest = new Teacher();
            teacherTest.Salary = 500;
            Assert.AreEqual(500, teacherTest.Salary);
        }

        [TestMethod()]
        public void AssertExceptionSalarytestTeacher()
        {
            Teacher teacherTest = new Teacher();
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => teacherTest.Salary = -100);
        }

        [TestMethod()]
        public void GendertestTeacher()
        {
            Teacher teacherTest = new Teacher();
            teacherTest.GenderTypeMF = Person.GenderType.Male;
            Assert.AreEqual(Person.GenderType.Male
                , teacherTest.GenderTypeMF);

        }



    }
}