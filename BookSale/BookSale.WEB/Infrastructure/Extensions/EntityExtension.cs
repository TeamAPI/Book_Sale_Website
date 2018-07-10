using BookSale.Model.Models;
using BookSale.WEB.Models;

namespace BookSale.WEB.Infratructure.Extensions
{
    public static class EntityExtension
    {
        //public static void updateAccount(this Account acount, AccountViewModel acountVm)
        //{
        //    acount.AccountID = acountVm.AccountID;
        //    acount.AccountName = acountVm.AccountName;
        //    acount.AccountPassword = acountVm.AccountPassword;
        //    acount.AccountStatus = acountVm.AccountStatus;
        //    acount.AccountType = acountVm.AccountType;

        //    acount.created_by = acountVm.created_by;
        //    acount.created_date = acountVm.created_date;
        //    acount.updated_by = acountVm.updated_by;
        //    acount.updated_date = acountVm.updated_date;
        //}

        //public static void updateAccountPermission(this AccountPermission accountPermission, AccountPermissionViewModel accountPermissionVm)
        //{
        //    accountPermission.AccountID = accountPermissionVm.AccountID;
        //    accountPermission.PermissionID = accountPermissionVm.PermissionID;
        //}

        //public static void updateAccountProfile(this AccountProfile accountProfile, AccountProfileViewModel accountProfileVm)
        //{
        //    accountProfile.AccountProfileID = accountProfileVm.AccountProfileID;
        //    accountProfile.AccountProfileUsername = accountProfileVm.AccountProfileUsername;
        //    accountProfile.AccountProfileSex = accountProfileVm.AccountProfileSex;
        //    accountProfile.AccountProfileDateofbirth = accountProfileVm.AccountProfileDateofbirth;
        //    accountProfile.AccountProfileEmail = accountProfileVm.AccountProfileEmail;
        //    accountProfile.AccountProfileAddress = accountProfileVm.AccountProfileAddress;
        //    accountProfile.AccountProfileNumberphone = accountProfileVm.AccountProfileNumberphone;
        //    accountProfile.AcountProfileImages = accountProfileVm.AcountProfileImages;

        //    accountProfile.AccountID = accountProfileVm.AccountID;
        //}

        public static void updateError(this Error error, ErrorViewModel errorVm)
        {
            error.ErrorID = errorVm.ErrorID;
            error.Message = errorVm.Message;
            error.StackTrace = errorVm.StackTrace;
            error.CreatedDate = errorVm.CreatedDate;
        }

        public static void updateFooter(this Footer footer, FooterViewModel footerVm)
        {
            footer.ID = footerVm.ID;
            footer.Content = footerVm.Content;
            footer.Type = footerVm.Type;
        }

        public static void updateMenu(this Menu menu, MenuViewModel menuVm)
        {
            menu.ID = menuVm.ID;
            menu.Name = menuVm.Name;
            menu.URL = menuVm.URL;
            menu.DisplayOrder = menuVm.DisplayOrder;
            menu.GroupID = menuVm.GroupID;
            menu.Target = menuVm.Target;
            menu.Status = menuVm.Status;
        }

        public static void updateMenuGroup(this MenuGroup menuGroup, MenuGroupViewModel menuGroupVm)
        {
            menuGroup.ID = menuGroupVm.ID;
            menuGroup.Name = menuGroupVm.Name;
        }

        public static void updateOrder(this Order order, OrderViewModel orderVm)
        {
            order.OrderID = orderVm.OrderID;
            order.OrderStatus = orderVm.OrderStatus;
            order.PaymentStype = orderVm.PaymentStype;
            order.ShippingAddress = order.ShippingAddress;
            order.TotalCost = orderVm.TotalCost;

            order.created_by = orderVm.created_by;
            order.created_date = orderVm.created_date;
            order.updated_by = orderVm.updated_by;
            order.updated_date = orderVm.updated_date;
        }

