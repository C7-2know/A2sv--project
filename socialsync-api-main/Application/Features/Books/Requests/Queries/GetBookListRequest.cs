using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

using Application.Common.DTOs.Book;

namespace Application.Features.Books.Requests.Queries;

public class GetBookListRequest : IRequest<List<BookDTO>>
{
}

