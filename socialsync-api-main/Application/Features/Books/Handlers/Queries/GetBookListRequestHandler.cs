using AutoMapper;

using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

using Application.Common.DTOs.Book;
using Application.Common.DTOs.Book.Validators;
using Application.Features.Books.Requests.Queries;
using Application.Contracts.Persistence;
using Domain.Entites;

namespace Application.Features.Books.Handlers.Queries;

public class GetBookListRequestHandler : IRequestHandler<GetBookListRequest, List<BookDTO>>
{
    private readonly IBookRepository _BookRepository;
    private readonly IMapper _mapper;


    public GetBookListRequestHandler(IBookRepository bookRepository,
            IMapper mapper)
    {
        _BookRepository = bookRepository;
        _mapper = mapper;
    }

    public async Task<List<BookDTO>> Handle(GetBookListRequest request, CancellationToken cancellationToken)
    {
        var BookDTOs = new List<BookDTO>();

        var Books = await _BookRepository.GetAll();
        BookDTOs = _mapper.Map<List<BookDTO>>(Books.ToList());
        return BookDTOs;
    }
}

