using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using StringManipulation;
using Microsoft.Extensions.Logging;
using Humanizer;

namespace StringManipulation.Tests
{
    public class StringManipulationTests
    {

        //1
        [Fact]
        public void ConcatenateStringsTest()
        {
            //Arrange
            StringOperations stringOperationsTest = new StringOperations();
            string str1 = "hola";
            string str2 = "Carlos";


            //act
            string result = stringOperationsTest.ConcatenateStrings(str1, str2);

            //Assert
            Assert.Equal(str1 + " " + str2, result);
        }

        //2
        [Fact]
        public void ReverseStringTest()
        {
            //Arrange
            StringOperations StringOperationsTest = new StringOperations();
            string str1 = "Santiago";

            //Act
            string result = StringOperationsTest.ReverseString("ogaitnaS");

            //Asert
            Assert.Equal(str1, result);
        }

        //3
        [Fact]
        public void GetStringLengthTestWhenThereIsText()
        {
            //Arrege
            StringOperations stringOperationsTest = new StringOperations();
            string str = "Carlitos";

            //Act
            int result = stringOperationsTest.GetStringLength(str);

            //Assert
            Assert.Equal(str.Length, result);
        }

        [Fact]
        public void GetStringLengthTestWhenStrIsNull()
        {
            //Arrege
            StringOperations stringOperationsTest = new StringOperations();
            string str = null;

            //Act
            int result = stringOperationsTest.GetStringLength(str);

            //Assert
            Assert.Equal(str.Length, result);
        }



        // 4
        [Fact]
        public void RemoveWhitespaceTest()
        {
            //Arrenge
            StringOperations StringOperationsTest = new StringOperations();
            string palabra = "Solucion 1";

            //act
            string result = StringOperationsTest.RemoveWhitespace(palabra);

            //Assert 
            Assert.Equal("Solucion1", result);
        }

        //5
        [Fact]
        public void TruncateStringTest_MaxLenght_Under_0_Or_0()
        {
            //Arrange
            StringOperations StringOperationsTest = new StringOperations();
            string input = "123456789";
            int maxlenght = 0;

            //Act
            string result = StringOperationsTest.TruncateString(input, maxlenght);

            //Assert
            Assert.Equal(input, result);

        }

        [Fact]
        public void TruncateStringTest_When_maxlenghtBiggerThanInput()
        {
            //Arrange
            StringOperations StringOperationsTest = new StringOperations();
            string input = "123456";
            int maxlenght = 7;

            //Act
            string result = StringOperationsTest.TruncateString(input, maxlenght);

            //Assert
            Assert.Equal(input, result);
        }

        //6
        [Fact]
        public void IsPalindromeTest()
        {
            //Arrange
            StringOperations stringOperationsTest = new StringOperations();
            string str = "drilococo";
            bool expectedRes = IsPalindrome(str);


            //Act
            bool result = stringOperationsTest.IsPalindrome(str);
            

            //Assert
            Assert.Equal(expectedRes, result);

        }

        public bool IsPalindrome(string input)
        {
            input = input.Trim().ToLower().Replace(" ", "");

            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] != input[input.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }


        //7
        [Fact]
        public void CountOccurrences()
        {
            var loggerFactory = LoggerFactory.Create(builder =>
            {
                // Add console logger
                builder.AddConsole();
            });

            // Create a logger
            var logger = loggerFactory.CreateLogger<StringOperations>();
            //Arrenge
            StringOperations StringOperationsTest = new StringOperations(logger);
            string input = "cocodrilo";
            char character = 'c';

            //Act
            int result = StringOperationsTest.CountOccurrences(input, character);

            //Assert
            Assert.Equal(2, result);


        }

        //8
        [Fact]
        public void PluralizeTest()
        {
            //Arrange
            StringOperations StringOperationsTest = new StringOperations();
            string input = "computadora";
            string Plural = "computadoras";

            //Act
            string result = StringOperationsTest.Pluralize(input);

            //Assert
            Assert.Equal(result, Plural);
        }
        //9
        [Fact]
        public void QuantintyInWords()
        {
            //Arrange
            StringOperations stringOperationTest = new StringOperations();
            string str = "table";
            int cant = 1;
            string expectedRes = str.ToQuantity(cant, ShowQuantityAs.Words);

            //Act
            string resutl = stringOperationTest.QuantintyInWords(str, cant);

            //Assert
            Assert.Equal(expectedRes, resutl);
        }

        //10
        [Fact]

        public void FromRomanToNumber()
        {
            //Arrange
            StringOperations StringOperationsTest = new StringOperations();
            string romano = "X";

            //Act 

            int result = StringOperationsTest.FromRomanToNumber(romano);

            //Assert
            Assert.Equal(10, result);


        }

        //11
        [Fact]
        public void ReadFileTest()
        {
            //Arrange
            StringOperations stringOperationsTest = new StringOperations();
            string expectedRes;

            IFileReaderConector fileReader = new FileReaderConector();
            
            //Act
            string result = stringOperationsTest.ReadFile(fileReader, "information.txt");
            expectedRes = ReadFile(fileReader, "information.txt"); 

            //Assert
            Assert.Equal(expectedRes, result);
        }

        public string ReadFile(IFileReaderConector fileReader, string fileName)
        {
            return fileReader.ReadString(fileName);
        }






    }


}