        public static void updateOrderDetail(this OrderDetail orderDetail, OrderDetailViewModel orderDetailVm)
        {
            orderDetail.OrderID = orderDetailVm.OrderID;
            orderDetail.ProductID = orderDetailVm.ProductID;
            orderDetail.Quantity = orderDetailVm.Quantity;
            orderDetail.Price = orderDetailVm.Price;
            orderDetail.PromotionID = orderDetailVm.PromotionID;
        }

        //public static void updatePermissionAccess(this PermissionAccess permissionAccess, PermisionAccessViewModel permissionAccessVm)
        //{
        //    permissionAccess.ID = permissionAccessVm.ID;
        //    permissionAccess.Name = permissionAccessVm.Name;
        //    permissionAccess.Description = permissionAccessVm.Description;

        //    permissionAccess.created_by = permissionAccessVm.created_by;
        //    permissionAccess.created_date = permissionAccessVm.created_date;
        //    permissionAccess.updated_by = permissionAccessVm.updated_by;
        //    permissionAccess.updated_date = permissionAccessVm.updated_date;
        //}

        public static void updateProduct(this Product product, ProductViewModel productVm)
        {
            product.ProductID = productVm.ProductID;
            product.ProductName = productVm.ProductName;
            product.PublicationDate = productVm.PublicationDate;
            product.Pagenumber = productVm.Pagenumber;
            product.Quantity = productVm.Quantity;
            product.Size = productVm.Size;
            product.Covertype = productVm.Covertype;
            product.ProductCategoryID = productVm.ProductCategoryID;
            product.Author = productVm.Author;
            product.Stralator = productVm.Stralator;
            product.Publishinghouse = productVm.Publishinghouse;
            product.ProductStatus = productVm.ProductStatus;
            product.SupplyhouseID = productVm.SupplyhouseID;
            product.Description = productVm.Description;
            product.created_by = productVm.created_by;
            product.created_date = productVm.created_date;
            product.updated_by = productVm.updated_by;
            product.updated_date = productVm.updated_date;
        }

        public static void updateProductCategory(this ProductCategory productCategory, ProductCategoryViewModel productCategoryVm)
        {
            productCategory.ProductCategoryID = productCategoryVm.ProductCategoryID;
            productCategory.ProductCategoryName = productCategoryVm.ProductCategoryName;

            productCategory.created_by = productCategoryVm.created_by;
            productCategory.created_date = productCategoryVm.created_date;
            productCategory.updated_by = productCategoryVm.updated_by;
            productCategory.updated_date = productCategoryVm.updated_date;
        }

        public static void updateProductImages(this ProductImages productImages, ProductImageViewModel productImagesVm)
        {
            productImages.ProductImagesID = productImagesVm.ProductImagesID;
            productImages.ProductImagesName = productImagesVm.ProductImagesName;
            productImages.ProductID = productImagesVm.ProductID;
        }


        public static void updateProductWarehouse(this ProductWarehouse productWarehouse, ProductWarehouseViewModel productWarehouseVm)
        {
            productWarehouse.ProductID = productWarehouseVm.ProductID;
            productWarehouse.WarehouseID = productWarehouseVm.WarehouseID;
            productWarehouse.Position = productWarehouseVm.Position;
            productWarehouse.Quantity = productWarehouseVm.Quantity;
        }

        public static void updatePromotion(this Promotion promotion, PromotionViewModel promotionVm)
        {
            promotion.PromotionID = promotionVm.PromotionID;
            promotion.PromotionName = promotionVm.PromotionName;
            promotion.PromotionValues = promotionVm.PromotionValues;
            promotion.Startdate = promotionVm.Startdate;
            promotion.Finishdate = promotionVm.Finishdate;
            promotion.PromotionStatus = promotionVm.PromotionStatus;

            promotion.created_by = promotionVm.created_by;
            promotion.created_date = promotionVm.created_date;
            promotion.updated_by = promotionVm.updated_by;
            promotion.updated_date = promotionVm.updated_date;
        }

