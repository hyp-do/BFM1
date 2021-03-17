using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968___BFM1
{
    class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>()
        {
            new Product( 001, "Orange Bicycle", 115.00m, 5, 1, 25 ),
            new Product( 002, "Blue Bicycle", 120.00m, 5, 1, 20 ),
            new Product( 003, "Red Bicycle", 110.00m, 5, 1, 25 ),
            new Product( 004, "Pink Bicycle", 135.00m, 5, 1, 15 ),
            new Product( 005, "Yellow Bicycle", 130.00m, 5, 1, 10 ),
            new Product( 100, "Blue Mountain Bike", 350.00m, 5, 1, 10)
        };

        public static BindingList<Part> AllParts = new BindingList<Part>()
        {
            new InHouse( 001, "Wheel", 12.11m, 5, 1, 25, 3773 ),
            new InHouse( 002, "Pedal", 8.22m, 5, 1, 25, 3113 ),
            new InHouse( 003, "Chain", 8.33m, 5, 1, 25, 1115 ),
            new InHouse( 004, "Seat", 4.55m, 2, 1, 15, 3123 ),
            new InHouse( 005, "Reflectors", 15.00m, 5, 1, 25, 2312 ),
            new InHouse( 006, "Standard Brakes", 20.00m, 5, 1, 25, 2113 ),
            new Outsourced( 501, "Disc Brakes", 75.00m, 5, 1, 25, "Shimano"),
            new Outsourced( 500, "Full Suspension", 150.00m, 5, 1, 15, "Giant" ),
            new Outsourced( 520, "Half Suspension", 125.00m, 5, 1, 15, "Trex" ),
            new Outsourced( 530, "All-Terrain Tires", 30.00m, 5, 1, 15, "Specialized" ),
            new Outsourced( 540, "Clip Pedals", 45.00m, 5, 1, 15, "Clipples"),
         };

        public static Part CurrentPart { get; set; }

        public static InHouse CurrentInHousePart { get; set; }

        public static Outsourced CurrentOutsourcedPart { get; set; }

        public static int CurrentPartId { get; set; }

        public static int ProductsCurrentIndex { get; set; }

        public static int PartsCurrentIndex { get; set; }

        public static Product CurrentProduct { get; set; }

        public static int CurrentProductId { get; set; }

        public void addProduct(int ProductID, string Name, decimal Price, int InStock, int Min, int Max)
        {
            Product productId = new Product(ProductID, Name, Price, InStock, Min, Max);
            Products.Add(productId);
        }


        public static bool removeProduct(int productId)
        {
            bool deleteProduct = false;

            try
            {
                Products.Remove(Products[productId]);
                deleteProduct = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return deleteProduct;
        }

        public static Product lookupProduct(int product)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID.Equals(product))
                {
                    ProductsCurrentIndex = i;
                    return Products[i];
                }
            }
            ProductsCurrentIndex = -1;
            return null;
        }

        public static void updateProduct(Product productId)
        {
            Products.Insert(ProductsCurrentIndex, productId);
            Products.RemoveAt(ProductsCurrentIndex + 1);
        }

        public static void addPart(int PartId, string Name, decimal Price, int InStock, int Min, int Max, int MachineID)
        {
            Part part = new InHouse(PartId, Name, Price, InStock, Min, Max, MachineID);
            AllParts.Add(part);
            InHouse.isInHouse = false;
        }

        public static void addPart(int PartId, string Name, decimal Price, int InStock, int Min, int Max, string CompanyName)
        {
            Part part = new Outsourced(PartId, Name, Price, InStock, Min, Max, CompanyName);
            AllParts.Add(part);
            Outsourced.isOutsourced = false;
        }

        public static bool deletePart(Part partId)
        {
            bool isDeleteOk = false;

            try
            {
                AllParts.Remove(partId);
                isDeleteOk = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return isDeleteOk;
        }

        public static Part lookupPart(int partId)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID.Equals(partId))
                {
                    PartsCurrentIndex = i;
                    return AllParts[i];
                }
            }
             PartsCurrentIndex = -1;
             return null;
        }


        public static void updatePart(Part PartId)
        {
            AllParts.Insert(PartsCurrentIndex, PartId);
            AllParts.RemoveAt(PartsCurrentIndex + 1);
        }

    }
}
