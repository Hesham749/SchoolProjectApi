﻿using SchoolProject.Core.Wrappers;
using SchoolProject.Domain.Enums;

namespace SchoolProject.Core.Features.Students.Queries.Models;


public class GetStudentPaginatedListQuery : IRequest<PaginatedResult<GetStudentPaginatedListResponse>>
{
    public int PageNumber { get; set; }

    public int PageSize { get; set; }

    public StudentOrderingEnum OrderBy { get; set; }

    public string? Search { get; set; }
}
