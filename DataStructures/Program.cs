using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start!");

            //Console.WriteLine("****************************");
            //var arr = AddToArray();
            //FindUser(arr);

            //Console.WriteLine("****************************");
            var listOfUsers = AddToListNoCapacity();
            FindUser(listOfUsers);

            //Console.WriteLine("****************************");
            //AddToListWithCapacity();

            //Console.WriteLine("****************************");
            //var linkedList = AddToLinkedList();
            //FindUser(linkedList);

            //Console.WriteLine("****************************");
            //var dict = AddToDictionary();
            //FindUser(dict);

            Console.WriteLine("****************************");
            Console.WriteLine("Done!");
            Console.ReadLine();
        }

        #region Add

        static User[] AddToArray()
        {
            int count = 2000000;

            var stopwatch = Stopwatch.StartNew();

            var arr = new User[count];
            for (int i = 0; i < count; i++)
            {
                var user = CreateUser();
                arr[i] = user;
            }

            stopwatch.Stop();

            Console.WriteLine($"Completed. Added {arr.Length} elements to array. Total time = {stopwatch.Elapsed} ");
            return arr;
        }

        static void FindUser(User[] users)
        {
            var user = users[1999999];

            var stopwatch = Stopwatch.StartNew();

            var u = users.Where(u => u.Id == user.Id);

            stopwatch.Stop();

            Console.WriteLine($"Found user in array. Total time = {stopwatch.Elapsed}");
        }

        static List<User> AddToListNoCapacity()
        {
            int count = 2000000;

            var stopwatch = Stopwatch.StartNew();

            var list = new List<User>();
            for (int i = 0; i < count; i++)
            {
                var user = CreateUser();
                list.Add(user);
            }

            stopwatch.Stop();

            Console.WriteLine($"Completed. Added {list.Count} elements to list with no capacity. Total time = {stopwatch.Elapsed} ");
            return list;
        }

        static void FindUser(List<User> users)
        {
            var user = users[1999999];

            var stopwatch = Stopwatch.StartNew();

            var u = users.FirstOrDefault(u => u.Id == user.Id);

            stopwatch.Stop();

            Console.WriteLine($"Found user in List. Total time = {stopwatch.Elapsed}");
        }

        static void AddToListWithCapacity()
        {
            int count = 2000000;

            var stopwatch = Stopwatch.StartNew();

            var list = new List<User>(count);
            for (int i = 0; i < count; i++)
            {
                var user = CreateUser();
                list.Add(user);
            }

            stopwatch.Stop();

            Console.WriteLine($"Completed. Added {list.Count} elements to list with capacity. Total time = {stopwatch.Elapsed} ");
        }

        static LinkedList<User> AddToLinkedList()
        {
            int count = 2000000;

            var stopwatch = Stopwatch.StartNew();

            var linkedList = new LinkedList<User>();
            for (int i = 0; i < count; i++)
            {
                var user = CreateUser();
                linkedList.AddLast(user);
            }

            stopwatch.Stop();

            Console.WriteLine($"Completed. Added {linkedList.Count} elements to linkedList. Total time = {stopwatch.Elapsed} ");
            return linkedList;
        }

        static void FindUser(LinkedList<User> users)
        {
            var user = users.Last;

            var stopwatch = Stopwatch.StartNew();

            var u = users.FirstOrDefault(u => u.Id == user.Value.Id);

            stopwatch.Stop();

            Console.WriteLine($"Found user in LinkedList. Total time = {stopwatch.Elapsed}");
        }

        static Dictionary<Guid, User> AddToDictionary()
        {
            int count = 2000000;

            var stopwatch = Stopwatch.StartNew();

            var dict = new Dictionary<Guid, User>();
            for (int i = 0; i < count; i++)
            {
                var user = CreateUser();
                dict[user.Id] = user;
            }

            stopwatch.Stop();

            Console.WriteLine($"Completed. Added {dict.Count} elements to dictionary. Total time = {stopwatch.Elapsed} ");
            return dict;
        }

        static void FindUser(Dictionary<Guid, User> users)
        {
            var user = users.Last();

            var stopwatch = Stopwatch.StartNew();

            var u = users[user.Key];

            stopwatch.Stop();

            Console.WriteLine($"Found user in dictionary. Total time = {stopwatch.Elapsed}");
        }

        #endregion

        #region Get



        #endregion


        #region Private methods

        private static User CreateUser()
        {
            return new User()
            {
                Id = Guid.NewGuid(),
                Age = 77,
                Name = "James Bond",
                Address = "Somewhere in between"
            };
        }

        #endregion

    }
}
