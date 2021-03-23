using System;
using System.Collections.Generic;
namespace WidgetOOPCSharp {

    class Program {


        static void Main(string[] args) {

            //Company A= 1 Large enterprise, 3 small advanced, 7 medium basic, 3 year Service on ALL 

            var companyA = new List<Product>();
            var companyAwl = new Widget() { Id = 1, Description = "1 Large Enterprise Widget", Price = 550, Size = "Large", Model = "Enterprise" };

            var companyAwS1 = new Widget() { Id = 1, Description = "Small Advanced Widget", Price = 125, Size = "Small", Model = "Advanced" };
            var companyAwS2 = new Widget() { Id = 1, Description = "Small Advanced Widget", Price = 125, Size = "Small", Model = "Advanced" };
            var companyAwS3 = new Widget() { Id = 1, Description = "Small Advanced Widget", Price = 125, Size = "Small", Model = "Advanced" };

            var companyAwM1 = new Widget() { Id = 1, Description = "Medium Basic Widget", Price = 100, Size = "Medium", Model = "Basic" };
            var companyAwm2 = new Widget() { Id = 1, Description = "Medium Basic Widget", Price = 100, Size = "Medium", Model = "Basic" };
            var companyAwm3 = new Widget() { Id = 1, Description = "Medium Basic Widget", Price = 100, Size = "Medium", Model = "Basic" };
            var companyAwm4 = new Widget() { Id = 1, Description = "Medium Basic Widget", Price = 100, Size = "Medium", Model = "Basic" };
            var companyAwm5 = new Widget() { Id = 1, Description = "Medium Basic Widget", Price = 100, Size = "Medium", Model = "Basic" };
            var companyAwm6 = new Widget() { Id = 1, Description = "Medium Basic Widget", Price = 100, Size = "Medium", Model = "Basic" };
            var companyAwm7 = new Widget() { Id = 1, Description = "Medium Basic Widget", Price = 100, Size = "Medium", Model = "Basic" };


            var companyAserv = new Service() { Id = 1, Description = "Company A Year 1 Service Plan on all widgets ", Price = 406.25, ServiceYears = 1, WidgetId = 1 };
            var companyAserv2 = new Service() { Id = 1, Description = "Company A Year 2 Service Plan on all widgets ", Price = 406.25, ServiceYears = 1, WidgetId = 1 };
            var companyAserv3 = new Service() { Id = 1, Description = "Company A Year 3 Service Plan on all widgets ", Price = 406.25, ServiceYears = 1, WidgetId = 1 };


            companyA.Add(companyAwl);
            companyA.Add(companyAwS1);
            companyA.Add(companyAwS2);
            companyA.Add(companyAwS3);
            companyA.Add(companyAwM1);
            companyA.Add(companyAwm2);
            companyA.Add(companyAwm3);
            companyA.Add(companyAwm4);
            companyA.Add(companyAwm5);
            companyA.Add(companyAwm6);
            companyA.Add(companyAwm7);
            companyA.Add(companyAserv);
            companyA.Add(companyAserv2);
            companyA.Add(companyAserv3);


            var totalA = 0.0;

            foreach (var product in companyA) {
                totalA += product.Price;



            }

            Console.WriteLine($"Total for Company A is {totalA}");

            //Company B = 5 Large advanced, 2 Small basic, 4 medium enterprise and 4 year service plan on all

            var companyB = new List<Product>();

            var companyBwL1 = new Widget() { Id = 2, Description = "Large Advanced Widget", Price = 275, Size = "Large", Model = "Advanced" };
            var companyBwL2 = new Widget() { Id = 2, Description = "Large Advanced Widget", Price = 275, Size = "Large", Model = "Advanced" };
            var companyBwL3 = new Widget() { Id = 2, Description = "Large Advanced Widget", Price = 275, Size = "Large", Model = "Advanced" };
            var companyBwL4 = new Widget() { Id = 2, Description = "Large Advanced Widget", Price = 275, Size = "Large", Model = "Advanced" };
            var companyBwL5 = new Widget() { Id = 2, Description = "Large Advanced Widget", Price = 275, Size = "Large", Model = "Advanced" };

            var companyBwS1 = new Widget() { Id = 2, Description = "Small Basic Widget", Price = 50, Size = "Small", Model = "Basic" };
            var companyBwS2 = new Widget() { Id = 2, Description = "Small Basic Widget", Price = 50, Size = "Small", Model = "Basic" };


            var companyBwM1 = new Widget() { Id = 2, Description = "Medium Enterprise Widget", Price = 400, Size = "Medium", Model = "Enterprise" };
            var companyBwM2 = new Widget() { Id = 2, Description = "Medium Enterprise Widget", Price = 400, Size = "Medium", Model = "Enterprise" };
            var companyBwM3 = new Widget() { Id = 2, Description = "Medium Enterprise Widget", Price = 400, Size = "Medium", Model = "Enterprise" };
            var companyBwM4 = new Widget() { Id = 2, Description = "Medium Enterprise Widget", Price = 400, Size = "Medium", Model = "Enterprise" };

            var companyBserv1 = new Service() { Id = 2, Description = "Year 1 Service Plan on all widgets ", Price = 768.75, ServiceYears = 4, WidgetId = 2 };
            var companyBserv2 = new Service() { Id = 2, Description = "Year 2 Service Plan on all widgets ", Price = 768.75, ServiceYears = 4, WidgetId = 2 };
            var companyBserv3 = new Service() { Id = 2, Description = "Year 3 Service Plan on all widgets ", Price = 768.75, ServiceYears = 4, WidgetId = 2 };
            var companyBserv4 = new Service() { Id = 2, Description = "Year 4 Service Plan on all widgets ", Price = 768.75, ServiceYears = 4, WidgetId = 2 };


            companyB.Add(companyBwL1);
            companyB.Add(companyBwL2);
            companyB.Add(companyBwL3);
            companyB.Add(companyBwL4);
            companyB.Add(companyBwL5);

            companyB.Add(companyBwS1);
            companyB.Add(companyBwS2);

            companyB.Add(companyBwM1);
            companyB.Add(companyBwM2);
            companyB.Add(companyBwM3);
            companyB.Add(companyBwM4);

            companyB.Add(companyBserv1);
            companyB.Add(companyBserv2);
            companyB.Add(companyBserv3);
            companyB.Add(companyBserv4);



            var totalB = 0.0;

            foreach (var product in companyB) {
                totalB += product.Price;



            }

            Console.WriteLine($"Total for Company B is {totalB}");



            //Company C = 10 Large Basic, 7 small enterprise, 3 medium advanced and 5 year service on all

            var companyC = new List<Product>();
            var companyCwL1 = new Widget() { Id = 3, Description = "Large Basic Widget", Price = 150, Size = "Large", Model = "Basic" };
            var companyCwL2 = new Widget() { Id = 3, Description = "Large Basic Widget", Price = 150, Size = "Large", Model = "Basic" };
            var companyCwL3 = new Widget() { Id = 3, Description = "Large Basic Widget", Price = 150, Size = "Large", Model = "Basic" };
            var companyCwL4 = new Widget() { Id = 3, Description = "Large Basic Widget", Price = 150, Size = "Large", Model = "Basic" };
            var companyCwL5 = new Widget() { Id = 3, Description = "Large Basic Widget", Price = 150, Size = "Large", Model = "Basic" };
            var companyCwL6 = new Widget() { Id = 3, Description = "Large Basic Widget", Price = 150, Size = "Large", Model = "Basic" };
            var companyCwL7 = new Widget() { Id = 3, Description = "Large Basic Widget", Price = 150, Size = "Large", Model = "Basic" };
            var companyCwL8 = new Widget() { Id = 3, Description = "Large Basic Widget", Price = 150, Size = "Large", Model = "Basic" };
            var companyCwL9 = new Widget() { Id = 3, Description = "Large Basic Widget", Price = 150, Size = "Large", Model = "Basic" };
            var companyCwL10 = new Widget() { Id = 3, Description = "Large Basic Widget", Price = 150, Size = "Large", Model = "Basic" };

            var companyCwM1 = new Widget() { Id = 3, Description = "Medium Advanced Widget", Price = 200, Size = "Medium", Model = "Advanced" };
            var companyCwM2 = new Widget() { Id = 3, Description = "Medium Advanced Widget", Price = 200, Size = "Medium", Model = "Advanced" };
            var companyCwM3 = new Widget() { Id = 3, Description = "Medium Advanced Widget", Price = 200, Size = "Medium", Model = "Advanced" };

            var companyCwS1 = new Widget() { Id = 3, Description = "Small Enterprise Widget", Price = 250, Size = "Small", Model = "Enterprise" };
            var companyCwS2 = new Widget() { Id = 3, Description = "Small Enterprise Widget", Price = 250, Size = "Small", Model = "Enterprise" };
            var companyCwS3 = new Widget() { Id = 3, Description = "Small Enterprise Widget", Price = 250, Size = "Small", Model = "Enterprise" };
            var companyCwS4 = new Widget() { Id = 3, Description = "Small Enterprise Widget", Price = 250, Size = "Small", Model = "Enterprise" };
            var companyCwS5 = new Widget() { Id = 3, Description = "Small Enterprise Widget", Price = 250, Size = "Small", Model = "Enterprise" };
            var companyCwS6 = new Widget() { Id = 3, Description = "Small Enterprise Widget", Price = 250, Size = "Small", Model = "Enterprise" };
            var companyCwS7 = new Widget() { Id = 3, Description = "Small Enterprise Widget", Price = 250, Size = "Small", Model = "Enterprise" };

            var companyCserv1 = new Service() { Id = 3, Description = "Year 1 Service Plan on all widgets ", Price = 962.50, ServiceYears = 5, WidgetId = 3 };
            var companyCserv2 = new Service() { Id = 3, Description = "Year 2 Service Plan on all widgets ", Price = 962.50, ServiceYears = 5, WidgetId = 3 };
            var companyCserv3 = new Service() { Id = 3, Description = "Year 3 Service Plan on all widgets ", Price = 962.50, ServiceYears = 5, WidgetId = 3 };
            var companyCserv4 = new Service() { Id = 3, Description = "Year 4 Service Plan on all widgets ", Price = 962.50, ServiceYears = 5, WidgetId = 3 };
            var companyCserv5 = new Service() { Id = 3, Description = "Year 5 Service Plan on all widgets ", Price = 962.50, ServiceYears = 5, WidgetId = 3 };

            companyC.Add(companyCwL1);
            companyC.Add(companyCwL2);
            companyC.Add(companyCwL3);
            companyC.Add(companyCwL4);
            companyC.Add(companyCwL5);
            companyC.Add(companyCwL6);
            companyC.Add(companyCwL7);
            companyC.Add(companyCwL8);
            companyC.Add(companyCwL9);
            companyC.Add(companyCwL10);

            companyC.Add(companyCwM1);
            companyC.Add(companyCwM2);
            companyC.Add(companyCwM3);

            companyC.Add(companyCwS1);
            companyC.Add(companyCwS2);
            companyC.Add(companyCwS3);
            companyC.Add(companyCwS4);
            companyC.Add(companyCwS5);
            companyC.Add(companyCwS6);
            companyC.Add(companyCwS7);

            companyC.Add(companyCserv1);
            companyC.Add(companyCserv2);
            companyC.Add(companyCserv3);
            companyC.Add(companyCserv4);
            companyC.Add(companyCserv5);


            var totalC = 0.0;

            foreach (var product in companyC) { 
                totalC += product.Price;



            }

            Console.WriteLine($"Total for Company C is {totalC}");

        }
    }
}
