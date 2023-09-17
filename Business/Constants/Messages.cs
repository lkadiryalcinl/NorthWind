using Azure.Core;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CATEGORY_ADDED = "Category succesfully added.";
        public static string CATEGORY_DELETED = "Category succesfully deleted.";
        public static string CATEGORY_UPDATED = "Category succesfully updated.";

        public static string CUSTOMER_ADDED = "Customer succesfully added.";
        public static string CUSTOMER_DELETED = "Customer succesfully deleted.";
        public static string CUSTOMER_UPDATED = "Customer succesfully updated.";

        public static string EMPLOYEE_ADDED = "Employee succesfully added.";
        public static string EMPLOYEE_DELETED = "Employee succesfully deleted.";
        public static string EMPLOYEE_UPDATED = "Employee succesfully updated.";

        public static string ORDER_ADDED = "Order succesfully added.";
        public static string ORDER_DELETED = "Order succesfully deleted.";
        public static string ORDER_UPDATED = "Order succesfully updated.";

        public static string PRODUCT_ADDED = "Product succesfully added.";
        public static string PRODUCT_DELETED = "Product succesfully deleted.";
        public static string PRODUCT_UPDATED = "Product succesfully updated.";

        public static string REGION_ADDED = "Region succesfully added.";
        public static string REGION_DELETED = "Region succesfully deleted.";
        public static string REGION_UPDATED = "Region succesfully updated.";

        public static string SHIPPER_ADDED = "Shipper succesfully added.";
        public static string SHIPPER_DELETED = "Shipper succesfully deleted.";
        public static string SHIPPER_UPDATED = "Shipper succesfully updated.";

        public static string SUPPLIER_ADDED = "Supplier succesfully added.";
        public static string SUPPLIER_DELETED = "Supplier succesfully deleted.";
        public static string SUPPLIER_UPDATED = "Supplier succesfully updated.";

        public static string TERRITORY_ADDED = "Territory succesfully added.";
        public static string TERRITORY_DELETED = "Territory succesfully deleted.";
        public static string TERRITORY_UPDATED = "Territory succesfully updated.";

        public static string USER_NOT_FOUND = "User not found.";
        public static string PASSWORD_ERROR = "Password is wrong.";
        public static string USER_ALREADY_EXISTS = "User already exists.";
        public static string LOGIN_SUCCESS = "User successfully logined.";
        public static string USER_REGISTERED = "User successfully registered.";
        public static string ACCESS_TOKEN_CREATED = "Access token is created.";
    }
}
