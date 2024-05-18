using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Solid.Data;

namespace Solid.Controllers;

public class CompaniesController : ControllerBase
{
    private readonly SolidBaseContext _context;
    //CONSTRUCTOR
    public CompaniesController(SolidBaseContext context)
    {
        _context = context;
    }

    //funcionalidades
}