using ERP1.Data;
using ERP1.Models;

namespace ERP1.Application.User
{
    public class GetUsersQueryHandler
    {
        private readonly ApplicationDbContext _context;

        public GetUsersQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

    }
}
