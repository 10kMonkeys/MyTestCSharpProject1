using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MyTestCSharpProject1.Src.Model;
using MyTestCSharpProject1.Test.Tests.Base;
using Xunit;

namespace MyTestCSharpProject1.Test.Tests
{
    [Collection("Collection C")]
    public class TestLINQ : BaseWebTest
    {
        public TestLINQ()
        {
        }

        [Fact]
        //[AllureXunit(DisplayName = "Test 2")]
        public void Test3()
        {
            user.atHomePage.OpenHomePage();
            user.atHomePage.VerifySearchFieldIsDisplayed();
            var productTitleList = user.atHomePage.GetListOfProductTitles();

            // #1
            var startWithAList = from p in productTitleList // передаем каждый элемент из people в переменную p
                                 where p.ToUpper().StartsWith("A") //фильтрация по критерию
                                 orderby p  // упорядочиваем по возрастанию
                                 select p; // выбираем объект в создаваемую коллекцию

            // #2
            var startWithAList2 = productTitleList.Where(p => p.ToUpper().StartsWith("T")).OrderBy(p => p); // упрощенный #1

            // #3
            int number = (from p in productTitleList where p.ToUpper().StartsWith("T") select p).Count(); // комбинированный #1 + #2

            // === Проекция данных ===

            // #4
            //List<User> userList = new() // C# Core 9.0 version
            //{
            //    new User("Tom", 34), new User("Alex", 33)
            //};

            List<User> userList = new List<User>()
            {
                new User("Tom", 34, new List<string> {"english", "german"}),
                new User("Alex", 33, new List<string> {"english", "german"}),
                new User("Tom", 16, new List<string> {"english", "german"}),
                new User("Ellie", 26, new List<string> {"english", "german"}),
                new User("Boris", 48, new List<string> {"english", "german"}),
                new User("Vano", 20, new List<string> {"english", "german"})
            };

            var names = userList.Select(u => u.UserName); //забрать список UserName

            // #5
            var newUpdatedUserList = from p in userList // создать новый лист c юзерами совершенно другого / анонимного класса (!= User) на основе User
                                     select new         // так же можно делать выборку из 
                                     {
                                         FirstName = p.UserName,
                                         Year = DateTime.Now.Year - p.Age
                                     };

            // #6
            // проекция на объекты анонимного типа
            var newUpdatedUserList2 = userList.Select(p => new // аналог #5
            {
                FirstName = p.UserName,
                Year = DateTime.Now.Year - p.Age
            });

            // === Фильтрация коллекци ===

            // #7
            string[] people = { "Tom", "Alice", "Bob", "Sam", "Tim", "Tomas", "Bill" }; // фильтрация

            var selectedPeople = people.Where(p => p.Length == 3); // "Tom", "Bob", "Sam", "Tim"

            // #8
            int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 }; // фильтрация

            var evens1 = numbers.Where(i => i % 2 == 0 && i > 10);

            // #9
            var filteredUserList = userList.Where(p => p.Age > 30 && p.UserName == "Alex"); // фильтрация сложных объектов сложным фильтром

            // #10
            var filteredUserList2 = userList.SelectMany(u => u.Languages, (u, l) => new { User = u, Lang = l })
                .Where(u => u.Lang == "english" && u.User.Age < 30);
            var a = filteredUserList2.GetType();

            // #11
            var mixedList = new List<User>()
            {
                new User("Tom", 34, new List<string> {"english", "german"}),
                new Admin("John", 27, new List<string> {"english", "french"}),
                new Manager("Bob", 44, new List<string> {"english", "polish"}),
            };

            var filteredMixedList = mixedList.OfType<Admin>(); // фильтрация по типу

            // === Сортировка коллекци ===

            // #12
            int[] numbers2 = { 3, 12, 4, 10 };

            var orderedNumbers = from i in numbers2 // сортировка
                                 orderby i
                                 select i;

            // #13
            string[] people2 = { "Tom", "Bob", "Sam" };

            var orderedPeople = people2.OrderBy(p => p); // сортировка
            var orderedPeople2 = numbers.OrderByDescending(n => n);


            // #14
            var sortedPeople2 = userList.OrderBy(p => p.Age); // сортировка сложных объектов

            var sortedPeople3 = userList.OrderBy(p => p.UserName).ThenBy(p => p.UserName); // сортировка сложных объектов по нескольким критериям


            // === Объединение, пересечение и разность коллекций ===

            // #15
            string[] soft = { "Microsoft", "Google", "Apple" };
            string[] hard = { "Apple", "IBM", "Samsung" };

            // #16
            // разность последовательностей
            var result = soft.Except(hard); // из soft убираются элементы, которые есть в hard

            // #17
            // пересечение последовательностей
            var result2 = soft.Intersect(hard); // попадают только те, которые присутствуют в обоих массивах

            // #18
            string[] soft2 = { "Microsoft", "Google", "Apple", "Microsoft", "Google" };

            // удаление дублей
            var result3 = soft2.Distinct();

            string[] soft4 = { "Microsoft", "Google", "Apple" };
            string[] hard4 = { "Apple", "IBM", "Samsung" };

            // #19
            // объединение последовательностей
            var result4 = soft4.Union(hard4); // объединение без дубликатов

            // #20
            var result5 = soft4.Concat(hard4); // полное объединение


            // #21
            var combinedUserList = mixedList.Union(userList);

            // #22
            // для работы объединения со слоными объектами,
            // необходимо переопределить методы Equals и GetHashCode

            // === Объединение, пересечение и разность коллекций ===

        }
    }
}
