using AutoMapper;
using BookSale.Model.Models;
using BookSale.WEB.Models;

namespace BookSale.WEB.Mappings
{
    public class AutoMapperConfiguration
    {
        public static IMapper Mapping;

        public static void config()
        {
            var mapperConfig = new AutoMapper.MapperConfiguration(config =>
            {
                config.CreateMap<Account, AccountViewModel>();
                config.CreateMap<AccountPermission, AccountPermissionViewModel>();
                config.CreateMap<AccountProfile, AccountProfileViewModel>();
                config.CreateMap<Error, ErrorViewModel>();
                config.CreateMap<Footer, FooterViewModel>();

                config.CreateMap<Menu, MenuViewModel>();
                config.CreateMap<MenuGroup, MenuGroupViewModel>();
                config.CreateMap<Order, OrderViewModel>();
                config.CreateMap<OrderDetail, OrderDetailViewModel>();
                config.CreateMap<PermissionAccess, PermisionAccessViewModel>();

                config.CreateMap<Product, ProductViewModel>();
                config.CreateMap<ProductImages, ProductImageViewModel>();
                config.CreateMap<ProductPrice, ProductPriceViewModel>();
                config.CreateMap<ProductWarehouse, ProductWarehouseViewModel>();
                config.CreateMap<ProductCategory, ProductCategoryViewModel>();

                config.CreateMap<Promotion, PromotionViewModel>();
                config.CreateMap<PromotionImages, PromotionImagesViewModel>();
                config.CreateMap<PromotionProduct, PromotionProductViewModel>();
                config.CreateMap<Receipt, ReceiptViewModel>();
                config.CreateMap<ReceiptDetail, ReceiptDetailViewModel>();

                config.CreateMap<ShoppingCart, ShoppingCartViewModel>();
                config.CreateMap<ShoppingCartDetail, ShoppingCartDetailViewModel>();
                config.CreateMap<Supplyhouse, SupplyhouseViewModel>();
                config.CreateMap<Warehouse, WarehouseViewModel>();
            });
            Mapping = mapperConfig.CreateMapper();
        }
    }
}