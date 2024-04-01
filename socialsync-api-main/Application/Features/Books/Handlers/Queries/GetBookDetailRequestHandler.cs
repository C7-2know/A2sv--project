using AutoMapper;

using MediatR;
using System.Threading;
using System.Threading.Tasks;

using Application.Common.DTOs.Book;
using Application.Common.DTOs.Book.Validators;
using Application.Common.Exceptions;
using Application.Features.Books.Requests.Queries;
using Application.Contracts.Persistence;
using Domain.Entites;

namespace Application.Features.Books.Handlers.Queries;

public class GetBookDetailRequestHandler : IRequestHandler<GetBookDetailRequest, BookDTO>
{
    private readonly IBookRepository _BookRepository;
    private readonly IMapper _mapper;

    public GetBookDetailRequestHandler(IBookRepository bookRepository, IMapper mapper)
    {
        _BookRepository = bookRepository;
        _mapper = mapper;
    }
    public async Task<BookDTO> Handle(GetBookDetailRequest request, CancellationToken cancellationToken)
    {
        var Book = await _BookRepository.Get(request.Id);
        return _mapper.Map<BookDTO>(Book);
    }
}

