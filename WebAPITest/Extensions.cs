using WebAPI.Dtos;

namespace WebAPI
{
    public static class Extensions
    {
        public static ItemDto AsDto(this Entities.Item item)
        {
            return new ItemDto
            {
                Id = item.Id,
                Name = item.Name,
                Price = item.Price,
                CreatedDate = item.CreatedDate
            };
        }
    }
}
