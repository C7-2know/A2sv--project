using Application.Contracts.Persistence;
using Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories;

public class BookRepository : GenericRepository<Book>, IBookRepository
{
    private readonly BookSTOREDbContext _dbContext;

    public BookRepository(BookSTOREDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
}