        public static void updatePromotionImages(this PromotionImages promotionImages, PromotionImagesViewModel promotionImagesVm)
        {
            promotionImages.PromotionImagesID = promotionImagesVm.PromotionImagesID;
            promotionImages.PromotionImagesName = promotionImagesVm.PromotionImagesName;
            promotionImages.PromotionID = promotionImagesVm.PromotionID;
        }

        public static void updatePromotionProduct(this PromotionProduct promotionProduct, PromotionProductViewModel promotionProductVm)
        {
            promotionProduct.PromotionID = promotionProductVm.PromotionID;
            promotionProduct.ProductID = promotionProductVm.ProductID;
        }

        public static void updateReceipt(this Receipt receipt, ReceiptViewModel receiptVm)
        {
            receipt.ReceiptID = receiptVm.ReceiptID;
            receipt.SupplyhouseID = receiptVm.SupplyhouseID;
            receipt.WarehouseID = receiptVm.WarehouseID;
            receipt.ToTalCost = receiptVm.ToTalCost;

            receipt.created_by = receiptVm.created_by;
            receipt.created_date = receiptVm.created_date;
            receipt.updated_by = receiptVm.updated_by;
            receipt.updated_date = receiptVm.updated_date;
        }

        public static void updateReceiptDetail(this ReceiptDetail receiptDetail, ReceiptDetailViewModel receiptDetailVm)
        {
            receiptDetail.ReceiptID = receiptDetailVm.ReceiptID;
            receiptDetail.ProductID = receiptDetailVm.ProductID;
            receiptDetail.Quantity = receiptDetailVm.Quantity;
            receiptDetail.Price = receiptDetailVm.Price;
        }

        public static void updateShoppingCart(this ShoppingCart shoppingCart, ShoppingCartViewModel shoppingCartVm)
        {
            shoppingCart.ShoppingCartID = shoppingCartVm.ShoppingCartID;
            shoppingCart.Quantity = shoppingCartVm.Quantity;
            shoppingCart.TotalCost = shoppingCartVm.TotalCost;

            shoppingCart.created_by = shoppingCartVm.created_by;
            shoppingCart.created_date = shoppingCartVm.created_date;
            shoppingCart.updated_by = shoppingCartVm.updated_by;
            shoppingCart.updated_date = shoppingCartVm.updated_date;
        }

        public static void updateShoppingCartDetail(this ShoppingCartDetail shoppingCartDetail , ShoppingCartDetailViewModel shoppingCartDetailVm)
        {
            shoppingCartDetail.ShoppingCartID = shoppingCartDetailVm.ShoppingCartID;
            shoppingCartDetail.ProductID = shoppingCartDetailVm.ProductID;
            shoppingCartDetail.Quantity = shoppingCartDetailVm.Quantity;
            shoppingCartDetail.Price = shoppingCartDetailVm.Price;
            shoppingCartDetail.PromotionID = shoppingCartDetailVm.PromotionID;
        }

        public static void updateSupplyhouse(this Supplyhouse supplyhouse , SupplyhouseViewModel supplyhouseVm)
        {
            supplyhouse.SupplyhouseID = supplyhouseVm.SupplyhouseID;
            supplyhouse.SupplyhouseName = supplyhouseVm.SupplyhouseName;
            supplyhouse.SupplyhouseAddress = supplyhouseVm.SupplyhouseAddress;
            supplyhouse.SupplyhouseNumberphone = supplyhouseVm.SupplyhouseNumberphone;
        }

        public static void updateWarehouse(this Warehouse warehouse , WarehouseViewModel warehouseVm)
        {
            warehouse.WarehouseID = warehouseVm.WarehouseID;
            warehouse.WarehouseName = warehouseVm.WarehouseName;
            warehouse.WarehouseAddress = warehouseVm.WarehouseAddress;
            warehouse.WarehouseNumberphone = warehouseVm.WarehouseNumberphone;
        }


    }
}