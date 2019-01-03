using System;
using Xunit;

//进行单元测试案例
namespace Hospital.Test
{
    public class UnitTest1
    {       
        [Fact]
        public void Test1()
        {
            var patient = new Patient();

            Assert.True(patient.IsNew);
        }
        [Fact]
        public void CalculateFullName()
        {
            var p = new Patient
            {
                FirstName = "Nick",
                LastName = "Carter"
            };
            Assert.Equal("Nick Carter",p.FullName,ignoreCase:true);
        }

        [Fact]
        public void CalculateFullNameStartsWithFirstName()
        {
            var p = new Patient
            {
                FirstName = "Nick",
                LastName = "Carter"
            };
            Assert.StartsWith("Nick", p.FullName);
        }

        [Fact]
        public void CalculateFullNameEndWithFirstName()
        {
            var p = new Patient
            {
                FirstName = "Nick",
                LastName = "Carter"
            };
            Assert.EndsWith("Carter", p.FullName);
        }

        [Fact]
        public void CalculateFullNameSubstring()
        {
            var p = new Patient
            {
                FirstName = "Nick",
                LastName = "Carter"
            };
            Assert.Contains("ck Ca", p.FullName);
        }

        //正则表达式 首字符大写
        [Fact]
        public void CalculateFullNameWithTitleCase()
        {
            var p = new Patient
            {
                FirstName = "Nick",
                LastName = "Carter"
            };
            //Assert.Matches("[A-Z]{1}{a-z}+ [A-Z]{1}[a-z]+", p.FullName);
            
            Assert.Matches(@"^(\b[A-Z][a-zA-Z]*\s*)*$", p.FullName);
        }

        [Fact]
        public void BloodSugarStartWithDefaultValue ()
        {
            var p = new Patient();
            Assert.Equal(5.0,p.BloodSugar);
        }

        [Fact]
        public void BloodSugarIncreaseAfterDinner()
        {
            var p = new Patient();
            p.HaveDinner();
            // Assert.InRange<float>(p.BloodSugar, 5, 6);
            Assert.InRange(p.BloodSugar, 5, 6);
        }


    }
}
