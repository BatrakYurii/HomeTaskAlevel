﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Master
{
    public class DataProcessor
    {
        private List<User> _users = new List<User>();
        private List<Order> _orders = new List<Order>();

        public DataProcessor(List<string> users, List<string> orders)
        {
            foreach (var user in users)
            {
                string[] subs = user.Split(';');
               
                    _users.Add(new User(int.Parse(subs[0]), subs[1], subs[2], uint.Parse(subs[3])));
            }
                   
            foreach (var order in orders)
            {
                string[] subs = order.Split(';');
                _orders.Add(new Order(int.Parse(subs[0]), int.Parse(subs[1]), uint.Parse(subs[2]), DateTime.Parse(subs[3]), uint.Parse(subs[4])));
                
            }
        }

        public async void CreateResultAsync()
        {
            var selectedUsers = from user in _users
                                where user.Age > 16 && user.Age < 65
                                select user;

            var selectedOrders = from order in _orders
                                 where ((DateTime.Today - order.OrderDate)).Days < 7
                                 select order;

            var result = from user in selectedUsers
                         join order in selectedOrders on user.Id equals order.UserId
                         select new { OrderNumber = order.OrderNumber, OrderDate = order.OrderDate, UserName = user.Name, Total = order.Total };

            var sortedResult = from i in result
                               orderby i.OrderDate.Day descending
                               select i;

            FileProcessor fileProcessor = new FileProcessor("D:/A-Level/Master/result.txt");

            foreach (var item in sortedResult)
            {
                await fileProcessor.WriteTextAsync($"{item.OrderNumber} {item.OrderDate.ToShortDateString()} {item.UserName} {item.Total}");
            }

        }
    }
}

